using Microsoft.Extensions.DependencyInjection;
using System;
using Service;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static Task Main(string[] args)
        {
            //setup  DI
            using IHost host = CreateHostBuilder(args).Build();

            DependencyInjection(host.Services);

            return host.RunAsync();

        }


        static void DependencyInjection(IServiceProvider services)
        {
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            
            ICalculator fibonacci = provider.GetRequiredService<ICalculator>();
            int range =0 ;
            Console.WriteLine("Please Enter A Valid Number....");

            while (!int.TryParse(Console.ReadLine(), out range)) {
                Console.WriteLine("Please Enter A Valid Number....");
            }

            Console.WriteLine(string.Format("The Sum Value Is: {0}", fibonacci.SumOfEvenTerms(range)));

            Console.WriteLine();
        }
        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddScoped<ICalculator, Calculator>());

       
    }
}
