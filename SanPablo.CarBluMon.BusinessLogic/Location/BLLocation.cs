using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Location;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;

namespace SanPablo.CarBluMon.BusinessLogic.Location
{
    public class BLLocation : IRepositoryManager<BELocation>
    {

        public bool Register(BELocation entity)
        {
            return new DALocation().Register(entity);
        }

        public bool Modify(BELocation entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int code)
        {
            throw new System.NotImplementedException();
        }

        public BELocation FindById(int code)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<BELocation> Find(BELocation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
