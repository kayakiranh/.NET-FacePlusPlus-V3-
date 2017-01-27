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
    public partial class RemoveFaceFromFaceset : System.Web.UI.Page
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

            //create variables
            string image = fsrfUrl.Text;
            string outer = fsrfOuter.Text;
            //get json value
            string searchResult = AS.SearchFace(image, outer, 1);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForSearchToken(searchResult);

            string json = AS.RemoveFaceFromFaceSet(faceset_token, outer, face_token);
            result.InnerHtml = RJ.GetResponse(json);
        }
    }
}