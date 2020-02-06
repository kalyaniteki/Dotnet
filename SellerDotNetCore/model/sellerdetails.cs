using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDotNetCore.model
{
    public class sellerdetails : Iseller
    {
        private List<Seller> slist;
        public sellerdetails()
        {
            slist = new List<Seller>() { new Seller(1,"divya","kal123","abc@gmail.com",6576),
                                          new Seller(2,"kalyani","jdnkj123","hbkj@gmail.com",7897),
                                             new Seller(3,"hamsi","ham123","ham@gmail.com",1443), };
        }
        public Seller GetEmployee(int Id)
        {
            Seller e = slist.FirstOrDefault(e => e.id == Id);
            return e;
        }
        public List<Seller> display()
        {
            return slist;
        }

    }
}
