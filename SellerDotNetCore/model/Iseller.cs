using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerDotNetCore.model
{
   public interface Iseller
    {
        Seller GetEmployee(int Id);
        List<Seller> display();
    }
}
