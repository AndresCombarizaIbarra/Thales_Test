using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public interface IService_API
    {
        Task<List<Employee>> GetAll(string _baseUrl);
        Task<Employee> GetById(int id, string _baseUrl);
    }
}
