using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.RegistrationModule.Equipment
{
    public partial class EquipmentList : System.Web.UI.Page
    {
        private BLEquipment logic = new BLEquipment();
        
        private void FindEntity()
        {
            DgEquipment.DataSource = logic.Find(null);
            DgEquipment.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FindEntity();
            }
        }

        protected void jlink_Click(object sender, EventArgs e)
        {
            LinkButton item = (LinkButton)sender;
            int code = int.Parse(item.CommandArgument);
            logic.Remove(new BEEquipment() { Id=code});
            FindEntity();
        }
    }
}