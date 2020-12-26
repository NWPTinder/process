using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public static class function
    {
        public static void Post(Data aaa)
        {

            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            //URL Setting
            client.BaseUrl = new Uri("https://localhost:44346/api/Default");
            request.Method = Method.POST;
            var data = aaa;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);
        }

        public static Data Get()
        {
            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            //URL Setting
            client.BaseUrl = new Uri("https://localhost:44346/Def");
            request.Method = Method.GET;
            var response = client.Execute(request);
            bool isOK = response.StatusCode == HttpStatusCode.OK;
            Data aaa = new Data();
            aaa = JsonConvert.DeserializeObject<Data>(response.Content);
            return aaa;
        }
    }
}
