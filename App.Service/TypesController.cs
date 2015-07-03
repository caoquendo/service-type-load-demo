using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Web.Http;

namespace App.Service
{
    public class TypesController : ApiController
    {
        public HttpResponseMessage GetByName(String name)
        {
            var type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).FirstOrDefault(t => t.Name == name);

            return new HttpResponseMessage
            {
                Content = new StringContent(type.FullName)
            };
        }
    }
}
