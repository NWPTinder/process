using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WebApplication1.Models;
using WebApplication1.Controllers;

//using Windows.UI.Xaml.Controls;
using System.Windows;

namespace Tinder
{
	public static class SQL_oparations
	{
		private static DataSet RetriveOderbyLike(object sender, EventArgs e)
		{
			// MySQLへの接続情報
			string server = "us-cdbr-east-02.cleardb.com";        // MySQLサーバホスト名
			string user = "bcc8a0e09211c7";           // MySQLユーザ名
			string pass = "f783a8d5";           // MySQLパスワード
			string database = "heroku_3c74537ac26405b";      // 接続するデータベース名
			string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, user, pass);
			DataSet TinderUserInfoDB = new DataSet();
			// MySQLへの接続
			try
			{
				// コネクション作成
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter(
				 "SELECT * FROM tinderuserinfo", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
				FirstAdapter.Fill(TinderUserInfoDB, "tinderuserinfo");
				// jsonに変換する場合
				String TinderUserInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(TinderUserInfoDB);
				DefaultController SentJson = new DefaultController();
				SentJson.Post(TinderUserInfoJson);



				//FillAllDataBese.Seter(); 
				//DataTable dt = new DataTable();
				//Console.WriteLine(TinderUserInfoDB.Tables["tinderuserinfo"].Rows[0]["age"]);
				/*foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{

					Console.WriteLine("{0}, {1}", pRow["age"], pRow["id"]);
				}
				*/



			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return TinderUserInfoDB;
		}

		//sign upして送られてきたデータをdatabaseに格納
		public static void INSERT_DATA(person data)
        {

        }

		//ランキング情報を取得する関数
		//何人まで取得するか検討中
		//返り値をstring(json)型にするか、person型にするか決定してません。
		public static void SELECT_RANK()
        {

        }


		//データベースからランダムでSELECT
		//ランダム関数を使ってIDを決定する。ランダム値は最古IDから最新IDの中で発生(自分のIDも含まれてしまう可能性もあるがそれはまた後で)
		public static void SELECT_RND()
        {

        }

		//いいねをカウントアップする関数 defaultcontrollerから引数IDを取得して該当するデータを変更する。
		public static void INSERT_THUMBS(int id)
        {
			//SQL conection
			//SQL 引数のID を使って 該当のデータのいいね数を+1でupdate 
        }

		//データベースとのコネクションを確立させる関数
		//あったほうがスッキリしそう。
		//作ったとしてそれぞれの関数内でconnectionをcloseするのをお忘れなく
		public static void CONNECTION()
        {

        }

	}
}
