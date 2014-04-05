using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.HelpRequests;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.BusinessLogic.HelpRequests
{
    public class BLHelpRequest:IRepositoryManager<BEHelpRequest>
    {

        public bool Register(BEHelpRequest entity)
        {
            return new DAHelpRequest().Register(entity);
        }

        public bool Modify(BEHelpRequest entity)
        {
            return new DAHelpRequest().Modify(entity);
        }

        public bool Remove(BEHelpRequest entity)
        {
            return new DAHelpRequest().Remove(entity);
        }

        public BEHelpRequest FindById(int code)
        {
            return new DAHelpRequest().FindById(code);
        }

        public List<BEHelpRequest> Find(BEHelpRequest entity)
        {
            return new DAHelpRequest().Find(entity);
        }
    }
}
