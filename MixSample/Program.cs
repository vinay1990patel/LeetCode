using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MixSample.CustomMiddleWare;
using MixSample.DbContextLayer;
using MixSample.Model;
using MixSample.Repository;
using MixSample.Repository.Interface;
using MixSample.Repository.Services;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using System.Text;
using System.Threading.RateLimiting;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

// MixedDbContext


builder.Services.AddMvc();
//builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); ;    //  used for web api

builder.Services.AddDbContext<MixedDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MixedDbContextConnectionString"));
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                           .AddEntityFrameworkStores<MixedDbContext>()
                            .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

})
    .AddJwtBearer(option =>
    {
        option.SaveToken = true;
        option.RequireHttpsMetadata = false;
        option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = configuration["jwt:Validaudience"],
            ValidIssuer = configuration["jwt:ValidIssure"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:Secret"]))
        };
    });


builder.Services.AddTransient<CustomeMiddleWare>();
builder.Services.AddSingleton<IWeatherForecast, WeatherForecastServices>();
builder.Services.AddScoped<IBook, BookService>();
builder.Services.AddTransient<IEmployee, EmployeeService>();    //   
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<IAccountRepository, AccountRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddAutoMapper(typeof(Program));

builder.Logging.ClearProviders();
builder.Logging.AddLog4Net();
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddAuthentication();
builder.Services.AddAuthentication();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddRateLimiter(rateLimiterOptions =>
{

    rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    // Rate Limit by IP
    rateLimiterOptions.AddPolicy("FixedUsingIP", httpcontext =>
      RateLimitPartition.GetFixedWindowLimiter(
           partitionKey: httpcontext.Connection.RemoteIpAddress.ToString(),
           factory: _ => new FixedWindowRateLimiterOptions
           {
               AutoReplenishment = true,
               PermitLimit = 3,
               QueueLimit = 3,
               QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
               Window = TimeSpan.FromSeconds(5)
           }
          )
       );

    // Rate Limit by User
    rateLimiterOptions.AddPolicy("FixedUsingUser", httpcontext =>
         RateLimitPartition.GetFixedWindowLimiter(
              partitionKey: httpcontext.User.Identity?.Name.ToString(),
              factory: _ => new FixedWindowRateLimiterOptions
              {
                  AutoReplenishment = true,
                  PermitLimit = 3,
                  QueueLimit = 3,
                  QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                  Window = TimeSpan.FromSeconds(5)
              }
             )
          );

    // Global RateLimit
    rateLimiterOptions.AddFixedWindowLimiter("fixed", options =>
    {
        options.Window = TimeSpan.FromSeconds(10);
        options.PermitLimit = 3;
        options.QueueLimit = 0;
        options.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
        options.AutoReplenishment = true;

    });
    rateLimiterOptions.AddSlidingWindowLimiter("sliding", option =>
    {
         option.Window = TimeSpan.FromSeconds(15);
         option.SegmentsPerWindow = 3;
         option.PermitLimit = 15;
         option.QueueLimit = 3;
         option.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
         option.AutoReplenishment = true;
    });
    rateLimiterOptions.AddTokenBucketLimiter("token", option => {
        option.TokenLimit = 5;
        option.ReplenishmentPeriod = TimeSpan.FromSeconds(5);
        option.AutoReplenishment = true;
        option.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
        option.TokensPerPeriod = 10; 
    });
    rateLimiterOptions.AddConcurrencyLimiter("Concurrency", option => {
        option.QueueLimit = 3;
        option.PermitLimit = 3;
        option.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
    });
});


builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService("MixSample"))
    .WithMetrics(metrics =>
    {
        metrics.AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation();
        metrics.AddOtlpExporter();

    })
    .WithTracing(tracing =>
    {
        tracing.AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation();
       
        tracing.AddOtlpExporter();
    });

builder.Logging.AddOpenTelemetry(logging => {
    logging.AddOtlpExporter();
});

// just for github
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var db = services.GetRequiredService<MixedDbContext>();
    // Option A: apply pending migrations (recommended for production-like migrations)
    db.Database.Migrate();

    // Option B: ensure database created (simple, no migrations, good for quick local/dev)
    // db.Database.EnsureCreated();
}

// Global middleware ordering
app.UseCors();
app.UseRouting();
app.UseRateLimiter();
app.UseAuthentication();
app.UseAuthorization();

// Map controller endpoints so controllers are discoverable by ApiExplorer/Swashbuckle
app.MapControllers();

//Serve swagger UI in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ocelot must be last so it doesn't preempt internal routes like /swagger or /api/*
// await app.UseOcelot();

app.Run();





