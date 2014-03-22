using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEPatient
    {
        [DataMember (IsRequired=false)]
        public int Id { get; set; }
        [DataMember(IsRequired = false)]
        public string Name { get; set; }
        [DataMember(IsRequired = false)]
        public string LastName { get; set; }
        [DataMember(IsRequired = false)]
        public BEDocumentType DocumentType { get; set; }
        [DataMember(IsRequired = false)]
        public string DocumentNumber { get; set; }
        [DataMember(IsRequired = false)]
        public string Address { get; set; }
        [DataMember(IsRequired = false)]
        public string Email { get; set; }
        [DataMember(IsRequired = false)]
        public string HomePhone { get; set; }
        [DataMember(IsRequired = false)]
        public string Mobile { get; set; }
        [DataMember(IsRequired = false)]
        public DateTime RegisterDate { get; set; }
        [DataMember(IsRequired = false)]
        public bool State { get; set; }
    }
}
