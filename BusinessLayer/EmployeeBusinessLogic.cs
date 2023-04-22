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
            DataEmployee dataEmployee = await _service.GetById(id, _baseUrl);
            Employee employee = new Employee();
            if (dataEmployee.Id == -429)
            {
                employee.Id = dataEmployee.Id;
            }
            else
            {
                employee.Id = dataEmployee.Id;
                employee.EmployeeName = dataEmployee.EmployeeName;
                employee.EmployeeSalary = dataEmployee.EmployeeSalary;
                employee.ProfileImage = dataEmployee.ProfileImage;
                employee.EmployeeAge = dataEmployee.EmployeeAge;
                CalculateAnualSalary(employee);
            }
            
            return employee;
        }

        public void CalculateAnualSalary(Employee employee)
        {
            employee.EmployeeAnualSalary = employee.EmployeeSalary * 12;
        }


    }
}