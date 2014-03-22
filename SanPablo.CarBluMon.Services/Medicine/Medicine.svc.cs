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

        public BusinessEntities.BEMedicine GetMedicine(string code)
        {
            BLMedicine blMedicine = new BLMedicine();
            BusinessEntities.BEMedicine result = new BEMedicine();
            result = blMedicine.GetMedicineByUser(int.Parse(code));
            return new BEMedicine() { Id = result.Id, Description = result.Description, User= new BEUser(){Id = result.User.Id}, Doctor= new BEDoctor(){Id = result.Doctor.Id}};
        }
    }
}
