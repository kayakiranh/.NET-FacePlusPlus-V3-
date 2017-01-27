using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Specialized;

namespace FacePP.Service
{
    public class ApiService
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

        #region USER INFO

        //for console/windows form
        private static string username = "FACEPLUSPLUS USER EMAIL"; //faceplusplus login email
        private static string password = "FACEPLUSPLUS USER PASSWORD"; //faceplusplus login password
        private static string apikey = "FACEPLUSPLUS API KEY"; //faceplusplus v3 apikey
        private static string apisecret = "FACEPLUSPLUS API SECRET"; //faceplusplus v3 apisecret
        //for console/windows form

        ////for web form/mvc
        //private static string username = System.Configuration.ConfigurationManager.AppSettings["facepp_username"];
        //private static string password = System.Configuration.ConfigurationManager.AppSettings["facepp_Password"];
        //private static string apikey = System.Configuration.ConfigurationManager.AppSettings["apikey"];
        //private static string apisecret = System.Configuration.ConfigurationManager.AppSettings["apisecret"];
        ////for web form/mvc

        #endregion USER INFO

        #region API LIST

        private static string url_detect = "https://api-us.faceplusplus.com/facepp/v3/detect";
        private static string url_compare = "https://api-us.faceplusplus.com/facepp/v3/compare";
        private static string url_search = "https://api-us.faceplusplus.com/facepp/v3/search";
        private static string url_faceset_create = "https://api-us.faceplusplus.com/facepp/v3/faceset/create";
        private static string url_faceset_addface = "https://api-us.faceplusplus.com/facepp/v3/faceset/addface";
        private static string url_faceset_removeface = "https://api-us.faceplusplus.com/facepp/v3/faceset/removeface";
        private static string url_faceset_update = "https://api-us.faceplusplus.com/facepp/v3/faceset/update";
        private static string url_faceset_getdetail = "https://api-us.faceplusplus.com/facepp/v3/faceset/getdetail";
        private static string url_faceset_delete = "https://api-us.faceplusplus.com/facepp/v3/faceset/delete";
        private static string url_faceset_getfacesets = "https://api-us.faceplusplus.com/facepp/v3/faceset/getfacesets";
        private static string url_analyze = "https://api-us.faceplusplus.com/facepp/v3/face/analyze";
        private static string url_getdetail = "https://api-us.faceplusplus.com/facepp/v3/face/getdetail";
        private static string url_setuserid = "https://api-us.faceplusplus.com/facepp/v3/face/setuserid";

        #endregion API LIST

        #region CONNECT FACEPLUSPLUS V3 API

        private string Connect(string url, string parameters, string urlWithParameter)
        {
            try
            {
                WebRequest request = WebRequest.Create(urlWithParameter); //create request
                string basicAuth = SetBasicAuthHeader(request, username, password); //basic auth with login infos

                var data = Encoding.ASCII.GetBytes(parameters); //parameters with ascii

                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST"; //get methot doest work with this codes
                request.Headers.Add("Authorization", basicAuth); //basic auth must be add
                request.Headers.Add("Cache-Control", "no-cache");
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length); //add parameters to request
                }

                using (var resp = request.GetResponse())
                {
                    return new StreamReader(resp.GetResponseStream()).ReadToEnd(); //read api response
                }
            }
            catch (Exception ex)
            {
                var report = ex; //not necessary but must save for detailed error
                var message = ex.Message;
                return message;
            }
        }

        public string SetBasicAuthHeader(WebRequest request, String userName, String userPassword)
        {
            string authInfo = userName + ":" + userPassword;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            return "Basic " + authInfo;
        }

        #endregion CONNECT FACEPLUSPLUS V3 API

        //Detect Face
        //Detect API detects and analyzes human faces within the image that you provided by image file or URL.Every detected face gets its face_token,
        //which can be used in follow-up operations. Please note that only the 5 largest faces by its bounding box size will be analyzed, while you can
        //use Face Analyze API to analyze the rest faces.If you want to use the detected face for follow-up operations, we recommend you to add its
        //corresponding face_token into FaceSet. A face_token expires within 72 hours if it is not added into any FaceSet.
        //Every time you operate face detection upon one image, the face within the image will get a different face_token.
        //https://console.faceplusplus.com/documents/5679127
        public string DetectFace(string image, int landmark, string attributes)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&image_url=" + image + "&return_landmark=" + landmark.ToString() + "&return_attributes=" + attributes;
            //create url with parameter
            string urlWithParameter = url_detect + "?" + parameters;
            //send all and get response
            return Connect(url_detect, parameters, urlWithParameter);
        }

        //Compare 2 Faces
        //Compare two faces and decide whether they are from the same person. You can upload image file or use face_token for face comparing.
        //For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.
        //https://console.faceplusplus.com/documents/5679308
        public string CompareFace(string image, string image2)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&image_url1=" + image + "&image_url2=" + image2;
            //create url with parameter
            string urlWithParameter = url_compare + "?" + parameters;
            //send all and get response
            return Connect(url_compare, parameters, urlWithParameter);
        }

        //Search face inside faceset
        //Find one or more most similar faces from Faceset, to a new face. You can upload image file or use face_token for face searching.
        //For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.
        //https://console.faceplusplus.com/documents/5681455
        public string SearchFace(string image, string outer, int count)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&image_url=" + image + "&outer_id=" + outer + "&return_result_count=" + count.ToString();
            //create url with parameter
            string urlWithParameter = url_search + "?" + parameters;

            //send all and get response
            return Connect(url_search, parameters, urlWithParameter);
        }

        //Faceset create
        //Create a face collection called FaceSet to store face_token. One FaceSet can hold up to 1000 face_token.
        //https://console.faceplusplus.com/documents/6329329
        public string CreateFaceSet(string name, string outer, string tag, string token, string data, int force)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&display_name=" + name + "&outer_id=" + outer + "&tag=" + tag +
                "&face_tokens=" + token + "&user_data=" + data + "&force_merge=" + force;

            //create url with parameter
            string urlWithParameter = url_faceset_create + "?" + parameters;

            //send all and get response
            return Connect(url_faceset_create, parameters, urlWithParameter);
        }

        //Faceset update
        //Update the attributes of a FaceSet.
        //https://console.faceplusplus.com/documents/6329383
        public string UpdateFaceSet(string outer, string new_outer, string name, string data, string tag)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&outer_id=" + outer + "&new_outer_id=" + new_outer;

            //create url with parameter
            string urlWithParameter = url_faceset_update + "?" + parameters;

            //send all and get response
            return Connect(url_faceset_update, parameters, urlWithParameter);
        }

        //Faceset get detail
        //Get details about a FaceSet.
        //https://console.faceplusplus.com/documents/6329388
        public string GetDetailFaceSet(string outer)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&outer_id=" + outer;

            //create url with parameter
            string urlWithParameter = url_faceset_getdetail + "?" + parameters;

            //send all and get response
            return Connect(url_faceset_getdetail, parameters, urlWithParameter);
        }

        //Get facelists with query
        //Get all the FaceSet.
        //https://console.faceplusplus.com/documents/6329388
        public string GetFaceSetList(string tag, int start)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&tags=" + tag + "&start=" + start.ToString();

            //create url with parameter
            string urlWithParameter = url_faceset_getfacesets + "?" + parameters;

            //send all and get response
            return Connect(url_faceset_getfacesets, parameters, urlWithParameter);
        }

        //Face set remove
        //Delete a FaceSet.
        //https://console.faceplusplus.com/documents/6329394
        public string RemoveFaceSet(string outer, int empty)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&outer_id=" + outer + "&check_empty=" + empty.ToString();
            //create url with parameter
            string urlWithParameter = url_faceset_delete + "?" + parameters;
            //send all and get response
            return Connect(url_faceset_delete, parameters, urlWithParameter);
        }

        //Add face to faceset
        //Add face_token into an existing FaceSet. One FaceSet can hold up to 1000 face_token.
        //https://console.faceplusplus.com/documents/6329371
        public string AddFaceToFaceSet(string faceset, string outer, string face)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&faceset_token=" + faceset + "&outer_id	=" + outer + "&face_tokens=" + face;
            //create url with parameter
            string urlWithParameter = url_faceset_addface + "?" + parameters;
            //send all and get response
            return Connect(url_faceset_addface, parameters, urlWithParameter);
        }

        //Remove face from faceset
        //Remove all or part of face_token within a FaceSet.
        //https://console.faceplusplus.com/documents/6329376
        public string RemoveFaceFromFaceSet(string faceset, string outer, string face)
        {
            //parameters full
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&faceset_token=" + faceset + "&outer_id	=" + outer + "&face_tokens=" + face;
            //create url with parameter
            string urlWithParameter = url_faceset_removeface + "?" + parameters;
            //send all and get response
            return Connect(url_faceset_removeface, parameters, urlWithParameter);
        }

        //Face Analyze
        //Get face landmarks and attributes by passing its face_token which you can get from Detect API.
        //Face Analyze API allows you to process  up to 5 face_token at a time.
        //https://console.faceplusplus.com/documents/6329465
        public string AnalyzeFace(string token, int landmark, string attributes)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&face_tokens=" + token + "&return_landmark=" + landmark.ToString() + "&return_attributes=" + attributes;
            //create url with parameter
            string urlWithParameter = url_analyze + "?" + parameters;
            //send all and get response
            return Connect(url_analyze, parameters, urlWithParameter);
        }

        //Face detail
        //Get related information to a face by passing its face_token which you can get from Detect API.
        //Face related information includes image_id and FaceSet which it belongs to.
        //https://console.faceplusplus.com/documents/6329496
        public string FaceDetailWithToken(string token)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&face_token=" + token;
            //create url with parameter
            string urlWithParameter = url_getdetail + "?" + parameters;
            //send all and get response
            return Connect(url_getdetail, parameters, urlWithParameter);
        }

        //Face set user id
        //Set user_id for a detected face. user_id can be returned in Search results to determine the identity of user.
        //https://console.faceplusplus.com/documents/6329496
        public string SetFaceDetailWithToken(string token, string id)
        {
            //parameters
            string parameters = "api_key=" + apikey + "&api_secret=" + apisecret + "&face_token=" + token + "&user_id=" + id;
            //create url with parameter
            string urlWithParameter = url_setuserid + "?" + parameters;
            //send all and get response
            return Connect(url_setuserid, parameters, urlWithParameter);
        }
    }
}