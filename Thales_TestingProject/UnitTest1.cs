using BusinessLayer;
using DataLayer;
using DataLayer.Services;
using Moq;

namespace Thales_TestingProject
{
    public class Tests
    {
        private EmployeeBusinessLogic businessLogic;
        
        [SetUp]
        public void Setup()
        {
            businessLogic = new EmployeeBusinessLogic();
        }

        [Test]
        public void CalculateAnualSalaryTest()
        {
            //Act
            Employee employee = new Employee(); 
            employee.EmployeeName = "Test";
            employee.EmployeeAge = 30;
            employee.EmployeeSalary = 100;
            var expectedResult = 1200;

            //Arrange
            businessLogic.CalculateAnualSalary(employee);

            //Assert
            Assert.That(employee.EmployeeAnualSalary, Is.EqualTo(expectedResult));
        }
    }
}