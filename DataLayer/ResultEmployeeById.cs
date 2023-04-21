using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class ResultEmployeeById
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataEmployee Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public partial class DataEmployee
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; }

        [JsonProperty("employee_salary")]
        public long EmployeeSalary { get; set; }

        [JsonProperty("employee_age")]
        public long EmployeeAge { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }
    }
}
