namespace MixSample.CustomMiddleWare
{
    public class CustomeMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("this is custom middleware \n");

            await next(context);
        }
    }
}
