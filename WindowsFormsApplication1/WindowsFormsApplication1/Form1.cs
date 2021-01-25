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
       
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            Bottom SeterSignalPerson = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2020/01/01\",\"username\":\"OneUPLike\",\"age\":0,\"sex\":true,\"whoami\":\"OneUPLike\",\"liked\":0}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);

            SeterSignalPerson.tinderuserinfo[0].SeterSignal("OneUPLike");
            SeterSignalPerson.tinderuserinfo[0].Seter(DisPlayName.id, DisPlayName.username, DisPlayName.age, DisPlayName.sex, DisPlayName.whoami, DisPlayName.liked);
            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
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
        ///　
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_button_Click(object sender, EventArgs e)
        {
            SetDisplyUserName();
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
        private async void SetDisplyUserName()
        {

            // require a sent json
            Bottom SeterSignalPerson = new Bottom();
            Person hoge = new Person();
            //SeterSignalPerson.tinderuserinfo[0].username = "hoge";
            //Person SeterSignalPerson = new Person();
            var aaa = DateTime.Now;
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2020/01/01\",\"username\":\"RenewDisplayname\",\"age\":0,\"sex\":true,\"whoami\":\"RenewDisplayname\",\"liked\":0}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);
            
            try
            {
                SeterSignalPerson.tinderuserinfo[0].Signal = "RenewDisplayname";
            }
            catch
            {
                Console.WriteLine("NULL");
            }

            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            //var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);
            Refresh();
            // DB からデータを取得するまで時間がかかるのでDelayを入れて調整する
            await Task.Delay(2000);
            //SetDisplyUserName();
            Refresh();
            Name_display.Text = DisPlayName.username;
            Age_display.Text = DisPlayName.age.ToString();
            Description_display.Text = DisPlayName.whoami;
            ID_display.Text = DisPlayName.id.ToString();
            Refresh();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // 表の初期化
            //dataGridView_Ranking.Columns.Clear();
            dataGridView_Ranking.Rows.Clear();

            // カラム数を指定
            dataGridView_Ranking.ColumnCount = 3;

            // カラム名を指定
            dataGridView_Ranking.Columns[0].HeaderText = "名前";
            dataGridView_Ranking.Columns[1].HeaderText = "年齢";
            dataGridView_Ranking.Columns[2].HeaderText = "いいね";


        }

        private void dataGridView_Ranking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRanking();

        }
        private async void GetRanking() 
        {
            // require a sent json
            Bottom SeterSignalPerson = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2020/01/01\",\"username\":\"RenewDisplayname\",\"age\":0,\"sex\":true,\"whoami\":\"RenewDisplayname\",\"liked\":0}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);
            SeterSignalPerson.tinderuserinfo[0].SeterSignal("Ranking");

            var SeterSignalPersonJson = Newtonsoft.Json.JsonConvert.SerializeObject(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();
            FirtstC.Send(SeterSignalPersonJson);

            Refresh();
            // DB からデータを取得するまで時間がかかるのでDelayを入れて調整する
            await Task.Delay(2000);

            // データを追加
            dataGridView_Ranking.Rows.Clear();
            dataGridView_Ranking.Rows.Add(Ranking.username1, Ranking.age1, Ranking.liked1);
            dataGridView_Ranking.Rows.Add(Ranking.username2, Ranking.age2, Ranking.liked2);
            dataGridView_Ranking.Rows.Add(Ranking.username3, Ranking.age3, Ranking.liked3);
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRanking();
        }

        private async void RefreshDisplyaName()
        {
            await Task.Delay(500);
            Name_display.Text = DisPlayName.username;
            Age_display.Text = DisPlayName.age.ToString();
            Description_display.Text = DisPlayName.whoami;
            ID_display.Text = DisPlayName.id.ToString();
            
        }
    }

}

