using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.Medicine
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Medicine" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Medicine.svc or Medicine.svc.cs at the Solution Explorer and start debugging.
    public class Medicine : IMedicine
    {
        public BusinessEntities.BEMedicine GetMedicine(int code)
        {
            BEMedicine result = new BEMedicine();
            BLMedicine blEntity = new BLMedicine();
            result = blEntity.FindById(code);
            return result;
        }
    }
}
