using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace EmployeeInformation.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "EmployeeInfo",
                routeTemplate: "api/EmployeeInformation/GetAllEmployees",
                defaults: new { controller = "EmployeeInformation", action = "GetAllEmployees" });

            config.Routes.MapHttpRoute(
               name: "EmployeeInfoByID",
               routeTemplate: "api/EmployeeInformation/GetEmployeeByID/{ID}",
               defaults: new { controller = "EmployeeInformation", action = "GetEmployeeByID", ID = RouteParameter.Optional });


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

                config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
            
        }
    }
}
