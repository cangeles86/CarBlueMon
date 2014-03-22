using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.HelpRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.HelpRequests
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelpRequest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelpRequest.svc or HelpRequest.svc.cs at the Solution Explorer and start debugging.
    public class HelpRequest : IHelpRequest
    {
        public bool SendHelpRequest(BusinessEntities.BEHelpRequest entity)
        {
            BLHelpRequest blHelpRequest = new BLHelpRequest();
            entity.RegisterDate = DateTime.Now;
            bool result = blHelpRequest.Register(entity);
            return result;
        }
    }
}
