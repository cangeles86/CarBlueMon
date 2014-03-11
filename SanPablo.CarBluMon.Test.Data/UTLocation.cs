using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Location;

namespace SanPablo.CarBluMon.Test.Data
{
    [TestClass]
    public class UTLocation
    {
        [TestMethod]
        public void RegisterLocation()
        {
            BELocation entity = new BELocation();
            entity.Latitude = 1.222;
            entity.Longitude = 1.00;
            DALocation daEntiy = new DALocation();
            bool result = daEntiy.Register(entity);
            Assert.AreEqual(true, result);
        }
    }
}
