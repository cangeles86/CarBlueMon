using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Equipment;

namespace SanPablo.CarBluMon.BusinessLogic.Equipment
{
    public class BLEquipment: IRepositoryManager<BEEquipment>
    {
        public bool Register(BEEquipment entity)
        {
            return new DAEquipment().Register(entity);
        }

        public bool Modify(BEEquipment entity)
        {
            return new DAEquipment().Modify(entity);
        }

        public bool Remove(BEEquipment entity)
        {
            return new DAEquipment().Remove(entity);
        }

        public BEEquipment FindById(int code)
        {
            return new DAEquipment().FindById(code);
        }

        public System.Collections.Generic.List<BEEquipment> Find(BEEquipment entity)
        {
            return new DAEquipment().Find(entity);
        }
    }
}
