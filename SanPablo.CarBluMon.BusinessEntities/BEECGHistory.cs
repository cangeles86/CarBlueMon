using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEECGHistory
    {
        [DataMember(IsRequired=false)]
        public virtual int Id { get; set; }
        [DataMember(IsRequired = false)]
        public virtual BEUser User { get; set; }
        [DataMember(IsRequired = false)]
        public virtual DateTime RegisterDate { get; set; }
        [DataMember(IsRequired = false)]
        public virtual double Marker { get; set; }
    }
}
