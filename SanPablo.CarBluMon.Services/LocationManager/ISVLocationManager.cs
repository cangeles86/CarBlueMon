using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.LocationManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISVLocationManager" in both code and config file together.
    [ServiceContract]
    public interface ISVLocationManager
    {
        [OperationContract]
        bool RegisterLocation (double Latitude, double Longitud);
    }
}
