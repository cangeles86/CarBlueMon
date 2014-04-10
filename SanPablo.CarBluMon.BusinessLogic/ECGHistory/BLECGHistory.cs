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

        public bool Remove(BEECGHistory entity)
        {
            return new DAECGHistory().Remove(entity);
        }

        public BEECGHistory FindById(int code)
        {
            return new DAECGHistory().FindById(code);
        }

        public System.Collections.Generic.List<BEECGHistory> Find(params string[][] criteriaListEq)
        {
            return new DAECGHistory().Find(criteriaListEq);
        }
    }
}
