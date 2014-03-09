using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.LocationManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SVLocationManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SVLocationManager.svc or SVLocationManager.svc.cs at the Solution Explorer and start debugging.
    public class SVLocationManager : ISVLocationManager
    {

        public bool RegisterLocation(double Latitude, double Longitud)
        {
            throw new NotImplementedException();
        }
    }
}
