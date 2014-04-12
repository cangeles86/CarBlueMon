using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Allocation;
using SanPablo.CarBluMon.BusinessLogic.DocumentType;
using SanPablo.CarBluMon.BusinessLogic.Equipment;
using SanPablo.CarBluMon.BusinessLogic.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.RegistrationModule.Allocation
{
    public partial class AllocationSave : System.Web.UI.Page
    {
        private BLEquipment logicEquipment = new BLEquipment();
        private BLDocumentType logicDocType = new BLDocumentType();
        private BLPatient logicPatient = new BLPatient();
        private BLAllocation logic = new BLAllocation();
               
        
        private string[] criteriaActive = new string[] { "Activo", "State" };
        private string[] criteriaAssign = new string[] { "Inactivo", "Assign" };
        private string[] criteriaHolter = new string[] { "Eq|Ns", "Description", "Holter", "Type" };
        private string[] criteriaMobile = new string[] { "Eq|Ns", "Description", "Movil", "Type" };

        private void GetDocumentType()
        {
            List<BEDocumentType> documents = logicDocType.Find(null);            
            ddlDocumentType.DataSource = documents;
            ddlDocumentType.DataValueField = "Id";
            ddlDocumentType.DataTextField = "Description";
            ddlDocumentType.DataBind();
        }
        private void GetAllEquipment()
        {
            DgEquipmentHolter.DataSource = logicEquipment.Find(criteriaActive, criteriaAssign, criteriaHolter);
            DgEquipmentHolter.DataBind();
            DgEquipmentMovil.DataSource = logicEquipment.Find(criteriaActive, criteriaAssign, criteriaMobile);
            DgEquipmentMovil.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDocumentType();
                GetAllEquipment();
            }
        }

        protected void btnFindAssign_Click(object sender, EventArgs e)
        {
            string[] criteriaDocType = null;
            string[] criteriaNumDocu = null;
            if (int.Parse(ddlDocumentType.SelectedValue) != 0)
            {
                criteriaDocType = new string[] { "Eq|NsIn", "Id", ddlDocumentType.SelectedValue, "DocumentType" };
            }
            if (txtDocumentNumber.Text.Trim() != string.Empty)
            {
                criteriaNumDocu = new string[] { "Eq", "DocumentNumber", txtDocumentNumber.Text};
            }
            List<BEPatient> item = logicPatient.Find(criteriaActive, criteriaDocType, criteriaNumDocu);

            if (item != null && item.Count() == 1)
            {
                BEPatient patient = item[0];
                Session["Patient"] = patient;
                string[] criteriaPatient = new string[] { "Eq|NsIn", "Id", patient.Id.ToString(), "Patient" };
                string mensaje;
                List<BEAllocation> allocation = logic.Find(criteriaActive, criteriaPatient);

                if (allocation == null || allocation.Count()== 0)
                {
                    Session["ope"] = "new";
                    mensaje = "No se ha encontrado ninguna asignación para el usuario. ¿ Desea crear una asignación ?";
                    ClientScript.RegisterStartupScript(this.GetType(), "myScript", "mostrarmsj('" + mensaje + "');", true);      
                }
                else
                {
                    Session["ope"] = "edit";
                    Session["currentAllocation"] = allocation;
                    mensaje = "Se ha encontrado una asignación para el usuario. ¿ Desea editar la asignación ?";
                    ClientScript.RegisterStartupScript(this.GetType(), "myScript", "mostrarmsj('" + mensaje + "');", true);       
                }                              
            }
            else
            {
                Response.Write("<script>alert('El paciente no existe');</script>");
            }            
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            CheckBox chkHolter;
            CheckBox chkMobile;

            int idHolter = 0;
            int idMobile = 0;

            bool result = false;

            BEEquipment currentEquipment;
            BEEquipment newEquipment;
                        
            foreach (DataGridItem item in DgEquipmentHolter.Items)
            {
                chkHolter = (CheckBox)item.Cells[0].FindControl("chkHolter");
                if (chkHolter.Checked)
                {
                    idHolter = int.Parse(item.Cells[1].Text);
                    break;
                }
            }

            foreach (DataGridItem item in DgEquipmentMovil.Items)
            {
                chkMobile = (CheckBox)item.Cells[0].FindControl("chkMobile");
                if (chkMobile.Checked)
                {
                    idMobile = int.Parse(item.Cells[1].Text);
                    break;
                }
            }
            
            var ope = Session["ope"].ToString();
            if (ope == "new")
            {
                BEPatient patient = (BEPatient)Session["Patient"];
                BEEquipment holter = new BEEquipment() { Id = idHolter };
                BEEquipment mobile = new BEEquipment() { Id = idMobile };
                result = logic.Register(patient, holter, mobile);
            }
            else
            {
                List<BEAllocation> allocations = (List<BEAllocation>)Session["currentAllocation"];
                
                foreach (BEAllocation item in allocations)
                {
                    currentEquipment = new BLEquipment().FindById(item.Equipment.Id);
                    
                    newEquipment = new BEEquipment();

                    if (currentEquipment.Type.Description == "Holter")
                    {
                        newEquipment.Id = idHolter;    

                    }
                    else if (currentEquipment.Type.Description == "Movil")
                    {
                        newEquipment.Id = idMobile;
                    }

                    result = logic.Modify(item, newEquipment);
                    if (!result)
                    {
                        break;
                    }                    

                }

                if (result)
                {
                    Session.Remove("ope");
                    Session.Remove("currentAllocation");
                    Session.Remove("Patient");
                    Response.Redirect("/Index.aspx");
                }                
            }

            if (result)
            {
                Session.Remove("ope");
                Session.Remove("currentAllocation");
                Session.Remove("Patient");
                Response.Redirect("/Index.aspx");
            }
            
        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            var ope = Session["ope"].ToString();
            ddlDocumentType.Enabled = false;
            txtDocumentNumber.Enabled = false;
            btnFindAssign.Enabled = false;
            btnSave.Enabled = true;
            if (ope == "edit")
            {
                btnRemove.Enabled = true;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("ope");
            Session.Remove("currentAllocation");
            Session.Remove("Patient");
            Response.Redirect("/Index.aspx");
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            bool result = false;
            List<BEAllocation> allocations = (List<BEAllocation>)Session["currentAllocation"];
            foreach (BEAllocation item in allocations)
            {
                result = logic.Remove(item);
                if (!result)
                {
                    break;
                }
            }

            if (result)
            {
                Session.Remove("ope");
                Session.Remove("currentAllocation");
                Session.Remove("Patient");
                Response.Redirect("/Index.aspx");
            }

        }
    }
}