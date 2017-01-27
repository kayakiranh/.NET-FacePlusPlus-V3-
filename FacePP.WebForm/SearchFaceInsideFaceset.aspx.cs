using FacePP.Service;
using FacePP.WebForm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacePP.WebForm
{
    public partial class SearchFaceInsideFaceset : System.Web.UI.Page
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

            string image = sfifUrl.Text;
            string outer = sfifOuter.Text;
            int count = Convert.ToInt32(sfifForce.Text == null ? "0" : sfifForce.Text);

            string json = AS.SearchFace(image, outer, count);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}