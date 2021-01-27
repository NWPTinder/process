using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


//using Windows.UI.Xaml.Controls;
using System.Windows;
using System.Text.Json;

namespace TinderConsoleServer
{
	public class SQL_oparations
	{
		static MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

		static DataSet TinderUserInfoDB = new DataSet(); // DBのすべての内容を格納する変数

		//private  DataSet RetriveWholeDB(object sender, EventArgs e)
		public static DataSet RetriveWholeDB()
		{
			//// MySQLへの接続
			try
			{
				// コネクション作成
				MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter(
				 "SELECT * FROM tinderuserinfo", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
				FirstAdapter.Fill(TinderUserInfoDB, "tinderuserinfo");
				
			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return TinderUserInfoDB;
		}

		//sign upして送られてきたデータをdatabaseに格納
		public static void INSERT_DATA(Person data)
		{
			try
			{
				// コネクション作成
				//コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				
				// コマンドを作成
				MySqlCommand cmd =
					new MySqlCommand("insert into tinderuserinfo values (@id, @username, @age, @sex, @whoami, @liked )", cn);
				// パラメータ設定
				// 実際には取得した値が入ります。
				cmd.Parameters.Add(new MySqlParameter("id", data.id)); // Primary key として時刻を選択
				cmd.Parameters.Add(new MySqlParameter("username", data.username));
				cmd.Parameters.Add(new MySqlParameter("age", data.age));
				cmd.Parameters.Add(new MySqlParameter("sex", data.sex)); // man : 1 woman : 0
				cmd.Parameters.Add(new MySqlParameter("whoami", data.whoami));
				cmd.Parameters.Add(new MySqlParameter("liked", data.liked));

				// オープン
				cmd.Connection.Open();
				// 実行
				cmd.ExecuteNonQuery();
				// クローズ
				cmd.Connection.Close();

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}
		}

		//ランキング情報を取得する関数
		//何人まで取得するか検討中
		public static string SELECT_Ranking()
		{
			string jsonstr = null;
			DataSet RankingByLike = new DataSet();
			try
			{
				// コネクション作成
				 //コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				
				// Likedが大きい順に並べて出力する
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter("SELECT * FROM tinderuserinfo ORDER BY liked DESC", cn);

				FirstAdapter.Fill(RankingByLike, "tinderuserinfo"); // 出力結果をDatasetに格納

				jsonstr = Newtonsoft.Json.JsonConvert.SerializeObject(RankingByLike);

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return jsonstr;
		}

		//データベースからランダムでSELECT
		public static DateTime SELECT_RND()
		{
			int Count = 0;
			Count = (int)RetriveWholeDB().Tables["tinderuserinfo"].Rows.Count;

			Random RandomNum = new System.Random();
			int Selector = RandomNum.Next(0, Count - 1);
			DateTime Selectedid = (DateTime)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["id"];
			var SelectedUserName = TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["username"];
			// ....
			Console.WriteLine(Selectedid); // 選ばれた人のidを出力

			return Selectedid;

		}

		//いいねをカウントアップする関数 defaultcontrollerから引数IDを取得して該当するデータを変更する。
		public static void INSERT_THUMBS(DateTime Datetimeid)
		{

			try
			{   // 特定の名前の人のLiked数をユーザ名(id)で取得する


				// コネクション作成
				 //コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				
				int LikeCount = 0; // 初期化
				RetriveWholeDB();
				//Console.WriteLine(TinderUserInfoDB.Tables["tinderuserinfo"].Rows[(int)1]["username"]);
				int i = 0;
				foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{
					
					var hoge = pRow["id"];
					if ((DateTime)pRow["id"] == Datetimeid)
					{
						LikeCount = (int)(pRow["liked"]);
						
						break;
						
					}
					i = i + 1;
				}

				// testというユーザのLikedを現在のいいね数+1に変更する処理
				// コマンドを作成
				MySqlCommand cmd = new MySqlCommand("update tinderuserinfo set liked=@liked where username=@username", cn);
				// パラメータ設定
			
				string username = (string)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[(i)]["username"];
				
				
				// IDだとうまく行かないためユーザ名での指定に変更する(粗悪なDBのせいで正常に動作する確立が低い)
				cmd.Parameters.Add(new MySqlParameter("username", username));
				int AfterLiked = LikeCount + 1;
				cmd.Parameters.Add(new MySqlParameter("liked", AfterLiked));
				// オープン
				cmd.Connection.Open();
				// 実行
				cmd.ExecuteNonQuery();
				// クローズ
				cmd.Connection.Close();

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}
		}

		// public static Person SELECT_user(DateTime outid) // コンフリクト修正のためコメントアウトさせていただきます
		public static Person SELECT_user(DateTime id)
		{

			var table = new DataTable();


			// コネクション作成
			/* コネクション作成を共通のものに変更してみる
			MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
			*/
			RetriveWholeDB();
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM tinderuserinfo", cn);
			// オープン
			cmd.Connection.Open();

			var adapter = new MySqlDataAdapter(cmd);
			adapter.Fill(table);
			// クローズ
			cmd.Connection.Close();
			var MaxRowCount = table.Rows.Count;
			Random Randomfanc = new System.Random();

			int RandomRowNum = (Randomfanc.Next(0, MaxRowCount + 1));
			table.TableName = "tinderusername";
			Person user = new Person();
			var OnePersonInfo = TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum];
			user.Seter((DateTime)OnePersonInfo["id"], (string)OnePersonInfo["username"], (int)OnePersonInfo["age"], (bool)OnePersonInfo["sex"], (string)OnePersonInfo["whoami"], (int)OnePersonInfo["liked"]);

			return user;
		}
	}

}