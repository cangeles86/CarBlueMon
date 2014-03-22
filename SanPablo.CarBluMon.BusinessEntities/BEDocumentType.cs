using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
