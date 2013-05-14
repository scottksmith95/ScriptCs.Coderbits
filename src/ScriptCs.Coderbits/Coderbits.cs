using System;
using System.Net;
using Newtonsoft.Json;
using ScriptCs.Contracts;

namespace ScriptCs.Coderbits
{
    public class Coderbits : IScriptPackContext
    {
        const string PATH = "https://coderbits.com/";

        public CoderbitsModel GetProfile(string username)
        {
            //Create WebClient for making request for profile
            var client = new WebClient();

            //Get profile response as a JSON string
            var jsonString = client.DownloadString(PATH + username + ".json");

            //Convert to JSON string to Coderbits model
            var coderbitsModel = JsonConvert.DeserializeObject<CoderbitsModel>(jsonString);

            //Return the model
            return coderbitsModel;
        }
    }
}