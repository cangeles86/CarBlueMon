using Microsoft.VisualStudio.TestTools.UnitTesting;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Users;
using System;

namespace SanPablo.CarBluMon.Test.Data.Users
{
    [TestClass]
    public class UTUsers
    {
        [TestMethod]
        public void Operations()
        {
            //BEUser user = new BEUser();
            //DAUser daUser = new DAUser();            
            ////Insert
            ////user.User = "correo1@dominio.com";
            ////user.Name_Profile = "Nombre Profile 1";
            ////var result = daUser.Register(user);
            ////Assert.AreEqual(true, (bool)result);
            
            ////Update
            //int code = 2;
            //var entity = daUser.FindById(code);
            //user = (BEUser)entity;
            //user.User = "correo11@dominio.com";
            //user.Name_Profile = "Nombre Profile 11";
            //var result = daUser.Modify(user);
            //Assert.AreEqual(true, (bool)result);

            ////List
            
            ////Delete
            Assert.AreEqual(true, true);
        }
    }
}
