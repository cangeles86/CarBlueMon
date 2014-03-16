﻿using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEHelpRequest
    {
        [DataMember(IsRequired=false)]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual DateTime RegisterDate { get; set; }
        [DataMember]
        public virtual BEUser User { get; set; }
        [DataMember]
        public virtual double Latitude { get; set; }
        [DataMember]
        public virtual double Longitude { get; set; }
        [DataMember]
        public virtual bool State { get; set; }
    }
}
