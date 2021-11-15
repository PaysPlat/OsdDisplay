using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OsdDisplayTestApplication
{
    public static class DisplayHelper
    {
        public static void Start()
        {
            Process.Start(@"..\..\..\..\OsdDisplay\bin\Debug\net48\OsdDisplay.exe");
        }


        public static void Display(string message)
        {
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(2), };
            httpClient.GetAsync($"http://localhost:9000/api/Display?message={message}");
        }

        public static void ClearDisplay()
        {
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(2), };
            httpClient.GetAsync($"http://localhost:9000/api/ClearDisplay");
        }

        public static void Close()
        {
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(2), };
            httpClient.GetAsync($"http://localhost:9000/api/Close");
        }
    }
}
