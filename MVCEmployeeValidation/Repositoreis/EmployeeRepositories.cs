using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCEmployeeValidation.Models;

namespace MVCEmployeeValidation.Repositoreis
{
    public class EmployeeRepositories
    {
        public static List<Employee> elist = new List<Employee>()
       {
           new Employee()
           {
               Name="kalyani",Empid=1,Pass="7890"
           }
       };
        public EmployeeRepositories()
        {

        }
        public void Add(Employee item)
        {
            elist.Add(item);
        }
        public Employee Validate(int id,string pass)
        {
            foreach (var i in elist)
            {
                if (i.Empid==id && i.Pass==pass)
                {
                    return i;
                }
            }
            return null;
        }


    }
}
