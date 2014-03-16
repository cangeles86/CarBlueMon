﻿using System;
using System.Runtime.Serialization;

namespace SanPablo.CarBluMon.BusinessEntities
{
    [DataContract]
    public class BEUser
    {
        [DataMember(IsRequired=false)]
        public virtual Int64 Id { get; set; }

        [DataMember]
        public virtual string User { get; set; }

        [DataMember]
        public virtual string Name_Profile { get; set; }               
    }
}