using System;
using System.Net;
using Newtonsoft.Json;
using ScriptCs.Contracts;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScriptCs.Coderbits
{
    public class Coderbits : IScriptPackContext
    {
        const string PATH = "https://coderbits.com/";

        public CoderbitsModel GetProfile(string username)
        {
            return GetProfileAsync(username).Result;
        }

        public async Task<CoderbitsModel> GetProfileAsync(string username)
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            //Get profile response as a JSON string
            var jsonStringTask = client.GetStringAsync(GetProfilePath(username));

            //Await
            var jsonString = await jsonStringTask;

            //Convert to JSON string to Coderbits model
            var coderbitsModelTask = JsonConvert.DeserializeObjectAsync<CoderbitsModel>(jsonString);

            //Await
            var coderbitsModel = await coderbitsModelTask;

            //Return the model
            return coderbitsModel;
        }

        string GetProfilePath(string username)
        {
            return PATH + username + ".json";
        }
    }
}