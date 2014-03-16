using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.HelpRequests
{
    public class DAHelpRequestMap: ClassMapping<BEHelpRequest>
    {
        public DAHelpRequestMap()
        {
            Table("HelpRequests");
            Id(i => i.Id, m => { m.Column(""); m.Generator(Generators.Identity); });
            Property(i => i.RegisterDate, m => { m.Column("registerDate"); });
            Property(i => i.Latitude, m => { m.Column("latitude"); });
            Property(i => i.Longitude, m => { m.Column("longitude"); });
            Property(i => i.State, m => { m.Column("state"); });
            ManyToOne(i => i.User, m => { m.Column("userId"); });

        }
    }
}
