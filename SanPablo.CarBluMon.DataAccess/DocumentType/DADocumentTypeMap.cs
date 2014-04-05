using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.DocumentType
{
    public class DADocumentTypeMap: ClassMapping<BEDocumentType>
    {
        public DADocumentTypeMap()
        {
            Table("DocumentType");
            Id(i => i.Id, m => { m.Column("id"); m.Generator(Generators.Identity); });
            Property(i => i.Description, m => { m.Column("description"); });
        }
    }
}
