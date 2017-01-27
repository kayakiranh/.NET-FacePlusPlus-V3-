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
    public partial class AddFaceToFaceset : System.Web.UI.Page
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
            string image = aftfsUrl.Text;
            int landmark = Convert.ToInt32(aftfsLandmark.Text == null ? "0" : aftfsLandmark.Text);
            string attributes = aftfsAttribute.Text == null ? "" : aftfsAttribute.Text;
            string outer = aftfsOuter.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            string json = AS.AddFaceToFaceSet(faceset_token, outer, face_token);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}