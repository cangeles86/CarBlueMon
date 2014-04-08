using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.DocumentType;
using SanPablo.CarBluMon.BusinessLogic.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.RegistrationModule.Patient
{
    public partial class PatientSave : System.Web.UI.Page
    {
        private BLPatient logic = new BLPatient();
        private BEPatient entity = new BEPatient();
        private BLDocumentType type = new BLDocumentType();
        private BEDocumentType eType = new BEDocumentType();
        private string ope = null;

        private void LoadDocumentType()
        {
            List<BEDocumentType> typeList = type.Find(null);
            ddlDocumentType.DataSource = typeList;
            ddlDocumentType.DataValueField = "id";
            ddlDocumentType.DataTextField = "description";
            ddlDocumentType.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDocumentType();
                ope = Request.QueryString["ope"].ToString();
                if (ope == "edit")
                {
                    int code = int.Parse(Request.QueryString["code"].ToString());
                    entity = logic.FindById(code);
                    SetEntity(entity);
                }
            }
        }
        private BEPatient GetEntity()
        {
            entity = new BEPatient();
            entity.Name = txtName.Text;
            entity.LastName = txtLastName.Text;
            entity.State = true;
            entity.RegisterDate = DateTime.Now;
            entity.DocumentType = new BEDocumentType();
            entity.DocumentType.Id = int.Parse(ddlDocumentType.SelectedValue);
            entity.DocumentNumber = txtDocumentNumber.Text;
            entity.Address = txtAddress.Text;
            entity.Email = txtEmail.Text;
            entity.HomePhone = txtHomePhone.Text;
            entity.Mobile = txtMobile.Text;
            return entity;
        }
        private void SetEntity(BEPatient entity)
        {
            txtName.Text = entity.Name;
            txtLastName.Text = entity.LastName;
            ddlDocumentType.SelectedValue = entity.DocumentType.Id.ToString();
            txtAddress.Text = entity.Address;
            txtDocumentNumber.Text = entity.DocumentNumber;
            txtEmail.Text = entity.Email;
            txtHomePhone.Text = entity.HomePhone;
            txtMobile.Text = entity.Mobile;            
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/RegistrationModule/Patient/PatientList.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            ope = Request.QueryString["ope"].ToString();
            if (ope == "new")
            {
                bool result = logic.Register(GetEntity());

                if (result)
                {
                    Response.Redirect("/RegistrationModule/Patient/PatientList.aspx");
                }
                else
                {
                    //Mostrar un mensaje
                }
            }
            else if (ope == "edit")
            {
                int id = int.Parse(Request.QueryString["code"].ToString());
                entity = GetEntity();
                entity.Id = id;
                bool result = logic.Modify(entity);
                if (result)
                {
                    Response.Redirect("/RegistrationModule/Patient/PatientList.aspx");
                }
                else
                {
                    //Mostrar un mensaje
                }
            }
        }
    }
}