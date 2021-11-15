using FunctionalTest.Helpers.OsdLogger;
using OsdDisplay.Host;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace OsdDisplay
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly HostService _hostService = new HostService();

        public static IDisplayMessageService DisplayMessageService { get; private set; }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var window = new OsdDisplayWindow();
            DisplayMessageService = window;

            _hostService.Start();
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _hostService.Stop();
        }


    }
}
