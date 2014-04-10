using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Equipment;
using SanPablo.CarBluMon.BusinessLogic.EquipmentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.RegistrationModule.Equipment
{
    public partial class EquipmentSave : System.Web.UI.Page
    {
        private BLEquipment logic = new BLEquipment();
        private BEEquipment entity = new BEEquipment();
        private BLEquipmentType type = new BLEquipmentType();
        private BEEquipmentType eType = new BEEquipmentType();
        private string ope = null;

        private void LoadEquipmentType()
        {
            List<BEEquipmentType> typeList = type.Find(null);
            ddlEquipmentType.DataSource = typeList;
            ddlEquipmentType.DataValueField = "id";
            ddlEquipmentType.DataTextField = "description";
            ddlEquipmentType.DataBind();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                LoadEquipmentType();
                ope = Request.QueryString["ope"].ToString();
                if (ope == "edit")
                {
                    int code = int.Parse(Request.QueryString["code"].ToString());
                    entity = logic.FindById(code);
                    SetEntity(entity);
                }
            }
        }

        private BEEquipment GetEntity()
        {
            entity = new BEEquipment();
            entity.SerialNumber = txtSerialNumber.Text;
            entity.Description = txtDescription.Text;
            entity.State = true;
            if (ope =="new")
            {
                entity.RegisterDate = DateTime.Now;
                entity.Assign = false;
            }
            else
            {
                entity.RegisterDate = DateTime.Parse(lblRegisterDate.Text);
                entity.Assign = bool.Parse(lblAssign.Text);
            }
            entity.Type = new BEEquipmentType();
            entity.Type.Id = int.Parse(ddlEquipmentType.SelectedValue);
            if (ddlState.SelectedValue =="1")
            {                
                entity.State = true;
            }
            else
            {
                entity.State = false;
            }                     
            return entity;
        }

        private void SetEntity(BEEquipment entity)
        {
            txtSerialNumber.Text = entity.SerialNumber;
            txtDescription.Text = entity.Description;
            ddlEquipmentType.SelectedValue = entity.Type.Id.ToString();
            if (entity.State)
            {
                ddlState.SelectedValue = "1";
            }
            else
            {
                ddlState.SelectedValue = "0";
            }
            lblAssign.Text = entity.Assign.ToString();
            lblRegisterDate.Text = entity.RegisterDate.ToString();
            
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/RegistrationModule/Equipment/EquipmentList.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            ope = Request.QueryString["ope"].ToString();
            if (ope == "new")
            {
                bool result = logic.Register( GetEntity());
                
                if (result)
                {
                    Response.Redirect("/RegistrationModule/Equipment/EquipmentList.aspx");
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
                    Response.Redirect("/RegistrationModule/Equipment/EquipmentList.aspx");
                }
                else
                {
                    //Mostrar un mensaje
                }
            }
        }
    }
}