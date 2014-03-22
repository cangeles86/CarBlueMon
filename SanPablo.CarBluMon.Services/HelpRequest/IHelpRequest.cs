using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SanPablo.CarBluMon.Services.HelpRequests
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelpRequest" in both code and config file together.
    [ServiceContract]
    public interface IHelpRequest
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "HelpRequests", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool SendHelpRequest(BEHelpRequest entity);
    }
}
