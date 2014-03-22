
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Medicine;
namespace SanPablo.CarBluMon.BusinessLogic.Medicine
{
    public class BLMedicine: IRepositoryManager<BEMedicine>
    {
        public bool Register(BEMedicine entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Modify(BEMedicine entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int code)
        {
            throw new System.NotImplementedException();
        }

        public BEMedicine FindById(int code)
        {
            throw new System.NotImplementedException();
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
