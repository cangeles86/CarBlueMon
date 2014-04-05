using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.ECGHistory;

namespace SanPablo.CarBluMon.BusinessLogic.ECGHistory
{
    public class BLECGHistory : IRepositoryManager<BEECGHistory>
    {
        public bool Register(BEECGHistory entity)
        {
            return new DAECGHistory().Register(entity);
        }

        public bool Modify(BEECGHistory entity)
        {
            return new DAECGHistory().Modify(entity);
        }

        public bool Remove(int code)
        {
            return new DAECGHistory().Remove(code);
        }

        public BEECGHistory FindById(int code)
        {
            return new DAECGHistory().FindById(code);
        }

        public System.Collections.Generic.List<BEECGHistory> Find(BEECGHistory entity)
        {
            return new DAECGHistory().Find(entity);
        }
    }
}
