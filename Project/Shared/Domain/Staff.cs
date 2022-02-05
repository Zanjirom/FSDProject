using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Position { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }

    }
}
