using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.DocumentType;

namespace SanPablo.CarBluMon.BusinessLogic.DocumentType
{
    public class BLDocumentType : IRepositoryManager<BEDocumentType>
    {

        public bool Register(BEDocumentType entity)
        {
            return new DADocumentType().Register(entity);
        }

        public bool Modify(BEDocumentType entity)
        {
            return new DADocumentType().Modify(entity);
        }

        public bool Remove(int code)
        {
            return new DADocumentType().Remove(code);
        }

        public BEDocumentType FindById(int code)
        {
            return new DADocumentType().FindById(code);
        }

        public System.Collections.Generic.List<BEDocumentType> Find(BEDocumentType entity)
        {
            return new DADocumentType().Find(entity);
        }
    }
}
