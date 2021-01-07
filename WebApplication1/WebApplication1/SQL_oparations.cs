using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
	public class SQL_oparations
	{
		public static void conections()
        {
			// MySQLへの接続情報
			string server = "us-cdbr-east-02.cleardb.com";        // MySQLサーバホスト名
			string user = "bcc8a0e09211c7";           // MySQLユーザ名
			string pass = "f783a8d5";           // MySQLパスワード
			string database = "heroku_3c74537ac26405b";      // 接続するデータベース名
			string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, user, pass);
			// MySQLへの接続
			try
			{
				MySqlConnection connection = new MySqlConnection(connectionString);
				connection.Open();
				Console.WriteLine("MySQLに接続しました！");
				// 接続の解除
				connection.Close();
			}
			catch (MySqlException me)
			{
				Console.WriteLine("ERROR: " + me.Message);
			}


		}
    }
}