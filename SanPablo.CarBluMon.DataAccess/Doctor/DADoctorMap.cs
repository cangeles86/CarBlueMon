using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Doctor
{
    public class DADoctorMap: ClassMapping<BEDoctor>
    {
        public DADoctorMap()
        {
            Table("Doctor");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            Property(i => i.Name, m => { m.Column("name"); });
            Property(i => i.LastName, m => { m.Column("lastName"); });            
        }
    }
}
