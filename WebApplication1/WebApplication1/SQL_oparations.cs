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

		public static void INSERT_DATA()
        {

        }

		public static void SERECT_RANK()
        {

        }

		public static void SERECT_()
        {

        }

		public static void INSERT_THUMBS()
        {

        }

	}
}
