using AAFormsAuthentication.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace AAFormsAuthentication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Habilitando o Filtro para aceitar apenas requisições
            //Autenticadas
            FilterConfig.RouteConfig(GlobalFilters.Filters);
        }
    }
}
