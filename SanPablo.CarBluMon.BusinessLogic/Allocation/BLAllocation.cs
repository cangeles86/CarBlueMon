using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Allocation;

namespace SanPablo.CarBluMon.BusinessLogic.Allocation
{
    public class BLAllocation: IRepositoryManager<BEAllocation>
    {
        public bool Register(BEAllocation entity)
        {
            return new DAAllocation().Register(entity);
        }

        public bool Modify(BEAllocation entity)
        {
            return new DAAllocation().Modify(entity);
        }

        public bool Remove(BEAllocation entity)
        {
            return new DAAllocation().Remove(entity);
        }

        public BEAllocation FindById(int code)
        {
            return new DAAllocation().FindById(code);
        }

        public System.Collections.Generic.List<BEAllocation> Find(BEAllocation entity)
        {
            return new DAAllocation().Find(entity);
        }
    }
}
