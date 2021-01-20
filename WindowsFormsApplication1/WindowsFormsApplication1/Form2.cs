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
            Person singup_user = new Person();
            singup_user.age = (int)Enter_age.Value;
            singup_user.username = Enter_name.Text;
            singup_user.whoami = Enter_description.Text;
            if (Select_male.Checked == true)
            {
                singup_user.sex = true;
            }
            else
            {
                singup_user.sex = false;
            }
 
            function.Post(singup_user);
            this.Close();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Person button1_Click_char  = new Person();
            button1_Click_char.Seter((long)Enter_age.Value, Enter_name.Text, 10, true, "hoge", 2);

            if (Select_male != null) button1_Click_char.Type = true;
            function.Post(button1_Click_char);
            this.Close();
        }
        */

    }

    
}
