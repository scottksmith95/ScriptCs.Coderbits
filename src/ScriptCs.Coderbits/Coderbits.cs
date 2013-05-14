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
            //Create WebClient for making request for profile
            var client = new WebClient();

            //Get profile response as a JSON string
            var jsonString = client.DownloadString(GetProfilePath(username));

            //Convert to JSON string to Coderbits model
            var coderbitsModel = JsonConvert.DeserializeObject<CoderbitsModel>(jsonString);

            //Return the model
            return coderbitsModel;
        }

        public async Task<CoderbitsModel> GetProfileAsync(string username)
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            //Get profile response as a JSON string
            var jsonStringTask = client.GetStringAsync(GetProfilePath(username));

            //Await
            var jsonString = await jsonStringTask;

            System.Threading.Thread.Sleep(10000);

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