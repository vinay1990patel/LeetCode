using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MixSample;
using MixSample.CustomMiddleWare;
using MixSample.DbContextLayer;
using MixSample.Model;
using MixSample.Repository;
using MixSample.Repository.Interface;
using MixSample.Repository.Services;
using Newtonsoft.Json;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json.Serialization;
using Unity.Injection;

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



//builder.Services.AddMvc();    // used  for MVC 

//builder.Services.AddMvc().AddJsonOptions(opt =>
//    opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
builder.Services.AddTransient<CustomeMiddleWare>();
builder.Services.AddSingleton<IWeatherForecast, WeatherForecastServices>();
builder.Services.AddTransient<IEmployee, EmployeeService>();    //   
//builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>(); 
builder.Services.AddTransient<IAccountRepository, AccountRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// Singlton = > There will be only one instance of singlton service thorught out the application. once you start application old instanc will distory and new singlton instance will be creatded.
// Scope    => The new instance of service will created for new http Request.
// Transient => A new instance of service will be created every time it is requested.
// TryAddSingleton => Adds the specified service as a Singleton service to the collection if the service type hasn't already been registered.


// [FormService]  =  use it for action level service dependency injection.

builder.Services.AddAutoMapper(typeof(Program));

builder.Logging.ClearProviders();
builder.Logging.AddLog4Net();
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
builder.Services.AddAuthentication();
builder.Services.AddAuthentication();
builder.Services.AddSwaggerGen();
// just for github
var app = builder.Build();



//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//    app.UseSwagger();
//    app.UseSwaggerUI(options =>
//    {
//        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//        options.RoutePrefix = string.Empty;

//    });
//    // app.UseHsts();
//}

//app.UseSwagger();
//app.UseSwaggerUI(options =>
//{
//    options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
//    options.RoutePrefix = string.Empty;

//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("use 1 1 \n");

//    await next();

//    await context.Response.WriteAsync("use 1 2 \n");

//});


app.UseMiddleware<CustomeMiddleWare>();
app.Map("/custom", customCode);


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("use 2 1 \n");

//    await next();

//    await context.Response.WriteAsync("use 2 2 \n");

//});



//app.Run(async context =>
//{
//    await context.Response.WriteAsync("run 1 \n");
//});




//app.Run(async context =>
//{
//    await context.Response.WriteAsync("run 2 \n");
//});



app.UseAuthentication();

// Configure the HTTP request pipeline.

app.UseRouting();  // Default routing 

app.UseAuthentication();

// Request pipe line can have multiple middleware    1. Custom middleware 2 . prebuild middleware

app.UseCors();
app.MapGet("time/utc", () => Results.Ok(DateTime.Now));

// app.UseHttpsRedirection();

//app.UseAuthorization();


app.UseAuthentication();

// Configure the HTTP request pipeline.

app.UseRouting();  // Default routing 

app.UseAuthentication();

app.UseEndpoints(endpoints =>      // customised services
{

    endpoints.MapControllers();




    //endpoints.MapGet("/", async context =>
    //{
    //    await context.Response.WriteAsync("Web Api is running in Default Url");

    //});

    //endpoints.MapGet("/test", async context =>
    //{
    //    await context.Response.WriteAsync("Web Api is running in test url");
    //});
});

// Run() is  use to complete the execution of middleware 
// Use() is use to insert a middleware in the pipeline
// Next() method is use to pass the execution from one middleware to another middleware  . if there are 6 middleware in a pipeline if next is not present 4th pipeline so the request will come back from 4th middlewares
// Map() is use to map the middleware to a specific Url.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
void customCode(IApplicationBuilder app)
{
    app.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("custom middle ware /n");
        await next();
    });
}




