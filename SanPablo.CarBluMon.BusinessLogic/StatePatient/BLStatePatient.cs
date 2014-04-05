using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.StatePatient;

namespace SanPablo.CarBluMon.BusinessLogic.StatePatient
{
    public class BLStatePatient : IRepositoryManager<BEStatePatient>
    {
        public bool Register(BEStatePatient entity)
        {
            return new DAStatePatient().Register(entity);
        }

        public bool Modify(BEStatePatient entity)
        {
            return new DAStatePatient().Modify(entity);
        }

        public bool Remove(int code)
        {
            return new DAStatePatient().Remove(code);
        }

        public BEStatePatient FindById(int code)
        {
            return new DAStatePatient().FindById(code);
        }

        public System.Collections.Generic.List<BEStatePatient> Find(BEStatePatient entity)
        {
            return new DAStatePatient().Find(entity);
        }
    }
}
