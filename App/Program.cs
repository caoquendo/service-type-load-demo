using App.Service;
using App.TypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Person();

            using (var server = new HostedService())
            {
                Console.ReadLine();
            }
        }
    }
}
