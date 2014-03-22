using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEPhoneDirectory
    {
        [DataMember(IsRequired=false)]
        public virtual int Id { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Description { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string Phone { get; set; }
        [DataMember(IsRequired = false)]
        public virtual string State { get; set; }
    }
}
