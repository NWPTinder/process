using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public static class function
    {
        public static void Post(Person singup_user)
        {

            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            string URL = "https://localhost:44346/api/default/Post/";
            //URL Setting
            client.BaseUrl = new Uri(URL);
            request.Method = Method.POST;
            var data = singup_user;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);
        }

        public static Person Get()
        {
            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            string URL = "https://localhost:44346/api/default/Getuser/";
            //URL Setting
            client.BaseUrl = new Uri(URL);
            request.Method = Method.GET;
            var response = client.Execute(request);
            bool isOK = response.StatusCode == HttpStatusCode.OK;
            Person aaa = new Person();
            
            aaa = JsonConvert.DeserializeObject<Person>(response.Content);
            return aaa;
        }

        public static Person GET_IINE(string ID)
        {
            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            string URL = "https://localhost:44346/api/default/Get_IINE/"+ "?ID=" + ID ;
            //URL Setting
            client.BaseUrl = new Uri(URL);
            request.Method = Method.GET;
            var response = client.Execute(request);
            bool isOK = response.StatusCode == HttpStatusCode.OK;
            Person aaa = new Person();

            aaa = JsonConvert.DeserializeObject<Person>(response.Content);
            return aaa;
        }

        public static DataSet Get_Ranking()
        {
            // Create Client&RestRequest
            var client = new RestClient();
            var request = new RestRequest();
            string URL = "https://localhost:44346/api/default/GetRanking/";
            //URL Setting
            client.BaseUrl = new Uri(URL);
            request.Method = Method.GET;
            var response = client.Execute(request);
            bool isOK = response.StatusCode == HttpStatusCode.OK;
            DataSet Ranking_info = new DataSet();

            Ranking_info = JsonConvert.DeserializeObject<DataSet>(response.Content);
            return Ranking_info;
        }


    }
}
