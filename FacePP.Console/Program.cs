using FacePP.Service;
using System;

namespace FacePP.Console
{
    internal class Program
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

        /// "/Assemblies/Microsoft.Csharp" ADDED TO REFERENCE
        /// "/Projects/FacePP.Service" ADDED TO REFERENCE

        private static ApiService AS; //service instances
        private static Helper H;

        //Console Work Here
        private static void Main(string[] args)
        {
            //OPEN COMMENDS WHAT YOU NEED

            System.Console.WriteLine(
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
            System.Console.WriteLine("Return code and open commends what you need");
            System.Console.ReadKey();

            ////face detect service
            //string response = CallDetectFaceService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////face detect service

            ////face compare service
            //string response = CallCompareFaceService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////face compare service

            ////face search service
            //string response = CallSearchFaceService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////face search service

            ////create faceset service
            //string response = CallCreateFaceSetService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////create faceset service

            ////update faceset service
            //string response = CallUpdateFaceSetService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////update faceset service

            ////remove faceset service
            //string response = CallRemoveFaceSetService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////remove faceset service

            ////faceset list service(with tag and faceset number parameter)
            //string response3 = CallFaceSetListService("neymar",1000);
            //System.Console.WriteLine(response3);
            //System.Console.ReadKey();
            ////faceset list service

            ////faceset detail service(with outer_id parameter)
            //string response = CallDetailFaceSetService("LL");
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////faceset detail service

            ////add face to faceset service
            //string response = CallAddFaceToFaceSetService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////add face to faceset service

            ////remove face from faceset service
            //string response = CallRemoveFaceFromFaceSetService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////remove face from service

            ////analyze service
            //string response = CallAnalyzeFaceService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////analyze service

            ////face detail with token service
            //string response = CallFaceDetailWithTokenService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////face detail with token service

            ////set userid with token service
            //string response = CallSetFaceDetailWithTokenService();
            //System.Console.WriteLine(response);
            //System.Console.ReadKey();
            ////set userid with token service
        }

        //Detect
        private static string CallDetectFaceService()
        {
            AS = new ApiService();

            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            int landmark = 1; //get all landmark values
            string attributes = "gender,age,smiling,headpose,facequality,blur,eyestatus"; // get all attributes

            return AS.DetectFace(image, landmark, attributes);
        }

        //Compare
        private static string CallCompareFaceService()
        {
            AS = new ApiService();

            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet
            string image2 = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet

            return AS.CompareFace(image, image2);
        }

        //Search
        private static string CallSearchFaceService()
        {
            AS = new ApiService();

            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            string outer = "LL"; //Faceset outer name
            int count = 1; //default 1, min = 1 and max = 5

            return AS.SearchFace(image, outer, count);
        }

        //Create FaceSet
        private static string CallCreateFaceSetService()
        {
            AS = new ApiService();

            string name = "LL Face Set";
            string outer = "LL"; //remember outer for call faceset again or call facesetlist service for remember outer
            string tag = "neymar";
            string token = "";
            string data = "LL Players";
            int force = 0; //default

            return AS.CreateFaceSet(name, outer, tag, token, data, force);
        }

        //Update FaceSet
        private static string CallUpdateFaceSetService()
        {
            AS = new ApiService();

            string name = "EPL Face Set";
            string outer = "LL"; //remember outer for call faceset again or call facesetlist service for remember outer
            string new_outer = "EPL";
            string tag = "rooney";
            string data = "England Premier League Players";

            return AS.UpdateFaceSet(outer, new_outer, name, data, tag);
        }

        //Remove FaceSet
        private static string CallRemoveFaceSetService()
        {
            AS = new ApiService();
            //create variables
            string outer = "EPL";
            int empty = 0; //if dont want remove not empty faceset turn it 1

            return AS.RemoveFaceSet(outer, empty);
        }

        //Add face to faceset
        private static string CallAddFaceToFaceSetService()
        {
            AS = new ApiService();
            H = new Helper();

            //Detect an image and get detected image token
            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            int landmark = 1; //get all landmark values
            string attributes = "none"; // none attributes for more speed
            string outer = "LL";
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            return AS.AddFaceToFaceSet(faceset_token, outer, face_token);
        }

        //Get faceset list
        private static string CallFaceSetListService(string tag, int start)
        {
            AS = new ApiService();
            return AS.GetFaceSetList(tag, start);
        }

        //Remove face to faceset
        private static string CallRemoveFaceFromFaceSetService()
        {
            AS = new ApiService();
            H = new Helper();

            //Detect an image and get detected image token
            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            string outer = "LL";
            int count = 1;
            //get detected image json value
            string searchResult = AS.SearchFace(image, outer, count);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForSearchToken(searchResult);

            return AS.RemoveFaceFromFaceSet(faceset_token, outer, face_token);
        }

        //Get faceset response json's outer_id
        private static string CallDetailFaceSetService(string outer)
        {
            AS = new ApiService();
            return AS.GetDetailFaceSet(outer);
        }

        //Analyze
        private static string CallAnalyzeFaceService()
        {
            AS = new ApiService();
            H = new Helper();

            //create variables
            //Detect an image and get detected image token
            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            int landmark = 1; //get all landmark values
            string attributes = "none"; // none attributes for more speed
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            return AS.AnalyzeFace(face_token, landmark, attributes);
        }

        //Face detail with token
        private static string CallFaceDetailWithTokenService()
        {
            AS = new ApiService();
            H = new Helper();

            //Detect an image and get detected image token
            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            int landmark = 1; //get all landmark values
            string attributes = "none"; // none attributes for more speed
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            return AS.FaceDetailWithToken(face_token);
        }

        //Face detail with token
        private static string CallSetFaceDetailWithTokenService()
        {
            AS = new ApiService();
            H = new Helper();

            //Detect an image and get detected image token
            string image = "http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg"; //image is link, dont prefer for low internet.
            int landmark = 1; //get all landmark values
            string attributes = "none"; // none attributes for more speed
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            string new_userid = "test"; //that should be same token, if not necessary dont change

            return AS.SetFaceDetailWithToken(face_token, new_userid);
        }
    }
}