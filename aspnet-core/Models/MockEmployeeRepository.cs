using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){
                    Id = 1,
                    Department  = "HR",
                    Email = "test@test.com",
                    Name = "John",
                    Catalog = "abc"},
                new Employee(){
                    Id = 2,
                    Department  = "Engg",
                    Email = "engg@test.com",
                    Name ="Doe",
                    Catalog = "abc"},
                new Employee(){
                    Id = 3,
                    Department  = "Finance",
                    Email = "finance@test.com",
                    Name ="Jame",
                    Catalog = "abc"},
            };
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }
    }
}
