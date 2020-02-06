using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreExample.models
{
    public interface IEmployeeRepositories
    {
        Employee GetEmployee(int Id);
        List<Employee> Displaydetails();
        bool AddEmployee(Employee employee);
    }
}
