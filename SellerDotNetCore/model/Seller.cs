using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDotNetCore.model
{
    public class Seller
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int phno { get; set; }

        public Seller(int id,string name,string password,string email,int phno)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.phno = phno;

        }
    }
}
