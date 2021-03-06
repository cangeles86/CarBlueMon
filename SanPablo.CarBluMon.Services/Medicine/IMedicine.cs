﻿using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SanPablo.CarBluMon.Services.Medicine
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMedicine" in both code and config file together.
    [ServiceContract]
    public interface IMedicine
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Medicines/{code}", ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        BEMedicine GetMedicine(string code);
    }
}
