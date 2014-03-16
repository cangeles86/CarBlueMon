using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Users
{
    public class DAUserMap : ClassMapping<BEUser>
    {
        public DAUserMap()
        {
            Table("Users");
            Id(i => i.Id);
        }
    }
}
