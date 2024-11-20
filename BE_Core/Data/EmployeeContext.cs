using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Core.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {

        }

        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }
       

        DbSet<Employee> Employees { get; set; }
        DbSet<Department> departments { get; set; }
        DbSet<Position> positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-35VIVUJ;Initial Catalog=NamneDb05;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
