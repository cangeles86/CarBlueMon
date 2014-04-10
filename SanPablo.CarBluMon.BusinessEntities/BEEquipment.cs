using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEEquipment
    {
        [DataMember(IsRequired = false)]
        public virtual int Id { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string SerialNumber { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Description { get; set; }

        [DataMember(IsRequired = false)]
        public virtual BEEquipmentType Type { get; set; }

        [DataMember(IsRequired = false)]
        public virtual DateTime RegisterDate { get; set; }

        [DataMember(IsRequired = false)]
        public virtual bool Assign { get; set; }

        [DataMember(IsRequired = false)]
        public virtual bool State { get; set; }

    }
}
