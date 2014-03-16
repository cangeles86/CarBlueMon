using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPablo.CarBluMon.BusinessLogic.HelpRequests
{
    public class BLHelpRequest:IRepositoryManager<BEHelpRequest>
    {

        public bool Register(BEHelpRequest entity)
        {
            return new BLHelpRequest().Register(entity);
        }

        public bool Modify(BEHelpRequest entity)
        {
            return new BLHelpRequest().Modify(entity);
        }

        public bool Remove(int code)
        {
            return new BLHelpRequest().Remove(code);
        }

        public BEHelpRequest FindById(int code)
        {
            return new BLHelpRequest().FindById(code);
        }

        public List<BEHelpRequest> Find(BEHelpRequest entity)
        {
            return new BLHelpRequest().Find(entity);
        }
    }
}
