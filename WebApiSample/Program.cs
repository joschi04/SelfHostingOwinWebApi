using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using WebApiSample;

namespace OwinSelfhostSample
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                (new MainForm()).ShowDialog();
            }

            Console.ReadLine();
        }
    }
}