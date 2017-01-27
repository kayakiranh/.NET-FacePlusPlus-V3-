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
    public partial class CreateFaceset : System.Web.UI.Page
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

            string name = cfsDisplay.Text == null ? "" : cfsDisplay.Text;
            string outer = cfsOuter.Text == null ? "" : cfsOuter.Text;
            string tag = cfsTag.Text == null ? "" : cfsTag.Text;
            string token = "";
            string data = cfsData.Text == null ? "" : cfsData.Text;
            int force = Convert.ToInt32(cfsForce.Text == null ? "0" : cfsForce.Text);

            string json = AS.CreateFaceSet(name, outer, tag, token, data, force);
            result.InnerHtml = RJ.GetResponse(json);
        }


    }
}