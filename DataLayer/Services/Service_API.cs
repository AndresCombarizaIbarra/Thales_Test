using Newtonsoft.Json;

namespace DataLayer.Services
{
    public class Service_API : IService
    {
        public async Task<List<Employee>> GetAll(string _baseUrl)
        {
            List<Employee> employees = new List<Employee>();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var response = await client.GetAsync("api/v1/employees");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultEmployee>(jsonResponse);
                employees = result.Employees;
            }

            return employees;
        }

        public async Task<Employee> GetById(int id, string _baseUrl)
        {
            Employee employee = new Employee();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var response = await client.GetAsync($"api/v1/employee/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultEmployee>(jsonResponse);
                employee = result.Employee;
            }

            return employee;
        }
    }
}
