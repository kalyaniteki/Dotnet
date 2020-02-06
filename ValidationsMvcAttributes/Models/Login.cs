using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ValidationsMvcAttributes.Models
{
    public class Login
    {
        [Required(ErrorMessage ="username required")]
        [DisplayName("Username")]
        public string uname { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "password required")]
        public string pass { get; set;}
    }
}
