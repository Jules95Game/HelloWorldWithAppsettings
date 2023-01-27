using Microsoft.Extensions.Hosting;

namespace HelloWorldWithAppsettings.ConsoleApp;

internal class Program
{
    private static void Main()
    {
        IHost host = Host.CreateDefaultBuilder().Build();
    }
}