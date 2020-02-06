using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreExample.models
{
    public class EmployeeRepositories:IEmployeeRepositories
    {
        private List<Employee> emplist;
        public EmployeeRepositories()
        {
            emplist = new List<Employee>() { new Employee(1,"divya","abc@gmail.com",Dept.Insurance),
                                              new Employee(2,"kalyani","abcfg@gmail.com",Dept.IT),
                                              new Employee(3,"hamsi","abcsd@gmail.com",Dept.IT) };
        }
        public Employee GetEmployee(int Id)
        {
            Employee e = emplist.FirstOrDefault(e=>e.id==Id);
            return e;
        }
        public List<Employee>  Displaydetails()
        {
            return emplist;
        }
        public bool AddEmployee(Employee emp)
        {
            emp.id = emplist.Max(e => e.id) + 1;
            emplist.Add(emp);
            return true;
        }
    }
}
