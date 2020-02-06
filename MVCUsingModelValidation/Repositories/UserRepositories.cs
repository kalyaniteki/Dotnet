using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCUsingModelValidation.Models;
namespace MVCUsingModelValidation.Repositories
{
    public class UserRepositories
    {
        public static List<User> list = new List<User>()
        
        {
           new User(){
            Name = "raj",
                Email = "raj@gmail.com",
                Country = "India",
                Username = "r123",
                Pass = "7890"
           }
        };
        public UserRepositories()
        {
           
        }
        public void Add(User item)
        {
            list.Add(item);//add user data into list
        }
        public User Validate(String uname,string pass)
        {
            foreach(var i in list)
            {
                if(i.Username==uname&&i.Pass==pass)
                {
                    return i;
                }

            }
            return null;
        }
    }
}
