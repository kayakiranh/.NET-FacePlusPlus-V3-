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
    public partial class SetUserIDWithToken : System.Web.UI.Page
    {
        private static ApiService AS;
        private static ReadJson RJ;
        private static Service.Helper H;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            //Detect an image and get detected image token
            string image = suivtUrl.Text;
            int landmark = Convert.ToInt32(suivtLandmark.Text == null ? "0" : suivtLandmark.Text);
            string attributes = suivtAttribute.Text == null ? "none" : suivtAttribute.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            //get json value
            string new_userid = suivtUser.Text; //that should be same token, if not necessary dont change

            string json = AS.SetFaceDetailWithToken(face_token, new_userid);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}