using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEMedicine
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public BEUser User { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public BEDoctor Doctor { get; set; }

    }
}
