using System;
using System.Runtime.Serialization;


namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BELocation
    {
        [DataMember (IsRequired=false)]
        public virtual Int64 Id { get; set; }
        [DataMember]
        public virtual double Latitude { get; set; }
        [DataMember]
        public virtual double Longitude { get; set; }
    }
}
