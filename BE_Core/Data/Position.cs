using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Core.Data
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public bool Active { get; set; } = true;

        public ICollection<Employee> Employees { get; set; }
    }
}
