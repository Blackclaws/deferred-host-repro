using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using server;

namespace test;

public class CustomWebApplicationFactory : WebApplicationFactory<WeatherForecast>
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        Console.WriteLine("Starting Host build in Custom Factory (Expected Order 1)");
        var host = builder.Build();
        Console.WriteLine("Finished Host build starting work in Custom Factory (Expected Order 2)");
        Thread.Sleep(1000);
        Console.WriteLine("Finished work in Custom Factory, starting Host (Expected Order 3)");
        host.Start();
        return host;
    }
}