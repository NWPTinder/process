using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
            //DataSet Ranking_info = new DataSet();
            //SQL_oparations.SELECT_RANK();
            

            person test = new person();
            // person User = SQL_oparations.Select_user()
            test.id = 2001;
            test.username = "testname";
            test.age = 100;
            test.sex = true;
            test.whoami = "こんにちわこんにちわこんち庭こんわちわ";
            test.liked = 0;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(test);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return res;
        }



        /// <summary>
        /// id パラメータのある GETメソッドに対応するメソッド
        /// 例：/api/default/GetUser/5
        /// いいねされたときに使います。Getuserのパラメータにint型のIDが入力されたとき、該当のIDに対するカウントアップとランダムで別のIDuserを出力。
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetUser(int id)
        {
            {

                person Selection_id = new person();

                Selection_id.id = 5555;
                Selection_id.username = "name";
                Selection_id.age = 123;
                Selection_id.sex = true;
                Selection_id.whoami = "45682";
                Selection_id.liked = 0;

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Selection_id);
                HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
                res.Content = new StringContent(json, Encoding.UTF8, "application/json");

                return res;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetRanking()
        {
            //DataSet Ranking_info = new DataSet();
            //SQL_oparations.SELECT_RANK();
            DataSet Ranking_info = SQL_oparations.SELECT_Ranking();

            /*
            person test = new person();
            // person User = SQL_oparations.Select_user()
            test.id = 2001;
            test.username = "testname";
            test.age = 100;
            test.sex = true;
            test.whoami = "こんにちわこんにちわこんち庭こんわちわ";
            test.liked = 0;
            */
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Ranking_info);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return res;
        }


        // POST: api/Default

        /// <summary>
        /// 例：/api/default/Post
        /// </summary>
        /// <param name="singup_user"></param>
        /// <returns></returns>
        public void Post([FromBody] person singup_user)
        {

            SQL_oparations.INSERT_DATA(singup_user);
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