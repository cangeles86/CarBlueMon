using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEPhoneDirectory
    {
        [DataMember(IsRequired=false)]
        public Int32 Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string State { get; set; }
    }
}
