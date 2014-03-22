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
        public virtual int Id { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Name { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string LastName { get; set; }
        [DataMember(IsRequired = false)]
        public virtual BEDocumentType DocumentType { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string DocumentNumber { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Address { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Email { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string HomePhone { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Mobile { get; set; }
        [DataMember(IsRequired = false)]
        public virtual DateTime RegisterDate { get; set; }
        [DataMember(IsRequired = false)]
        public virtual bool State { get; set; }
    }
}
