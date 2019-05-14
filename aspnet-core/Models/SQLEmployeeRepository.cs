using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }
    }
}
