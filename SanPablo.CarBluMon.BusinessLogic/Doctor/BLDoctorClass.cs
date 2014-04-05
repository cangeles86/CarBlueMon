using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Doctor;

namespace SanPablo.CarBluMon.BusinessLogic.Doctor
{
    public class BLDoctorClass : IRepositoryManager<BEDoctor>
    {
        public bool Register(BEDoctor entity)
        {
            return new DADoctor().Register(entity);
        }

        public bool Modify(BEDoctor entity)
        {
            return new DADoctor().Modify(entity);
        }

        public bool Remove(BEDoctor entity)
        {
            return new DADoctor().Remove(entity);
        }

        public BEDoctor FindById(int code)
        {
            return new DADoctor().FindById(code);
        }

        public System.Collections.Generic.List<BEDoctor> Find(BEDoctor entity)
        {
            return new DADoctor().Find(entity);
        }
    }
}
