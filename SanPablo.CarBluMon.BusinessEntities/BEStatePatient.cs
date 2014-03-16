using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEStatePatient
    {
        [DataMember(IsRequired=false)]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Description { get; set; }
    }
}
