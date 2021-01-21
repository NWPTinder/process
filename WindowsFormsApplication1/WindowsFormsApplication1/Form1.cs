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
            display_user = function.Get();
            Name_display.Text = display_user.username;
            Age_display.Text = display_user.age.ToString();
            Description_display.Text = display_user.whoami;
            ID_display.Text = display_user.id.ToString();

            dataGridView_Ranking.DataSource = function.Get_Ranking();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            int IINE_ID = Convert.ToInt32(ID_display.Text);
            Person display_user = new Person();
            display_user = function.GET_IINE(IINE_ID);
            Name_display.Text = display_user.username;
            Age_display.Text = display_user.age.ToString();
            Description_display.Text = display_user.whoami;
            ID_display.Text = display_user.id.ToString();
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
            display_user = function.Get();
            Name_display.Text = display_user.username;
            Age_display.Text = display_user.age.ToString();
            Description_display.Text = display_user.whoami;
            ID_display.Text = display_user.id.ToString();
        }


    }
}
