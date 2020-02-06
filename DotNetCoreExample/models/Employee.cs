using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreExample.models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Length can be maximum 10")]
        [RegularExpression(@"[a-zA-Z]{4,7}",ErrorMessage ="name sholud ne valid")]
        public string name { get; set; }
        [Required]
        [EmailAddress( ErrorMessage ="email is not valid")]
        [DisplayName("company mail")]
        [Validatedomain(allowdomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller:"Employee")]
        public string email { get; set; }
        [Required]
        public Dept dept { get; set; }
        public Employee(int id,string name,string email,Dept dept)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.dept=dept;
        }
        public Employee()
        {

        }
    }
}
