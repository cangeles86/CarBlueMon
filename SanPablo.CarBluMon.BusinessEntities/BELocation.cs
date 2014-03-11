using System;

namespace SanPablo.CarBluMon.BusinessEntities
{
    public class BELocation
    {
        public virtual Int64 Id { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}
