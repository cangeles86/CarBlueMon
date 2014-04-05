using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEMedicine
    {
        [DataMember(IsRequired=false)]
        public virtual int Id { get; set; }

        [DataMember(IsRequired = false)]
        public virtual BEUser User { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Description { get; set; }

        [DataMember(IsRequired = false)]
        public virtual BEDoctor Doctor {get; set; }

    }
}
