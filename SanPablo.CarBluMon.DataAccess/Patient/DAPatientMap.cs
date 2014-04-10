using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Patient
{
    public class DAPatientMap: ClassMapping<BEPatient>
    {
        public DAPatientMap()
        {
            Table("Patient");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            Property(i => i.Name, m => { m.Column("name"); });
            Property(i => i.LastName, m => { m.Column("lastName"); });
            ManyToOne(i => i.DocumentType, m => { m.Column("documentTypeId"); });
            Property(i => i.DocumentNumber, m => { m.Column("documentNumber"); });
            Property(i => i.Address, m => { m.Column("address"); });
            Property(i => i.Email, m => { m.Column("email"); });
            Property(i => i.HomePhone, m => { m.Column("homePhone"); });
            Property(i => i.Mobile, m => { m.Column("mobile"); });
            Property(i => i.RegisterDate, m => { m.Column("registerDate"); });
            Property(i => i.State, m => { m.Column("state"); m.Type(NHibernateUtil.Boolean); });
        }
    }
}
