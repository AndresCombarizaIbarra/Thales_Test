using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Employee
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; }
        [JsonProperty("employee_salary")]
        public double EmployeeSalary { get; set; }
        [JsonProperty("employee_age")]
        public int EmployeeAge { get; set; }
        public string ProfileImage { get; set; }
        public double EmployeeAnualSalary { get; set; }
    }
}
