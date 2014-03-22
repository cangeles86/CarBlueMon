using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEECGHistory
    {
        [DataMember(IsRequired=false)]
        public int Id { get; set; }
        [DataMember(IsRequired = false)]
        public BEUser User { get; set; }
        [DataMember(IsRequired = false)]
        public string RegisterDate { get; set; }
        [DataMember(IsRequired = false)]
        public double Marker { get; set; }
    }
}
