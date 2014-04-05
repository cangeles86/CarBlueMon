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

        public bool Remove(int code)
        {
            return new DAPatient().Remove(code);
        }

        public BEPatient FindById(int code)
        {
            return new DAPatient().FindById(code);
        }

        public System.Collections.Generic.List<BEPatient> Find(BEPatient entity)
        {
            return new DAPatient().Find(entity);
        }
    }
}
