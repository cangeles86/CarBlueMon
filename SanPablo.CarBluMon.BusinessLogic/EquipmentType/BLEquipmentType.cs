using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.EquipmentType;

namespace SanPablo.CarBluMon.BusinessLogic.EquipmentType
{
    public class BLEquipmentType: IRepositoryManager<BEEquipmentType>
    {

        public bool Register(BEEquipmentType entity)
        {
            return new DAEquipmentType().Register(entity);
        }

        public bool Modify(BEEquipmentType entity)
        {
            return new DAEquipmentType().Modify(entity);
        }

        public bool Remove(BEEquipmentType entity)
        {
            return new DAEquipmentType().Remove(entity);
        }

        public BEEquipmentType FindById(int code)
        {
            return new DAEquipmentType().FindById(code);
        }

        public System.Collections.Generic.List<BEEquipmentType> Find(BEEquipmentType entity)
        {
            return new DAEquipmentType().Find(entity);
        }
    }
}
