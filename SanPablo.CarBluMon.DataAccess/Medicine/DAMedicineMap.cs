using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Medicine
{
    public class DAMedicineMap: ClassMapping<BEMedicine>
    {
        public DAMedicineMap()
        {
            Table("Medicine");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            ManyToOne(i => i.User, m => { m.Column("userId"); });
            ManyToOne(i => i.Doctor, m => { m.Column("doctorId"); });
            Property(i => i.Description, m => { m.Column("description"); });
        }
        
    }
}
