using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoCookiesSession.Models
{
    public class UserAccContext:DbContext
    {
        public UserAccContext(DbContextOptions<UserAccContext> options):base(options)
        {

        }
        public DbSet<UserAccount> UserAccount { get; set; }
    }
}
