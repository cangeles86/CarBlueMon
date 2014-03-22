using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.PhoneDirectory
{
    public class DAPhoneDirectoryMap: ClassMapping<BEPhoneDirectory>
    {
        public DAPhoneDirectoryMap()
        {
            Table("PhoneDirectory");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            Property(i => i.Description, m => { m.Column("description"); });
            Property(i => i.Phone, m => { m.Column("phone"); });
            Property(i => i.State, m => { m.Column("state"); });
        }
    }
}
