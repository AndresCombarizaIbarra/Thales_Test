using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DataLayer
{
    public partial class ResultEmployee
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<Employee> Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

