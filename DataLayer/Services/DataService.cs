using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataLayer.Services
{
    public class DataService : IDataService
    {
        public DataService()
        {
            
        }
        public async Task<List<Employee>> GetAll(string _baseUrl)
        {
            List<Employee> employees = new List<Employee>();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var response = await client.GetAsync("api/v1/employees");
            
            try
            {
                if (response.ReasonPhrase == "Too Many Requests")
                {
                    Employee empl = new Employee();
                    empl.Id = -429;
                    employees.Add(empl);
                }

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ResultEmployee>(jsonResponse);
                    employees = result.Data;
                }

            }
            catch (Exception)
            {
                throw;
            }
            

            return employees;
        }

        public async Task<DataEmployee> GetById(int id, string _baseUrl)
        {
                       
            DataEmployee employee = new DataEmployee();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            try
            {
                var response = await client.GetAsync($"api/v1/employee/{id}");

                if (response.ReasonPhrase == "Too Many Requests")
                {
                    employee.Id = -429;
                }


                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ResultEmployeeById>(jsonResponse);
                    employee = result.Data;
                }


            }
            catch (Exception)
            {

                throw;
            }


            return employee;
        }
    }
}

