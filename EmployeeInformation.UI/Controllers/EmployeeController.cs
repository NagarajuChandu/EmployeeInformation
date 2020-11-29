using EmployeeInformation.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace EmployeeInformation.UI.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            IList<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            return View(employees);
        }
        // GET: Employee
        public ActionResult getEmployee()
        {
            List<EmployeeViewModel> employees = null;

            using (var client = new HttpClient())
            {
                string ID = Request.Form["search"].ToString();
                  //HTTP GET
                int intType;
                if (ID != string.Empty )
                    if(int.TryParse(ID, out intType) == false)
                        return View("Index", new List<EmployeeViewModel>());
                
                    client.BaseAddress = new Uri("https://localhost:44378/api/");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var responseTask = client.GetAsync("EmployeeInformation" + (ID == string.Empty ? "/GetAllEmployees" : "/GetEmployeeByID/" + Convert.ToInt32(ID)));

                    responseTask.Wait();

                    var result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        if (ID == string.Empty)
                        {
                            employees = result.Content.ReadAsAsync<List<EmployeeViewModel>>().Result;
                        }
                        else
                        {
                            EmployeeViewModel employee = result.Content.ReadAsAsync<EmployeeViewModel>().Result;
                            employees = new List<EmployeeViewModel>();
                            employees.Add(employee);

                        }
                    }
                    return View("Index", employees);
                

                
            }
           

        }

       
    }
}