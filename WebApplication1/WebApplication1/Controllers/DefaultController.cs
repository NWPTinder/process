using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

using WebApplication1.Models;
using Tinder;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default

        [HttpGet]
        /// <summary>
        /// パラメータのない GET メソッドに対応するメソッド 
        /// 更新がかかったときなどに適当なuserを取得
        /// 例：GET /api/default/GetUser
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetUser()
        {
            person test = new person();
            // person User = SQL_oparations.Select_user()
            test.id = 2001;
            test.username = "testname";
            test.age = 100;
            test.sex = true;
            test.whoami = "whoami";
            test.liked = 0;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(test);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return res;
        }



        /// <summary>
        /// id パラメータのある GETメソッドに対応するメソッド
        /// 例：/api/default/GetUser
        /// いいねされたときに使います。Getuserのパラメータにint型のIDが入力されたとき、該当のIDに対するカウントアップとランダムで別のIDuserを出力。
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetUser(int id)
        {
            {

                person Selection_id = new person();

                Selection_id.id = 2001;
                Selection_id.username = "testname";
                Selection_id.age = 100;
                Selection_id.sex = true;
                Selection_id.whoami = "whoami";
                Selection_id.liked = 0;

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Selection_id);
                HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(json, Encoding.UTF8, "application/json");

                return res;
            }
        }


        // POST: api/Default
        public HttpResponseMessage Post([FromBody] string value)
        {

            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(value);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(value, Encoding.UTF8, "application/json");
            return res;
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}