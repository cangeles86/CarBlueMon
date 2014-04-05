using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEDoctor
    {
        [DataMember(IsRequired = false)]
        public virtual int Id { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Name { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string LastName { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Specialty { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string Email { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string PhonePrimary { get; set; }

        [DataMember(IsRequired = false)]
        public virtual string PhoneSecundary { get; set; }
    }
}
