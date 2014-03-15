using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SanPablo.CarBluMon.Services.LocationManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISVLocationManager" in both code and config file together.
    [ServiceContract]
    public interface ISVLocationManager
    {
        //sustantivo plural
        [OperationContract]
        [WebInvoke(UriTemplate = "Location/", Method="GET")]
        List<BELocation> GetLocations();

        //[OperationContract]
        //[WebInvoke(UriTemplate = "Location/{latitude}/{longitude}", Method = "POST")]
        //bool RegisterLocation(string latitude, string longitude);

        [OperationContract]
        [WebInvoke(UriTemplate = "Location/", Method = "POST", ResponseFormat=WebMessageFormat.Json)]
        bool RegisterLocation(BELocation entity);

    }
}
