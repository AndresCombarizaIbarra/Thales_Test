using BusinessLayer;
using DataLayer;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Thales_Test.Services;

namespace Thales_Test.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDataService service_API;
        private readonly ServiceApi _serviceApi = new ServiceApi();
        public static string _baseUrl;

        public async Task<IActionResult> EmployeeById(int id)
        {
            _baseUrl = _serviceApi.GetBaseUrl();
            EmployeeBusinessLogic businessLogic = new EmployeeBusinessLogic();
            Employee employee = await businessLogic.GetById(id, _baseUrl);
            return View(employee);
        }
    }
}
