using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using System.Windows;

namespace OsdDisplay.Host
{

    public sealed class DisplayController : ApiController
    {

        [HttpGet]
        public void Display(string message)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                App.DisplayMessageService.UpdateMessage(message);
            });
        }

        [HttpGet]
        public void ClearDisplay()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                App.DisplayMessageService.UpdateMessage("");
            });
        }

        [HttpGet]
        public void Close()
        {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    App.Current.Shutdown();
                });
        }
    }
}
