using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Location
{
    public class DALocationMap: ClassMapping<BELocation>
    {
        public DALocationMap()
        {
            Table("Location");
            Id(x => x.Id, 
                      map => 
                           {
                               map.Generator(NHibernate.Mapping.ByCode.Generators.Identity);
                               map.Column("id");
                           }
                     );
            Property(x => x.Latitude,
                             map =>
                                 {
                                     map.Column("latitude");                                     
                                 }
                            );
            Property(x => x.Longitude,
                             map =>
                                {
                                    map.Column("longitude");
                                }
                            );
        }
    }
}

