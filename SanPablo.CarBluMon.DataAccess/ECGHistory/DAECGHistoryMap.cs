using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.ECGHistory
{
    public class DAECGHistoryMap: ClassMapping<BEECGHistory>
    {
        public DAECGHistoryMap()
        {

            Table("ECGHistory");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            ManyToOne(i => i.User, m => { m.Column("userId"); });
            Property(i => i.Marker, m => { m.Column("marker"); });
            Property(i => i.RegisterDate, m => { m.Column("registerDate"); });

        }
    }
}
