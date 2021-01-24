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
        public Form1()
        {
            InitializeComponent();
            Person display_user = new Person();
            
            if((display_user = function.Get()) != null)
            {
                Name_display.Text = display_user.username;
                Age_display.Text = display_user.age.ToString();
                Description_display.Text = display_user.whoami;
                ID_display.Text = display_user.id.ToString();
                var Ranking_Dataset = function.Get_Ranking();
                DataTable Ranking_Table = new DataTable();
                Ranking_Table = Ranking_Dataset.Tables["tinderuserinfo"];
                dataGridView_Ranking.DataSource = Ranking_Table;
            }
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
                var Ranking_Dataset = function.Get_Ranking();
                DataTable Ranking_Table = new DataTable();
                Ranking_Table = Ranking_Dataset.Tables["tinderuserinfo"];
                dataGridView_Ranking.DataSource = Ranking_Table;
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
                var Ranking_Dataset = function.Get_Ranking();
                DataTable Ranking_Table = new DataTable();
                Ranking_Table = Ranking_Dataset.Tables["tinderuserinfo"];
                dataGridView_Ranking.DataSource = Ranking_Table;
            }
            

        }


    }
}
