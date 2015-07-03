using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace App.Service
{
    public class HostedService : IDisposable
    {
        HttpSelfHostServer server;

        public HostedService()
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8088");

            config.Routes.MapHttpRoute(
                "Default",
                "api/{controller}/{name}");

            server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
        }

        public void Dispose()
        {
            server.Dispose();
        }
    }
}
