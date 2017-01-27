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
    public partial class DetailFaceset : System.Web.UI.Page
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

            string outer = dfsOuter.Text;

            string json = AS.GetDetailFaceSet(outer);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}