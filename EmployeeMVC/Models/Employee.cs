using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public enum Dept
     {
           IT,Accounts,Insurance
     }
         
    public class Employee
    {
       
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Dept dept { get; set; }
    }
}
