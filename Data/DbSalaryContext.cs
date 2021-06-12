using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using azureDbSalary.Models;

namespace azureDbSalary.Data
{
    public class DbSalaryContext : DbContext
    {
        public DbSalaryContext (DbContextOptions<DbSalaryContext> options)
            : base(options)
        {
        }

        public DbSet<azureDbSalary.Models.Employee> Employee { get; set; }
    }
}
