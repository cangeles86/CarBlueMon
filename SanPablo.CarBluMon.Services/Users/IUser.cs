using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SanPablo.CarBluMon.Services.Users
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUser" in both code and config file together.
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Register(BEUser entity);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        bool Edit(BEUser entity);

        [OperationContract]
        [WebInvoke(UriTemplate="Users/{id}", ResponseFormat=WebMessageFormat.Json, Method="GET")]
        BEUser GetUserById (BEUser entity);

    }
}
