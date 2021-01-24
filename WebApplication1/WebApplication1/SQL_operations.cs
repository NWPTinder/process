<<<<<<< HEAD
﻿using System;
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
	public class SQL_oparations
	{
		static readonly MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
		static DataSet TinderUserInfoDB = new DataSet(); // DBのすべての内容を格納する変数

		public static DataSet RetriveWholeDB()
		{
			//// MySQLへの接続
			try
			{
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter("SELECT * FROM tinderuserinfo", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
				FirstAdapter.Fill(TinderUserInfoDB, "tinderuserinfo");
				// jsonに変換する場合
				String TinderUserInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(TinderUserInfoDB);
				DefaultController SentJson = new DefaultController();
				// SentJson.Post(TinderUserInfoJson);

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
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

				// コマンドを作成
				MySqlCommand cmd =
					new MySqlCommand("insert into tinderuserinfo values (@id, @username, @age, @sex, @whoami, @liked )", cn);
				// パラメータ設定
				// 実際には取得した値が入ります。
				cmd.Parameters.Add(new MySqlParameter("id", DateTime.Now)); // Primary key として時刻を選択
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
		//返り値をstring(json)型にするか、person型にするか決定してません。
		// person型にするならコレクションとかを使ってperson型の配列のような物を作るのがよいかと思います。
		public static DataSet SELECT_Ranking()
		{
			DataSet RankingByLike5 = new DataSet();
			try
			{
				// Likedが大きい順に並べて上位5人まで出力する
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter("SELECT * FROM tinderuserinfo ORDER BY liked DESC LIMIT 5", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;

				FirstAdapter.Fill(RankingByLike5, "tinderuserinfo"); // 出力結果をDatasetに格納
				// とりあえず、Dataset型にしておいたのでPerson型にするかjsonにするかお任せします。 
			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return RankingByLike5;
		}


		//データベースからランダムでSELECT
		//ランダム関数を使ってIDを決定する。ランダム値は最古IDから最新IDの中で発生(自分のIDも含まれてしまう可能性もあるがそれはまた後で)
		public static DateTime SELECT_RND()
		{
			int Count = 0;
			Count = (int)RetriveWholeDB().Tables["tinderuserinfo"].Rows.Count;

			Random RandomNum = new System.Random();
			int Selector = RandomNum.Next(0, Count - 1);
			DateTime Selectedid = (DateTime)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["id"];
			var SelectedUserName = TinderUserInfoDB.Tables["tinderuserinfo"].Rows[Selector]["username"];
			// ....
			return Selectedid;

		}

		//いいねをカウントアップする関数 defaultcontrollerから引数IDを取得して該当するデータを変更する。
		public static void INSERT_THUMBS(DateTime Datetimeid)
		{
			//SQL conection
			//SQL 引数のID を使って 該当のデータのいいね数を+1でupdate 
			//SQL conection

			try
			{   // 特定の名前の人の言い値数をユーザ名(できたらid)で取得する

				int LikeCount = 0; // 初期化
				RetriveWholeDB();
				foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{
					var hoge = pRow["id"];
					if ((DateTime)pRow["id"] == Datetimeid)
					{
						LikeCount = (int)(pRow["liked"]);
						break;
					}
				}


				// testというユーザの言い値を現在のいいね数+1に変更する処理
				// コマンドを作成
				MySqlCommand cmd = new MySqlCommand("update tinderuserinfo set liked=@liked where id=@datetimeidid", cn);
				// パラメータ設定
				cmd.Parameters.Add(new MySqlParameter("datetimeidid", Datetimeid));
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

		public static Person SELECT_user(DateTime outid)
		{

			var table = new DataTable();


			// コネクション作成
			MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
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

=======
﻿using System;
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
	public class SQL_oparations
	{
		// エラー処理ができないが、簡潔に書ける
		static readonly MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

		static DataSet TinderUserInfoDB = new DataSet(); // DBのすべての内容を格納する変数

		//private  DataSet RetriveWholeDB(object sender, EventArgs e)
		public static DataSet RetriveWholeDB()
		{
			//// MySQLへの接続
			try
			{
				// コネクション作成
				/* コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				*/
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter(
				 "SELECT * FROM tinderuserinfo", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;
				FirstAdapter.Fill(TinderUserInfoDB, "tinderuserinfo");
				// jsonに変換する場合
				String TinderUserInfoJson = Newtonsoft.Json.JsonConvert.SerializeObject(TinderUserInfoDB);
				DefaultController SentJson = new DefaultController();
				// SentJson.Post(TinderUserInfoJson);

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
				/* コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				*/
				// コマンドを作成
				MySqlCommand cmd =
					new MySqlCommand("insert into tinderuserinfo values (@id, @username, @age, @sex, @whoami, @liked )", cn);
				// パラメータ設定
				// 実際には取得した値が入ります。
				cmd.Parameters.Add(new MySqlParameter("id", DateTime.Now)); // Primary key として時刻を選択
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
		//返り値をstring(json)型にするか、person型にするか決定してません。
		// person型にするならコレクションとかを使ってperson型の配列のような物を作るのがよいかと思います。
		public static DataSet SELECT_Ranking()
		{
			DataSet RankingByLike5 = new DataSet();
			try
			{
				// コネクション作成
				/* コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection(
				 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				*/
				// Likedが大きい順に並べて上位5人まで出力する
				MySqlDataAdapter FirstAdapter = new MySqlDataAdapter("SELECT * FROM tinderuserinfo ORDER BY liked DESC LIMIT 5", cn);
				// SELECT* FROM tinderuserinfo ORDER BY liked DESC LIMIT 3;

				FirstAdapter.Fill(RankingByLike5, "tinderuserinfo"); // 出力結果をDatasetに格納

				// とりあえず、Dataset型にしておいたのでPerson型にするかjsonにするかお任せします。 

			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}

			return RankingByLike5;
		}


		//データベースからランダムでSELECT
		//ランダム関数を使ってIDを決定する。ランダム値は最古IDから最新IDの中で発生(自分のIDも含まれてしまう可能性もあるがそれはまた後で)
		public static DateTime SELECT_RND()
		{
			int Count = 0;
			Count = (int)RetriveWholeDB().Tables["tinderuserinfo"].Rows.Count;

			// idのリストを生成
			//List<DateTime> IDs = new List<DateTime>();
			//foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
			//{
			//	IDs.Add((DateTime)pRow["id"]);
			//}

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
			//SQL conection
			//SQL 引数のID を使って 該当のデータのいいね数を+1でupdate 
			//SQL conection

			try
			{   // 特定の名前の人の言い値数をユーザ名(できたらid)で取得する


				// コネクション作成
				/* コネクション作成を共通のものに変更してみる
				MySqlConnection cn = new MySqlConnection("Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");
				*/
				int LikeCount = 0; // 初期化
				RetriveWholeDB();
				Console.WriteLine(TinderUserInfoDB.Tables["tinderuserinfo"].Rows[(int)1]["username"]);
				foreach (DataRow pRow in TinderUserInfoDB.Tables["tinderuserinfo"].Rows)
				{
					var hoge = pRow["id"];
					if ((DateTime)pRow["id"] == Datetimeid)
					{
						LikeCount = (int)(pRow["liked"]);
						break;
					}
				}


				// testというユーザの言い値を現在のいいね数+1に変更する処理
				// コマンドを作成
				MySqlCommand cmd = new MySqlCommand("update tinderuserinfo set liked=@liked where id=@datetimeidid", cn);
				// パラメータ設定
				cmd.Parameters.Add(new MySqlParameter("datetimeidid", Datetimeid));
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
			//cmd.Parameters.Add(new MySqlParameter("id", id)); // Primary key として時刻を選択
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
			//user.id = (DateTime)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum]["id"];
			//user.username = (string)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum]["username"];
			//user.age = (int)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum]["age"];
			//user.sex = true;
			//user.whoami = (string)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum]["whoami"];
			//user.liked = (int)TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum]["liked"];
			var OnePersonInfo = TinderUserInfoDB.Tables["tinderuserinfo"].Rows[RandomRowNum];
			user.Seter((DateTime)OnePersonInfo["id"], (string)OnePersonInfo["username"], (int)OnePersonInfo["age"], (bool)OnePersonInfo["sex"], (string)OnePersonInfo["whoami"], (int)OnePersonInfo["liked"]);


			return user;
		}

		// エラー処理をする接続
		//public static void ConnectDB()
		//{
		//	//// MySQLへの接続
		//	try
		//	{
		//		// コネクション作成
		//		MySqlConnection cn = new MySqlConnection(
		//		 "Data Source=us-cdbr-east-02.cleardb.com;Database=heroku_3c74537ac26405b;User ID=bcc8a0e09211c7;password=f783a8d5");

		//	}
		//	catch (MySqlException me)
		//	{
		//		Console.WriteLine("ERROR: " + me.Message);
		//	}

		//}
	}

}

>>>>>>> c4051c1af5d1cd4ef07c583f60fb75253c83c96d
