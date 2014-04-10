using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Users;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.BusinessLogic.Users
{
    public class BLUser:IRepositoryManager<BEUser>
    {
        public bool Register(BEUser entity)
        {
            return new DAUser().Register(entity);
        }

        public bool Modify(BEUser entity)
        {
            return new DAUser().Modify(entity);
        }

        public bool Remove(BEUser entity)
        {
            return new DAUser().Remove(entity);
        }

        public BEUser FindById(int code)
        {
            return new DAUser().FindById(code);
        }

        public List<BEUser> Find(params string[][] criteriaListEq)
        {
            return new DAUser().Find(criteriaListEq);
        }
    }
}
