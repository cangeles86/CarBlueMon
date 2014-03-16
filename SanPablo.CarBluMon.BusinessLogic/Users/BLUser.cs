using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Remove(int code)
        {
            return new DAUser().Remove(code);
        }

        public BEUser FindById(int code)
        {
            return new DAUser().FindById(code);
        }

        public List<BEUser> Find(BEUser entity)
        {
            return new DAUser().Find(entity);
        }
    }
}
