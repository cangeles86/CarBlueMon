using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.RegistrationModule.Patient
{
    public partial class PatientList : System.Web.UI.Page
    {
        private BLPatient logic = new BLPatient();

        private void FindEntity()
        {
            dgPatient.DataSource = logic.Find(null);
            dgPatient.DataBind();
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
            logic.Remove(new BEPatient() { Id = code });
            FindEntity();
        }
    }
}