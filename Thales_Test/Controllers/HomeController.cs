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

        public async Task<IActionResult> Index(int id)
        {
            _baseUrl = _serviceApi.GetBaseUrl();
            EmployeeBusinessLogic businessLogic = new EmployeeBusinessLogic();
            if (id == 0)
            {
                List<Employee> employees = await businessLogic.GetAll(_baseUrl);
                return View(employees);
            }
            else
            {
                List<Employee> employee = await businessLogic.GetById(id, _baseUrl);
                return View(employee);
            }
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