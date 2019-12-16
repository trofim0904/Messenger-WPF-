﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MessangerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFService.MessangerService)))
            {
                host.Open();

                Console.WriteLine("<<WCF>> Host started....");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
