using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// フォーム展開時、ランダムなUser表示
        /// &ランキング更新
        /// </summary>
        /// 
        static string hoge;
        public Form1()
        {
            InitializeComponent();
            Person display_user = new Person();
            SetDisplyUserName();
            
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            Person SeterSignalPerson = new Person();
            SeterSignalPerson.SeterSignal("OneUPLike");
            SeterSignalPerson.Seter(DisPlayName.id, DisPlayName.username, DisPlayName.age, DisPlayName.sex, DisPlayName.whoami, DisPlayName.liked);
            var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);

        }

        /// <summary>
        /// User登録画面の展開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registration_button_Click(object sender, EventArgs e)
        {
            Form2 Regist_page = new Form2();
            Regist_page.Show();
        }

        /// <summary>
        ///　ランダムなUserを出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_button_Click(object sender, EventArgs e)
        {
            //SetDisplyUserName();
            GetRanking();
            dataGridView_Ranking.Refresh();

        }

        public void RenewTopicPerson()
        {
            SocketClient.SendMsgSeter("RenewTopicPerson");
            SocketClient.SoketMain();
        }

        private void Description_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_display_TextChanged(object sender, EventArgs e)
        {

        }
        // Randomで表示する人を更新する関数
        private void SetDisplyUserName()
        {


            // require a sent json
            Bottom SeterSignalPerson = new Bottom();
            Person hoge = new Person();
            //SeterSignalPerson.tinderuserinfo[0].username = "hoge";
            //Person SeterSignalPerson = new Person();
            var aaa = DateTime.Now;
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2018/05/01\",\"username\":\"htaa\",\"age\":11,\"sex\":true,\"whoami\":\"wgafai\",\"liked\":12}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);

            try
            {
                SeterSignalPerson.tinderuserinfo[0].Signal = "RenewDisplayname";
            }
            catch
            {
                Console.WriteLine("NULL");
            }

            //SeterSignalPerson.SeterSignal("RenewDisplayname");
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            //var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);


            //if ((display_user = function.Get()) != null)
            //{
            Name_display.Text = DisPlayName.username;
            Age_display.Text = DisPlayName.age.ToString();
            Description_display.Text = DisPlayName.whoami;
            ID_display.Text = DisPlayName.id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表の初期化
            //dataGridView_Ranking.Columns.Clear();
            dataGridView_Ranking.Rows.Clear();

            GetRanking();
            // カラム数を指定
            dataGridView_Ranking.ColumnCount = 3;

            // カラム名を指定
            dataGridView_Ranking.Columns[0].HeaderText = "名前";
            dataGridView_Ranking.Columns[1].HeaderText = "年齢";
            dataGridView_Ranking.Columns[2].HeaderText = "いいね";


        }

        private void dataGridView_Ranking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  

        }
        private void GetRanking() 
        {
            // require a sent json
            Bottom SeterSignalPerson = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2018/05/01\",\"username\":\"htaa\",\"age\":11,\"sex\":true,\"whoami\":\"wgafai\",\"liked\":12}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);
            SeterSignalPerson.tinderuserinfo[0].SeterSignal("Ranking");

            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);

            // データを追加
            dataGridView_Ranking.Rows.Clear();
            //var hoge = Ranking.rogi[0].id.ToString();
            dataGridView_Ranking.Rows.Add(Ranking.username1, Ranking.age1, Ranking.liked1);
            dataGridView_Ranking.Rows.Add(Ranking.username2, Ranking.age2, Ranking.liked2);
            dataGridView_Ranking.Rows.Add(Ranking.username3, Ranking.age3, Ranking.liked3);
        }

    }
}
