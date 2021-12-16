using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace BeerLeagueHockey
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Abc2");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            Console.WriteLine("Abc3");
            host.Run();
            Console.WriteLine("Abc4");
        }
    }
}
