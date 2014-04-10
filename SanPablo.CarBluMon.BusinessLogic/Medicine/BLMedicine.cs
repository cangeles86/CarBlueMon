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

        public bool Remove(BEMedicine entity)
        {
            return new DAMedicine().Remove(entity);
        }

        public BEMedicine FindById(int code)
        {
            return new DAMedicine().FindById(code);
        }

        public System.Collections.Generic.List<BEMedicine> Find(params string[][] criteriaListEq)
        {
             return new DAMedicine().Find(criteriaListEq);
        }
        public BEMedicine GetMedicineByUser(int code)
        {
            return new DAMedicine().GetMedicineByUser(code);
        }
        
    }
}
