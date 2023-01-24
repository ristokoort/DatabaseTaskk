using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public int TelephoneNumber { get; set;}
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PatientPresence { get; set; }

    }
}
