using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEHelpRequest
    {
        [DataMember(IsRequired=false)]
        public Int64 Id { get; set; }
        [DataMember]
        public DateTime RegisterDate { get; set; }
        [DataMember]
        public BEUser User { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public bool State { get; set; }
    }
}
