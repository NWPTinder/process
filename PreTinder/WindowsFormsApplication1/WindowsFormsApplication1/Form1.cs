using Newtonsoft.Json;
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            string IINE_ID = ID_display.Text;
            contents_Control.OneUpUser((DateTime.Parse(IINE_ID)));
            //ランキング表示処理
            var JsonRanking = contents_Control.GetUserRanking();
            if (JsonRanking != null)
            {
                Bottom RankingData = JsonConvert.DeserializeObject<Bottom>(JsonRanking);
                dataGridView_Ranking.Rows.Clear();
                for (int Anumber = 0; Anumber < RankingData.tinderuserinfo.Count; Anumber++)
                {
                    string Sex = null;
                    if (RankingData.tinderuserinfo[Anumber].sex == true)
                    {
                        Sex = "男";
                    }
                    else
                    {
                        Sex = "女";
                    }

                    dataGridView_Ranking.Rows.Add(
                        RankingData.tinderuserinfo[Anumber].username, RankingData.tinderuserinfo[Anumber].age, Sex, RankingData.tinderuserinfo[Anumber].liked
                        );
                }
            }
            else
            {
                //Show message box
                MessageBox.Show(
                    "タイム・アウトしました。", "Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error
                    );
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
            var DisplayUser = contents_Control.GetDisplayUserName();
            if (DisplayUser != null)
            {
                Person json = JsonConvert.DeserializeObject<Person>(DisplayUser);
                Name_display.Text = json.username;
                Age_display.Text = json.age.ToString();
                Description_display.Text = json.whoami;
                ID_display.Text = json.id.ToString();
            }
            else
            {
                //Show message box
                MessageBox.Show(
                    "タイム・アウトしました。", "Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error
                    );
            }


            //ランキング表示処理
            var JsonRanking = contents_Control.GetUserRanking();
            if (JsonRanking != null)
            {
                Bottom RankingData = JsonConvert.DeserializeObject<Bottom>(JsonRanking);
                dataGridView_Ranking.Rows.Clear();
                for (int Anumber = 0; Anumber < RankingData.tinderuserinfo.Count; Anumber++)
                {
                    string Sex = null;
                    if (RankingData.tinderuserinfo[Anumber].sex == true)
                    {
                        Sex = "男";
                    }
                    else
                    {
                        Sex = "女";
                    }

                    dataGridView_Ranking.Rows.Add(
                        RankingData.tinderuserinfo[Anumber].username, RankingData.tinderuserinfo[Anumber].age, Sex, RankingData.tinderuserinfo[Anumber].liked
                        );
                }
            }
            else
            {
                //Show message box
                MessageBox.Show(
                    "タイム・アウトしました。", "Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Error
                    );
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var JsonRanking = contents_Control.GetUserRanking();
        }
    }
}
