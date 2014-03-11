using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPablo.CarBluMon.BusinessEntities
{
    public class BELocation
    {
        public virtual Int64 Id { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string Longitude { get; set; }
    }
}
