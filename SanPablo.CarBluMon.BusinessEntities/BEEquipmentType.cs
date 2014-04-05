using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEEquipmentType
    {
        [DataMember(IsRequired = false)]
        public virtual int Id { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Description { get; set; }
    }
}
