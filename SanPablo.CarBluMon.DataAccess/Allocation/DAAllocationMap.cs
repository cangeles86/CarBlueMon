using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Allocation
{
    public class DAAllocationMap: ClassMapping<BEAllocation>
    {
        public DAAllocationMap()
        {
            Table("Allocation");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            ManyToOne(i => i.Patient, m => { m.Column("patientId"); });
            ManyToOne(i => i.Equipment, m => { m.Column("equipmentId"); });
            Property(i => i.State, m => { m.Column("state"); });
        }
    }
}
