using BISP.ApplicationLayer;
using BISP.InfrastructureLayer;
using BISP.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace BISP.UI;

public partial class App : Application
{
    private IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                ConfigureServices(services);
            })
            .Build();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<AppDbContext>();
        services.AddSingleton<IProductRepository, ProductRepository>();
        services.AddSingleton<IProductService, ProductService>();
        services.AddTransient<MainViewModel>();
        services.AddTransient<MainWindow>();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        await _host.StartAsync();

        var mainWindow = new MainWindow
        {
            DataContext = _host.Services.GetRequiredService<MainViewModel>()
        };
        mainWindow.Show();
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);

        await _host.StopAsync(TimeSpan.FromSeconds(5));
    }
}
