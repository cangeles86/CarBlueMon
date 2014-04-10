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

        public bool Remove(BEStatePatient entity)
        {
            return new DAStatePatient().Remove(entity);
        }

        public BEStatePatient FindById(int code)
        {
            return new DAStatePatient().FindById(code);
        }

        public System.Collections.Generic.List<BEStatePatient> Find(params string[][] criteriaListEq)
        {
            return new DAStatePatient().Find(criteriaListEq);
        }
    }
}
