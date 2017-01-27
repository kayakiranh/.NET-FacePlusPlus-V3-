using FacePP.Service;
using FacePP.WebForm.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacePP.WebForm
{
    public partial class UpdateFaceset : System.Web.UI.Page
    {
        private static ApiService AS;
        private static ReadJson RJ;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string name = ufsDisplay.Text == null ? "" : ufsDisplay.Text;
            string outer = ufsOuter.Text;
            string new_outer = ufsNewOuter.Text;
            string tag = ufsTag.Text == null ? "" : ufsTag.Text;
            string data = ufsData.Text == null ? "" : ufsData.Text;

            string json = AS.UpdateFaceSet(outer, new_outer, name, data, tag);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}