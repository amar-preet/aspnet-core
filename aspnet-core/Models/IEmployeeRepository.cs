using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee AddEmployee(Employee employee);
    }
}
