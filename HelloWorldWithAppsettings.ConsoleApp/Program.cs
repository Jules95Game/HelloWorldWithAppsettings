using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloWorldWithAppsettings.ConsoleApp;

internal class Program
{
    private static void Main()
    {
        IHost host = Host.CreateDefaultBuilder().Build();
        string message = host.Services.GetRequiredService<IConfiguration>().GetSection("ConsoleMessage").Value;
        Console.WriteLine(message);
        Console.ReadKey();
    }
}