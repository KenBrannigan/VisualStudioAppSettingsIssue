using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace VisualStudioAppSettingsIssue;

public class Program
{
    public static void Main()
    {
        IHostBuilder hostBuilder = Host.CreateDefaultBuilder();

        IHost host = hostBuilder.Build();

        // Get a value called testValue from the appsettings.json file
        string? testValue = host.Services
            .GetRequiredService<IConfiguration>()
            .GetValue<string>("testValue");

        Console.WriteLine($"testValue: {testValue}");
        Console.ReadLine();
    }
}