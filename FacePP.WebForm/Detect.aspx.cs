using FacePP.Service;
using FacePP.WebForm.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacePP.WebForm
{
    public partial class Detect : System.Web.UI.Page
    {
        /// !!! PLEASE READ ONCE START DEVELOPMENT !!!
        ///
        /// Info : Face++ Cognitive Service C# codes. This codes are usable for Face++ Version 3.
        ///
        /// Prepared By : Hüseyin Kayakıran (http://www.huseyinkayakiran.com/) (iletisim@huseyinkayakiran.com)
        /// Prepared For : Face++ Company(https://www.faceplusplus.com/)
        /// Prepared Date : 24.01.2017
        ///
        /// Using : You must be Face++(https://www.faceplusplus.com/) member. Change user info and ready to use. Follow Face++ Company for updates.
        /// Using Advice : Please dont share your user info with no one. If you develop web app, you must save all user info inside web.config.
        ///
        /// Pricing/Limit/Rights : Person/Company can use totaly free. Pricing and limits will change your Face++(https://www.faceplusplus.com/) account type. Follow Face++ Company for updates.
        /// Privacy/Security : All right reserved by Face++ Company(https://www.faceplusplus.com/) have all rights. For all question : support@faceplusplus.com
        ///
        /// Mistake/Problem/Support For C# : iletisim@huseyinkayakiran.com, support@faceplusplus.com
        /// Support For JAVA/Python : support@faceplusplus.com
        /// Support For Business :  business@faceplusplus.com, support@faceplusplus.com
        ///
        /// !!! PLEASE READ ONCE START DEVELOPMENT !!!

        private static ApiService AS; //service instances
        private static ReadJson RJ;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string image = linkUrl.Text;
            int landmark = Convert.ToInt32(LinkLandmark.Text == null ? "0" : LinkLandmark.Text);
            string attributes = LinkAttribute.Text == null ? "none" : LinkAttribute.Text;

            string json = AS.DetectFace(image, landmark, attributes);
            result.InnerHtml = RJ.GetResponse(json);
        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            RJ = new ReadJson();
            //upload image and create link
            FileUpload1.SaveAs(Server.MapPath("~/images/") + FileUpload1.FileName); //save image your selected file
            //string newUrl = "http://www.yourdomain.com/images/" + FileUpload1.FileName; //use this for web app
            string newUrl = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //for demo

            //create variables
            string image = newUrl;
            int landmark = Convert.ToInt32(uploadLandmark.Text);
            string attributes = uploadAttribute.Text;
            //get json value
            string json = AS.DetectFace(image, landmark, attributes);
            result.InnerHtml = RJ.GetResponse(json);
        }

        [WebMethod]
        public static string GetAjaxResponse(string lnk, string lang, string attribute)
        {
            try
            {
                //service instance
                AS = new ApiService();
                RJ = new ReadJson();
                //create variables
                string image = lnk;
                int landmark = Convert.ToInt32(lang);
                string attributes = attribute;
                //get json value
                string json = AS.DetectFace(image, landmark, attributes);
                return RJ.GetResponse(json);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}