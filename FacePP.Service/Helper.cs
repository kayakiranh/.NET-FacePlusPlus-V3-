using Newtonsoft.Json;
using System;

namespace FacePP.Service
{
    public class Helper
    {
        //24 chars random string
        public string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[24];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        //Get detected image response json's token value
        public string ReadJsonForDetectedImageToken(string txt)
        {
            string token = "";
            try
            {
                dynamic dynObj = JsonConvert.DeserializeObject(txt);
                foreach (var item in dynObj.faces)
                {
                    token = item.face_token;
                }
            }
            catch { token = "error/not found"; }
            return token;
        }

        //Get search result response json's token value
        public string ReadJsonForSearchToken(string txt)
        {
            string token = "";
            try
            {
                dynamic dynObj = JsonConvert.DeserializeObject(txt);
                foreach (var item in dynObj.results)
                {
                    token = item.face_token;
                }
            }
            catch { token = "error/not found"; }
            return token;
        }

        //Get facesetlist response json's token
        public string ReadJsonFaceSetListForFaceSetToken(string txt)
        {
            string token = "";
            try
            {
                dynamic dynObj = JsonConvert.DeserializeObject(txt);
                foreach (var item in dynObj.facesets)
                {
                    token = item.faceset_token;
                }
            }
            catch { token = "error/not found"; }
            return token;
        }

        //Get facesetlist response json's outer_id
        public string ReadJsonFaceSetListForFaceSetOuter(string txt)
        {
            string token = "";
            try
            {
                dynamic dynObj = JsonConvert.DeserializeObject(txt);
                foreach (var item in dynObj.facesets)
                {
                    token = item.outer_id;
                }
            }
            catch { token = "error/not found"; }
            return token;
        }

        //Get faceset response json's outer_id
        public string ReadJsonDetailFaceSetForDetectedImageToken(string txt)
        {
            string token = "";
            try
            {
                dynamic dynObj = JsonConvert.DeserializeObject(txt);
                token = dynObj.faceset_token;
            }
            catch { token = "error/not found"; }
            return token;
        }
    }
}