using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Patient;

namespace SanPablo.CarBluMon.BusinessLogic.Patient
{
    public class BLPatient:IRepositoryManager<BEPatient>
    {
        public bool Register(BEPatient entity)
        {
            return new DAPatient().Register(entity);
        }

        public bool Modify(BEPatient entity)
        {
            return new DAPatient().Modify(entity);
        }

        public bool Remove(BEPatient entity)
        {
            return new DAPatient().Remove(entity);
        }

        public BEPatient FindById(int code)
        {
            return new DAPatient().FindById(code);
        }

        public System.Collections.Generic.List<BEPatient> Find(params string[][] criteriaListEq)
        {
            return new DAPatient().Find(criteriaListEq);
        }
    }
}
