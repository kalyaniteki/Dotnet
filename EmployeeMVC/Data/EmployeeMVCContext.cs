using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeMVC.Models;

namespace EmployeeMVC.Data
{
    public class EmployeeMVCContext : DbContext
    {
        public EmployeeMVCContext (DbContextOptions<EmployeeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMVC.Models.Employee> Employee { get; set; }
    }
}
