using SanPablo.CarBluMon.BusinessLogic.ECGHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.ECGHistory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ECGHistory" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ECGHistory.svc or ECGHistory.svc.cs at the Solution Explorer and start debugging.
    public class ECGHistory : IECGHistory
    {
        public bool SendECG(BusinessEntities.BEECGHistory entity)
        {
            BLECGHistory blECG = new BLECGHistory();
            entity.RegisterDate = DateTime.Now;
            bool result = blECG.Register(entity);
            return result;
        }
    }
}
