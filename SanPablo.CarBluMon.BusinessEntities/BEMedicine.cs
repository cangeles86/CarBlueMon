using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEMedicine
    {
        [DataMember(IsRequired=false)]
        public int Id { get; set; }
        [DataMember(IsRequired = false)]
        public BEUser User { get; set; }
        [DataMember(IsRequired = false)]
        public string Description { get; set; }
        [DataMember(IsRequired = false)]
        public BEDoctor Doctor { get;
            
            set; }

    }
}
