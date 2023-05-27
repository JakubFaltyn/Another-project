using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_CRUD_Customers_app.Data;


namespace WPF_CRUD_Customers_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Private members
        private readonly ServiceProvider serviceProvider;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddDbContext<CustomerDbContext>(options =>
            {
                options.UseSqlite("Data Source = Customer.db");
            });

            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the application startup event.
        /// </summary>
        /// <param name="s">The sender object.</param>
        /// <param name="e">The startup event arguments.</param>
        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
        #endregion
    }
}