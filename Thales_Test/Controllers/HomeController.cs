using BusinessLayer;
using DataLayer;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Thales_Test.Models;
using Thales_Test.Services;

namespace Thales_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService service_API;
        private readonly ServiceApi _serviceApi = new ServiceApi();
        public static string _baseUrl; 

        public async Task<IActionResult> Index()
        {
           _baseUrl = _serviceApi.GetBaseUrl();
            EmployeeBusinessLogic businessLogic = new EmployeeBusinessLogic();
            List<Employee> employees = await businessLogic.GetAll(_baseUrl);
            return View(employees);
        }

        public async Task<IActionResult> Employee(int id)
        {
            _baseUrl = _serviceApi.GetBaseUrl();
            EmployeeBusinessLogic businessLogic = new EmployeeBusinessLogic();
            Employee employee = new Employee();

            if (id != 0)
            {
                employee = await businessLogic.GetById(id, _baseUrl);
            }
            return View(employee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}