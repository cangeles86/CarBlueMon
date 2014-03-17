using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.HelpRequests;

namespace SanPablo.CarBluMon.Test.Data.HelpResquests
{
    [TestClass]
    public class UTHelpRequest
    {
        [TestMethod]
        public void Operation()
        {
            BEHelpRequest entity = new BEHelpRequest();
            DAHelpRequest da = new DAHelpRequest();
            //Insertar
            entity.User = new BEUser();
            entity.User.Id = 1;
            entity.Latitude = 0;
            entity.Longitude = 0;
            entity.RegisterDate = DateTime.Now;
            entity.State = true;
            var result = da.Register(entity);
            Assert.AreEqual(true, (bool)result);
        }
    }
}
