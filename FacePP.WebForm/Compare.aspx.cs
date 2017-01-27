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
    public partial class Compare : System.Web.UI.Page
    {
        private static ApiService AS;
        private static ReadJson RJ;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            AS = new ApiService();

            //upload image and create link
            FileUpload1.SaveAs(Server.MapPath("~/images/") + FileUpload1.FileName); //save image your selected file
            //string newUrl = "http://www.yourdomain.com/images/" + FileUpload1.FileName; //use this for web app
            string newUrl = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //for demo

            //upload image and create link
            FileUpload2.SaveAs(Server.MapPath("~/images/") + FileUpload1.FileName); //save image your selected file
            //string newUrl = "http://www.yourdomain.com/images/" + FileUpload1.FileName; //use this for web app
            string newUrl2 = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //for demo

            string json = AS.CompareFace(newUrl, newUrl2);
            result.InnerHtml = RJ.GetResponse(json);
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string image = linkUrl.Text;
            string image2 = linkUrl2.Text;

            string json = AS.CompareFace(image, image2);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}