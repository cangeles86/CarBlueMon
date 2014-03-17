using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.PhoneDirectory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhoneDirectory" in both code and config file together.
    [ServiceContract]
    public interface IPhoneDirectory
    {
        [OperationContract]
        void DoWork();
    }
}
