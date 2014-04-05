﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Equipment
{
    public class DAEquipmentMap: ClassMapping<BEEquipment>
    {
        public DAEquipmentMap()
        {

            Table("Equipment");
            Id(i => i.Id, m => { m.Column("serialNumber"); m.Generator(Generators.Identity); });
            Property(i => i.SerialNumber, m => { m.Column("serialNumber"); });
            Property(i => i.Description, m => { m.Column("description"); });
            ManyToOne(i => i.Type, m => { m.Column("equipmentType"); });
            Property(i => i.RegisterDate, m => { m.Column("registerDate"); });
            Property(i => i.State, m => { m.Column("state"); });

        }
    }
}
