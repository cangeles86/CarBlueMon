using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Users
{
    public class DAUserMap : ClassMapping<BEUser>
    {
        public DAUserMap()
        {
            Table("Users");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            Property(i => i.User, m => { m.Column("user_fbk");});
            Property(i => i.Name_Profile, m => { m.Column("name_profile"); });
        }
    }
}
