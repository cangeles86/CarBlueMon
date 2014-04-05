using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Medicine;

namespace SanPablo.CarBluMon.BusinessLogic.Medicine
{
    public class BLMedicine: IRepositoryManager<BEMedicine>
    {
        public bool Register(BEMedicine entity)
        {
            return new DAMedicine().Register(entity);
        }

        public bool Modify(BEMedicine entity)
        {
            return new DAMedicine().Modify(entity);
        }

        public bool Remove(int code)
        {
            return new DAMedicine().Remove(code);
        }

        public BEMedicine FindById(int code)
        {
            return new DAMedicine().FindById(code);
        }

        public System.Collections.Generic.List<BEMedicine> Find(BEMedicine entity)
        {
             return new DAMedicine().Find(entity);
        }
        public BEMedicine GetMedicineByUser(int code)
        {
            return new DAMedicine().GetMedicineByUser(code);
        }
        
    }
}
