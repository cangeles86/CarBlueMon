﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SanPablo.CarBluMon.Services.Users
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select User.svc or User.svc.cs at the Solution Explorer and start debugging.
    public class User : IUser
    {

        public bool Register(BusinessEntities.BEUser entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(BusinessEntities.BEUser entity)
        {
            throw new NotImplementedException();
        }

        public BusinessEntities.BEUser GetUserById(BusinessEntities.BEUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
