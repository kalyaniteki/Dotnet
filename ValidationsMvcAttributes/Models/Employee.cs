using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ValidationsMvcAttributes.Models
{
    public class Employee
    {
        [Required(ErrorMessage="pls enter id")]
        [DisplayName("Employee ID")]
        public int id { get; set; }
        [Required(ErrorMessage = "pls enter name")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="name sholud me valid")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="Invalid email id")]
        public string email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage = "Invalid Mobile Number")]
        public string mobile { get; set; }
        [Required(ErrorMessage ="username is required")]
        public string uname { get; set; }
        [Required(ErrorMessage = "password is required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string pwd { get; set; }
        [Compare("pwd",ErrorMessage ="password mismatch")]
        public string cpwd { get; set; }


    }
}
