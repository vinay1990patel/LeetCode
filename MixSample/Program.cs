using Microsoft.AspNetCore.Builder;
using MixSample.CustomMiddleWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();    //  used for web api
builder.Services.AddMvc();            // used  for MVC 
builder.Services.AddTransient<CustomeMiddleWare>();
builder.Services.AddSwaggerGen();

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


//app.UseMiddleware<CustomeMiddleWare>();
//app.Map("/custom", customCode);


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





// Configure the HTTP request pipeline.

app.UseRouting();  // Default routing 

// Request pipe line can have multiple middleware    1. Custom middleware 2 . prebuild middleware


app.MapGet("time/utc", () => Results.Ok(DateTime.Now));

// app.UseHttpsRedirection();

//app.UseAuthorization();




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

app.Run();
void customCode(IApplicationBuilder app)
{
    app.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("custom middle ware /n");
        await next();
    });
}




