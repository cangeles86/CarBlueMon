using SanPablo.CarBluMon.BusinessEntities;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SanPablo.CarBluMon.Services.PhoneDirectory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhoneDirectory" in both code and config file together.
    [ServiceContract]
    public interface IPhoneDirectory
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Phones", ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        List<BEPhoneDirectory> AllPhones();
    }
}
