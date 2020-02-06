using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCUsingModelValidation.Models
{
    public class User
    {
        [Required(ErrorMessage ="Enter name")]
        [StringLength(maximumLength:10,MinimumLength =5,ErrorMessage ="name should be valid")]
        public string Name { get; set; }
        [Required(ErrorMessage = "pls enter email")]
        [EmailAddress(ErrorMessage ="Invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="pls enter date")]
       // [Range(1-1-1998,1-5-2018)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "pls enter mobile")]
        [RegularExpression(@"[6-7]/d{9}",ErrorMessage ="Invalid number")]
        public string Phno { get; set; }
        [Required(AllowEmptyStrings=false, ErrorMessage = "pls select Country")]

        public string Country { get; set; }
        [Required(ErrorMessage = "pls enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "pls enter password")]
        [RegularExpression(@"[a-z0-9]{6,8}",ErrorMessage ="Invalid Password")]
        public string Pass { get; set; }

    }
}
