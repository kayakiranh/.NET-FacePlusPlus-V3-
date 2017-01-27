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
    public partial class ListFaceset : System.Web.UI.Page
    {
        private static ApiService AS;
        private static ReadJson RJ;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_Click1(object sender, EventArgs e)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string tags = lfsTag.Text == null ? "" : lfsTag.Text;
            int start = Convert.ToInt32(lfsStart.Text == null ? "1" : lfsStart.Text);

            string json = AS.GetFaceSetList(tags, start);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}