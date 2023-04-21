﻿using DataLayer.Services;
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

        public async Task<List<Employee>> GetById(int id, string _baseUrl)
        {
            List<Employee> employee = await _service.GetById(id, _baseUrl);
            foreach (var item in employee)
            {
                CalculateAnualSalary(item);
            }
            return employee;
        }

        public void CalculateAnualSalary(Employee employee)
        {
            employee.EmployeeAnualSalary = employee.EmployeeSalary * 12;
        }


    }
}