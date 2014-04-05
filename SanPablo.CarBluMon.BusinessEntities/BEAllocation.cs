using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEAllocation
    {
        [DataMember(IsRequired = false)]
        public virtual int Id { get; set; }

        [DataMember(IsRequired = false)]
        public virtual BEPatient Patient { get; set; }

        [DataMember(IsRequired = false)]
        public virtual BEEquipment Equipment { get; set; }

        [DataMember(IsRequired = false)]
        public virtual bool State { get; set; }
    }
}
