using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OsdDisplay.Host
{
    class HostService
    {
        string baseAddress = "http://localhost:9000/";
        private IDisposable _server;

        public void Start()
        {
            // Start OWIN host 
            _server = WebApp.Start<Startup>(url: baseAddress);
        }

        public void Stop()
        {
            _server.Dispose();
        }
    }
}
