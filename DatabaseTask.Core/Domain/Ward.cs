using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        public Guid Id { get; set; }
        public int WardRoomNumber { get; set; }
        public int WardBedAmount { get; set; }
    }
}
