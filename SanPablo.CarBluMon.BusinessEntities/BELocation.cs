using System;

namespace SanPablo.CarBluMon.BusinessEntities
{
    public class BELocation
    {
        public virtual Int64 Id { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string Longitude { get; set; }
    }
}
