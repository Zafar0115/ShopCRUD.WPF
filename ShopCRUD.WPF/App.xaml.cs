using Microsoft.Extensions.DependencyInjection;
using ShopCRUD.Data.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShopCRUD.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider? _serviceProvider;
        private readonly string mysqlConnectionString = "XXXXXXXXX";
        private readonly string mysqlServerVersion = "XXXXXXXXXXXX";



        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var serviceCollection=new ServiceCollection();
            serviceCollection.AddSingleton(new ShopDbContext(mysqlConnectionString,mysqlServerVersion));

        }


        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _serviceProvider?.Dispose();
        }
    }
}
