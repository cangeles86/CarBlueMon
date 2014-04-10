using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Equipment;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.Test.BusinessLogic.Equipment
{
    [TestClass]
    public class UTEquipment
    {
        [TestMethod]
        public void Operations()
        {
            //Definción de variables
            //BEEquipment entity = new BEEquipment();
            BLEquipment logic = new BLEquipment();
            //bool result;

            //Insertar valores
            //entity.SerialNumber = "NG20130104";
            //entity.Description = "Nokia 900";
            //entity.Type = new BEEquipmentType();
            //entity.Type.Id = 2;
            //entity.RegisterDate = DateTime.Now;
            //entity.State = true;
            //result = logic.Register(entity);
            //Assert.AreEqual(true, result);

            //Modificar valores
            //entity = logic.FindById(5);
            //entity.Description = "Nokia 900 - 201403";
            //result = logic.Modify(entity);
            //Assert.AreEqual(true, result);

            //Eliminar valores
            //entity.Id = 5;
            //result = logic.Remove(entity);
            //Assert.AreEqual(true, result);

            List<BEEquipment> entityList = logic.Find(new string[] { "Eq|Ns", "Description", "Holter", "Type" });
            Assert.AreEqual(1, entityList.Count);
            //Assert.AreEqual(true, true);

        }
    }
}
