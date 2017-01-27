using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacePP.MVC5.Helper
{
    public class ReadJson
    {
        public string GetResponse(string json)
        {
            try
            {
                return JObject.Parse(json).ToString(Formatting.Indented);
            }
            catch
            {
                return json;
            }
        }
    }
}