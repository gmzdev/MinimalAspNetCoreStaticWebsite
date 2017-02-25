using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for running without static files
            // new WebHostBuilder()
            //     .UseKestrel()
            //     .Configure(a => a.Run(c => c.Response.WriteAsync("Hello World!")))
            //     .Build()
            //     .Run();

            new WebHostBuilder()
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseStartup<Startup>()
               .Build()
               .Run();
        }
    }
}
