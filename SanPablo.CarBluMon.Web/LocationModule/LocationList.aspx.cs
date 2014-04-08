using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.HelpRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SanPablo.CarBluMon.Web.LocationModule
{
    public partial class LocationList : System.Web.UI.Page
    {
        BLHelpRequest logic = new BLHelpRequest();
        private void GetHelpRequests()
        {
            List<BEHelpRequest> listHelpRequest = logic.Find(null);
            dgHelpRequest.DataSource = listHelpRequest;
            dgHelpRequest.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetHelpRequests();
            }
        }
    }
}