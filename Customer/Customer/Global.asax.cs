﻿using Customer.BusinessLayer.Mapping;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Customer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
            UnityWebApiActivator.Start();
            AutoMapperConfiguration.ConfigureAll();
        }
    }
}
