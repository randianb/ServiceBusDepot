﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;

namespace ServiceBusDepot.ConsoleHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "Service Bus Depot";

            IUnityContainer _container = new UnityContainer();
            _container.AddNewExtension<Configuration.UnityRegistrations>();

            _container.Resolve<Application>().Run(new Features.Application.Initialisation.Request());
        }

    }
}
