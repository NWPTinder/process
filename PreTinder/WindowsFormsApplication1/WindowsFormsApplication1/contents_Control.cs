using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class contents_Control
    {
        public static string GetDisplayUserName()
        {
            //flag用データ作成
            Person SeterSignalPerson = new Person();
            //更新用flag
            SeterSignalPerson.Signal = "RenewDisplayname";
            //Bottom2Json
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);

            //コネクション確保
            Client FirtstC = new Client();
            FirtstC.Connect();
            //json型でflag送信
            FirtstC.Send(SeterSignalPersonJson);
            //
            string reply = FirtstC.ReveveMsg;
            return reply;
        }

    public static string GetUserRanking()
        {
            //flag用データ作成
            Person SeterSignalPerson = new Person();
            //更新用flag
            SeterSignalPerson.Signal = "Ranking";
            //Bottom2Json
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            //コネクション確保
            Client FirtstC = new Client();
            FirtstC.Connect();
            //json型でflag送信
            FirtstC.Send(SeterSignalPersonJson);
            var Msg = FirtstC.ReveveMsg;
            return Msg;
        }

    public static void OneUpUser(DateTime ID)
        {
            //flag用データ作成
            Person SeterSignalPerson = new Person();
            SeterSignalPerson.id = ID;
            //更新用flag
            SeterSignalPerson.Signal = "OneUPLike";
            //Bottom2Json
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            //コネクション確保
            Client FirtstC = new Client();
            FirtstC.Connect();
            //json型でflag送信
            FirtstC.Send(SeterSignalPersonJson);
        }

    public static void AddUser(Person InfoUser)
        {
            //flag用データ作成
            var SeterSignalPerson = InfoUser;
            //更新用flag
            SeterSignalPerson.id = DateTime.Now;
            SeterSignalPerson.Signal = "AddUser";
            //Bottom2Json
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            //コネクション確保
            Client FirtstC = new Client();
            FirtstC.Connect();
            //json型でflag送信
            FirtstC.Send(SeterSignalPersonJson);
        }


    }
}
