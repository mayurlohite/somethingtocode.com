﻿using FluentValidation.Mvc;
using SomethingToCode.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SomethingToCode.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Add(new CustomSCViewEngine());
            FluentValidationModelValidatorProvider.Configure();

            //disable "X-AspNetMvc-Version" header name
            MvcHandler.DisableMvcResponseHeader = true;
        }
    }
}
