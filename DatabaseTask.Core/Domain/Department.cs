using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentType { get; set; }

    }
}
