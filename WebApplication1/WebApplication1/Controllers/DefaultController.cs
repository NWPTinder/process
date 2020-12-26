using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        [HttpGet]
        [Route("Def")]
        //public HttpResponseMessage Get()
        public HttpResponseMessage Def()
        {
            Data data = new Data();
            data.UserName = "aaa";
            data.No = 1;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8,"application/json");
            return res;
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public HttpResponseMessage Post([FromBody]  Data value)
        {

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(value);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return res;
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
