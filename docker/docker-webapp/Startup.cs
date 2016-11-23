using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

public class Startup
{
    public void Configure(IApplicationBuilder app, ILoggerFactory logF)
    {
        logF.AddConsole();

        app.Run(context =>
        {
            //using (var conn = ConnectionMultiplexer.Connect("localhost:6379,abortConnect=false"))
            //{
            //    context.Response.WriteAsync(conn.GetStatus());
            //    var x = conn.GetDatabase().StringGet("test");
            //    context.Response.WriteAsync($"Redis: {x}");
                var id = context.Request.Query["id"];
            //    conn.GetDatabase().StringSet("test", x + id);
                return context.Response.WriteAsync("Hello World! " + id);
            //}
        });
    }
}