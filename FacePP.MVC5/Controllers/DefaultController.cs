using FacePP.MVC5.Helper;
using FacePP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacePP.MVC5.Controllers
{
    public class DefaultController : Controller
    {
        private static ApiService AS;
        private static ReadJson RJ;
        private static Service.Helper H;

        public ActionResult Detect()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Detect(string linkUrl, string LinkLandmark, string LinkAttribute)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string image = linkUrl;
            int landmark = Convert.ToInt32(LinkLandmark == null ? "0" : LinkLandmark);
            string attributes = LinkAttribute == null ? "none" : LinkAttribute;

            string json = AS.DetectFace(image, landmark, attributes);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult DetectWithUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DetectWithUpload(HttpPostedFileBase FileUpload1, string uploadLandmark, string uploadAttribute)
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
            int landmark = Convert.ToInt32(uploadLandmark);
            string attributes = uploadAttribute;
            //get json value
            string json = AS.DetectFace(image, landmark, attributes);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult DetectWithAjax(string linkUrl, string LinkLandmark, string LinkAttribute)
        {
            //service instance
            AS = new ApiService();
            RJ = new ReadJson();
            //create variables
            string image = linkUrl;
            int landmark = Convert.ToInt32(LinkLandmark);
            string attributes = LinkAttribute;
            //get json value
            string json = AS.DetectFace(image, landmark, attributes);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        [HttpPost]
        public ActionResult DetectWithAjax(string aftfsUrl)
        {
            return View();
        }

        public ActionResult Compare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Compare(string linkUrl, string linkUrl2)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string image = linkUrl;
            string image2 = linkUrl2;

            string json = AS.CompareFace(image, image2);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult CreateFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFaceset(string cfsDisplay, string cfsOuter, string cfsTag, string cfsData, string cfsForce)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string name = cfsDisplay == null ? "" : cfsDisplay;
            string outer = cfsOuter == null ? "" : cfsOuter;
            string tag = cfsTag == null ? "" : cfsTag;
            string token = "";
            string data = cfsData == null ? "" : cfsData;
            int force = Convert.ToInt32(cfsForce == null ? "0" : cfsForce);

            string json = AS.CreateFaceSet(name, outer, tag, token, data, force);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult UpdateFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateFaceset(string ufsDisplay, string ufsOuter, string ufsNewOuter, string ufsTag, string ufsData)
        {
            AS = new ApiService();

            string name = ufsDisplay == null ? "" : ufsDisplay;
            string outer = ufsOuter;
            string new_outer = ufsNewOuter;
            string tag = ufsTag == null ? "" : ufsTag;
            string data = ufsData == null ? "" : ufsData;

            string json = AS.UpdateFaceSet(outer, new_outer, name, data, tag);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult RemoveFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoveFaceset(string rfsOuter, string rfsForce)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string outer = rfsOuter;
            int empty = Convert.ToInt32(rfsForce == null ? "1" : rfsForce);

            string json = AS.RemoveFaceSet(outer, empty);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult DetailFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DetailFaceset(string dfsOuter)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string outer = dfsOuter;

            string json = AS.GetDetailFaceSet(outer);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult ListFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ListFaceset(string lfsTag, string lfsStart)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string tags = lfsTag == null ? "" : lfsTag;
            int start = Convert.ToInt32(lfsStart == null ? "1" : lfsStart);

            string json = AS.GetFaceSetList(tags, start);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult SearchFaceInsideFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchFaceInsideFaceset(string sfifUrl, string sfifOuter, string sfifForce)
        {
            AS = new ApiService();
            RJ = new ReadJson();

            string image = sfifUrl;
            string outer = sfifOuter;
            int count = Convert.ToInt32(sfifForce == null ? "0" : sfifForce);

            string json = AS.SearchFace(image, outer, count);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult AddFaceToFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFaceToFaceset(string aftfsUrl, string aftfsLandmark, string aftfsAttribute, string aftfsOuter)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            //Detect an image and get detected image token
            string image = aftfsUrl;
            int landmark = Convert.ToInt32(aftfsLandmark == null ? "0" : aftfsLandmark);
            string attributes = aftfsAttribute == null ? "" : aftfsAttribute;
            string outer = aftfsOuter;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //find tokens
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            string json = AS.AddFaceToFaceSet(faceset_token, outer, face_token);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult RemoveFaceFromFaceset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoveFaceFromFaceset(string fsrfUrl, string fsrfOuter)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            string image = fsrfUrl;
            string outer = fsrfOuter;
            //get json value
            string searchResult = AS.SearchFace(image, outer, 1);
            //find faceset for add detected image
            string facesetForAddDetectedImage = AS.GetDetailFaceSet(outer);
            //create variables
            string faceset_token = H.ReadJsonDetailFaceSetForDetectedImageToken(facesetForAddDetectedImage);
            string face_token = H.ReadJsonForSearchToken(searchResult);

            string json = AS.RemoveFaceFromFaceSet(faceset_token, outer, face_token);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult Analyze()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Analyze(string afUrl, string afLandmark, string afAttribute)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            //Detect an image and get detected image token
            string image = afUrl;
            int landmark = Convert.ToInt32(afLandmark);
            string attributes = afAttribute;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            string json = AS.AnalyzeFace(face_token, landmark, attributes);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult FaceDetailWithToken()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FaceDetailWithToken(string fdwtUrl, string fdwtLandmark, string fdwtAttribute)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            //Detect an image and get detected image token
            string image = fdwtUrl;
            int landmark = Convert.ToInt32(fdwtLandmark == null ? "0" : fdwtLandmark);
            string attributes = fdwtAttribute == null ? "none" : fdwtAttribute;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);

            string json = AS.FaceDetailWithToken(face_token);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }

        public ActionResult SetUserIDWithToken()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetUserIDWithToken(string suivtUrl, string suivtLandmark, string suivtAttribute, string suivtUser)
        {
            AS = new ApiService();
            RJ = new ReadJson();
            H = new Service.Helper();

            //Detect an image and get detected image token
            string image = suivtUrl;
            int landmark = Convert.ToInt32(suivtLandmark == null ? "0" : suivtLandmark);
            string attributes = suivtAttribute == null ? "none" : suivtAttribute;
            //get detected image json value
            string detectedImage = AS.DetectFace(image, landmark, attributes);
            string face_token = H.ReadJsonForDetectedImageToken(detectedImage);
            //get json value
            string new_userid = suivtUser; //that should be same token, if not necessary dont change

            string json = AS.SetFaceDetailWithToken(face_token, new_userid);
            ViewBag.Result = RJ.GetResponse(json);
            return View();
        }
    }
}