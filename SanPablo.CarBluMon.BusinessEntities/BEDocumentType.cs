using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEDocumentType
    {
        [DataMember(IsRequired=false)]
        public int Id { get; set; }

        [DataMember(IsRequired = false)]
        public string Description { get; set; }

    }
}
