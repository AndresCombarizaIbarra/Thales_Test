using DataLayer.Services;
using DataLayer;

namespace BusinessLayer
{
    public class EmployeeBusinessLogic
    {
        private readonly DataLayer.Services.DataService _service = new DataService();

        public EmployeeBusinessLogic()
        {
            
        }
        public async Task<List<Employee>> GetAll(string baseUrl)
        {
            List<Employee> employees = await _service.GetAll(baseUrl);

            foreach (var item in employees)
            {
                CalculateAnualSalary(item);
            }
            return employees;
        }

        public async Task<Employee> GetById(int id, string _baseUrl)
        {
            Employee employee = await _service.GetById(id, _baseUrl);
            CalculateAnualSalary(employee);
            return employee;
        }

        public void CalculateAnualSalary(Employee employee)
        {
            employee.EmployeeAnualSalary = employee.EmployeeSalary * 12;
        }


    }
}