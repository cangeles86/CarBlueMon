using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
    }
}
