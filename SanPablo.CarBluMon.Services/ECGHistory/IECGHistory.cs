using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SanPablo.CarBluMon.Services.ECGHistory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IECGHistory" in both code and config file together.
    [ServiceContract]
    public interface IECGHistory
    {
        [OperationContract]
        [WebInvoke(Method="POST", ResponseFormat=WebMessageFormat.Json, UriTemplate="ECGHistories")]
        bool SendECG(BEECGHistory entity);
        
    }
}
