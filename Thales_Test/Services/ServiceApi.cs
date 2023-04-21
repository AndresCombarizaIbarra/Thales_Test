using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Thales_Test.Services
{
    public class ServiceApi
    {
        private static string _baseUrl;

        public ServiceApi()
        {
            
        }
        public string GetBaseUrl()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _baseUrl = builder.GetSection("ApiSettings:baseUrl").Value;

            return _baseUrl;
        }
    }
}
