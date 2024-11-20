using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Core.Data
{
    public class Employee
    {
            public int EmployeeId { get; set; }
            public string EmployeeCode { get; set; }
            public string EmployeeName { get; set; }
            public string Gender { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public int PositionId { get; set; }
            public int DepartmentId { get; set; }
            public DateTime CreatedAt { get; set; } 
            public string CreatedBy { get; set; }
            public bool Active { get; set; } = true;

            public Position Position { get; set; }
            public Department Department { get; set; }
    }
}
