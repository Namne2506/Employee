using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Core.Data
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            builder.HasOne(p => p.Position).WithMany(e => e.Employees).HasForeignKey(e => e.PositionId);
            builder.HasOne(p => p.Department).WithMany(e => e.Employees).HasForeignKey(e => e.DepartmentId);

        }
    }
}
    