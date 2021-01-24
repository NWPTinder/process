using RestSharp;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Completion_button_Click(object sender, EventArgs e)
        {
            Bottom AddUser = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2018/05/01\",\"username\":\"AddUser\",\"age\":11,\"sex\":true,\"whoami\":\"wgafai\",\"liked\":0}]}";
            AddUser = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);

            AddUser.tinderuserinfo[0].Signal = "AddUser";
            AddUser.tinderuserinfo[0].id = DateTime.Now;
            AddUser.tinderuserinfo[0].age = (int)Enter_age.Value;
            AddUser.tinderuserinfo[0].username = Enter_name.Text;
            AddUser.tinderuserinfo[0].whoami = Enter_description.Text;
            if (Select_male.Checked == true)
            {
                AddUser.tinderuserinfo[0].sex = true;
            }
            else
            {
                AddUser.tinderuserinfo[0].sex = false;
            }

            SendAddUser(AddUser);
            //AddUser.tinderuserinfo[0];
            //function.Post(singup_user);
            this.Close();
        }

        // Randomで表示する人を更新する関数
        private void SendAddUser(Bottom AddUser)
        {

            // 初期化
            Bottom SeterSignalPerson = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2018/05/01\",\"username\":\"htaa\",\"age\":11,\"sex\":true,\"whoami\":\"wgafai\",\"liked\":12}]}";
            SeterSignalPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);

            var ResisteredUser = AddUser.tinderuserinfo[0];
            try
            {
                SeterSignalPerson.tinderuserinfo[0].Signal = "AddUser";
                SeterSignalPerson.tinderuserinfo[0].Seter(ResisteredUser.id, ResisteredUser.username, ResisteredUser.age, ResisteredUser.sex, ResisteredUser.whoami, ResisteredUser.liked);
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
        }


    }
}
