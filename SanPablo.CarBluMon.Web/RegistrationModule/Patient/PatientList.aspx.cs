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
        private string[] criterioActivo = new string[] { "Activo", "State" };

        private void FindEntity()
        {
            dgPatient.DataSource = logic.Find(criterioActivo);
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

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string[] criteriaName = null;
            string[] criteriaLastName = null;
            if (txtName.Text.Trim() != string.Empty)
            {
                criteriaName = new string[] { "Lk", "Name", txtName.Text };
            }
            if (txtLastName.Text.Trim() != string.Empty)
            {
                criteriaLastName = new string[] { "Lk", "LastName", txtLastName.Text };
            }
            dgPatient.DataSource = logic.Find(criterioActivo, criteriaName, criteriaLastName);
            dgPatient.DataBind();
        }
    }
}