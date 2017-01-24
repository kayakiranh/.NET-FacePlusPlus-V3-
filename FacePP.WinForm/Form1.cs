using FacePP.Service;
using System;
using System.Windows.Forms;

namespace FacePP.WinForm
{
    public partial class Form1 : Form
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

        ///NEWTONSOFT.JSON NUGGET ADDED
        /// "/Assemblies/Microsoft.Csharp" ADDED TO REFERENCE
        /// "/Projects/FacePP.Service" ADDED TO REFERENCE

        private static ApiService AS; //service instances
        private static Helper H; //hepler instances

        public Form1()
        {
            InitializeComponent();

            MessageBox.Show(
                "!!! PLEASE READ ONCE START DEVELOPMENT !!!" + Environment.NewLine +
                "Info : Face++ Cognitive Service C# codes. This codes are usable for Face++ Version 3." + Environment.NewLine + Environment.NewLine +
                "Prepared By : Hüseyin Kayakıran (http://www.huseyinkayakiran.com/) (iletisim@huseyinkayakiran.com)" + Environment.NewLine +
                "Prepared For : Face++ Company(https://www.faceplusplus.com/)" + Environment.NewLine +
                "Prepared Date : 24.01.2017" + Environment.NewLine + Environment.NewLine +
                "Using : You must be Face++(https://www.faceplusplus.com/) member. Change user info and ready to use. Follow Face++ Company for updates." + Environment.NewLine +
                "Using Advice : Please dont share your user info with no one. If you develop web app, you must save all user info inside web.config." + Environment.NewLine + Environment.NewLine +
                "Pricing/Limit/Rights : Person/Company can use totaly free. Pricing and limits will change your Face++(https://www.faceplusplus.com/) account type. Follow Face++ Company for updates." + Environment.NewLine +
                "Privacy/Security : All right reserved by Face++ Company(https://www.faceplusplus.com/) have all rights. For all question : support@faceplusplus.com" + Environment.NewLine + Environment.NewLine +
                "Mistake/Problem/Support For C# : iletisim@huseyinkayakiran.com, support@faceplusplus.com" + Environment.NewLine +
                "Support For JAVA/Python : support@faceplusplus.com" + Environment.NewLine +
                "Support For Business :  business@faceplusplus.com, support@faceplusplus.com" + Environment.NewLine + Environment.NewLine +
                "!!! PLEASE READ ONCE START DEVELOPMENT !!!" + Environment.NewLine + Environment.NewLine +
                "NEWTONSOFT.JSON NUGGET ADDED" + Environment.NewLine +
                "'/Assemblies/Microsoft.Csharp' ADDED TO REFERENCE" + Environment.NewLine +
                "'/Projects/FacePP.Service' ADDED TO REFERENCE" + Environment.NewLine
                );
        }

        private void detectButton_Click(object sender, System.EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string image = detectUrl.Text;
            int landmark = Convert.ToInt32(detectLandmark.Text);
            string attributes = detectAttribute.Text;
            //get json value
            MessageBox.Show(AS.DetectFace(image, landmark, attributes));
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string image = compareUrl1.Text;
            string image2 = compareUrl2.Text;
            //get json value
            MessageBox.Show(AS.CompareFace(image, image2));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string image = searchUrl.Text;
            string outer = searchOuter.Text;
            int count = Convert.ToInt32(searchCount.Text);
            //get json value
            MessageBox.Show(AS.SearchFace(image, outer, count));
        }

        private void createFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string name = createFaceSetDisplayName.Text;
            string outer = createFaceSetOuterName.Text;
            string tag = createFaceSetTags.Text;
            string token = "";
            string data = createFaceSetDataName.Text;
            int force = Convert.ToInt32(createFaceSetForce.Text);
            //get json value
            MessageBox.Show(AS.CreateFaceSet(name, outer, tag, token, data, force));
        }

        private void removeFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string outer = label45435345.Text;
            int empty = Convert.ToInt32(removeFaceSetEmpty.Text);
            //get json value
            MessageBox.Show(AS.RemoveFaceSet(outer, empty));
        }

        private void updataFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string name = updataFaceSetDisplayName.Text;
            string outer = updataFaceSetOuterName.Text;
            string new_outer = updataFaceSetNewOuterName.Text;
            string tag = updataFaceSetTags.Text;
            string data = updataFaceSetDataName.Text;
            //get json value
            MessageBox.Show(AS.UpdateFaceSet(outer, new_outer, name, data, tag));
        }

        private void detailFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            //create variables
            string outer = detailFaceSetOuterName.Text;
            //get json value
            MessageBox.Show(AS.GetDetailFaceSet(outer));
        }

        private void removeFaceToFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            H = new Helper();

            //create variables
            string image = removeFaceToFaceSetLink.Text;
            string outer = removeFaceToFaceSetOuter.Text;
            int count = Convert.ToInt32(searchCount.Text);
            //get json value
            string searchResult = AS.SearchFace(image, outer, count);

            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForSearchToken(searchResult);

            //get json value
            MessageBox.Show(AS.RemoveFaceFromFaceSet(faceset_token, outer, face_token));
        }

        private void addFaceToFaceSetButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            H = new Helper();

            //Detect an image and get detected image token
            string image = addFaceToFaceSetLink.Text;
            int landmark = Convert.ToInt32(addFaceToFaceSetLandmark.Text);
            string attributes = addFaceToFaceSetAttribute.Text;
            string outer = addFaceToFaceSetOuter.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);

            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            //get json value
            MessageBox.Show(AS.AddFaceToFaceSet(faceset_token, outer, face_token));
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            H = new Helper();

            //create variables
            //Detect an image and get detected image token
            string image = analyzeLink.Text;
            int landmark = Convert.ToInt32(analyzeLandmark.Text);
            string attributes = analyzeAttribute.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            //get json value
            MessageBox.Show(AS.AnalyzeFace(face_token, landmark, attributes));
        }

        private void detailFaceWithTokenButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            H = new Helper();
            //create variables
            //Detect an image and get detected image token
            string image = detailFaceWithTokenLink.Text;
            int landmark = Convert.ToInt32(detailFaceWithTokenLandmark.Text);
            string attributes = detailFaceWithTokenAttribute.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            //get json value
            MessageBox.Show(AS.FaceDetailWithToken(face_token));
        }

        private void setFaceUserIDButton_Click(object sender, EventArgs e)
        {
            //service instance
            AS = new ApiService();
            H = new Helper();
            //create variables
            //Detect an image and get detected image token
            string image = setFaceUserIDLink.Text;
            int landmark = Convert.ToInt32(setFaceUserIDLandmark.Text);
            string attributes = setFaceUserIDAttribute.Text;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            //get json value
            string new_userid = setFaceUserIDNewUser.Text; //that should be same token, if not necessary dont change

            MessageBox.Show(AS.SetFaceDetailWithToken(face_token, new_userid));
        }
    }
}