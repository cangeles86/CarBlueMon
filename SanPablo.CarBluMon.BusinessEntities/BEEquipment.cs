using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPablo.CarBluMon.BusinessEntities
{
    public class BEEquipment
    {
        public virtual int Id { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string Description { get; set; }
        public BEEquipmentType Type { get; set; }
        public virtual DateTime RegisterDate { get; set; }
        public virtual bool State { get; set; }

    }
}
