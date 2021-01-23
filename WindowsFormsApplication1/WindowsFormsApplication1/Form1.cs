using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //RenewTopicPerson();

            // require a sent json
            Person SeterSignalPerson = new Person();
            SeterSignalPerson.SeterSignal("RenewDisplayname");
            var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
            Client FirtstC = new Client();
            FirtstC.Connect();    
            FirtstC.Send(SeterSignalPersonJson);
            System.Threading.Thread.Sleep(3000);
            
            var hoge = DisPlayName.username;
            //FirtstC.DisConnect();


            //if ((display_user = function.Get()) != null)
            //{
                Name_display.Text = DisPlayName.username;
                Age_display.Text = DisPlayName.age.ToString();
                Description_display.Text = DisPlayName.whoami;
                ID_display.Text = DisPlayName.id.ToString();
                //dataGridView_Ranking.DataSource = function.Get_Ranking();
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            string IINE_ID = ID_display.Text;
            Person display_user = new Person();
            if ((display_user = function.GET_IINE(IINE_ID)) != null)
            {
                Name_display.Text = display_user.username;
                Age_display.Text = display_user.age.ToString();
                Description_display.Text = display_user.whoami;
                ID_display.Text = display_user.id.ToString();
            } 
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
            Person display_user = new Person();
           
            if ((display_user = function.Get()) != null)
            {
                Name_display.Text = display_user.username;
                Age_display.Text = display_user.age.ToString();
                Description_display.Text = display_user.whoami;
                ID_display.Text = display_user.id.ToString();


                // require a sent json
                Person SeterSignalPerson = new Person();
                SeterSignalPerson.SeterSignal("RenewDisplayname");
                var SeterSignalPersonJson = SeterSignalPerson.IntoJson(SeterSignalPerson);
                Client FirtstC = new Client();
                FirtstC.Connect();
                FirtstC.Send(SeterSignalPersonJson);
                // System.Threading.Thread.Sleep(3000);

                var hoge = DisPlayName.username;
                //FirtstC.DisConnect();


                //if ((display_user = function.Get()) != null)
                //{
                Name_display.Text = DisPlayName.username;
                Age_display.Text = DisPlayName.age.ToString();
                Description_display.Text = DisPlayName.whoami;
                ID_display.Text = DisPlayName.id.ToString();
            }
            

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
        private void SetDisplyUserName()
        {
            
        }
    }
}
