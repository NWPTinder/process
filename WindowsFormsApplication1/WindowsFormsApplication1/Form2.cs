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

        private void button1_Click(object sender, EventArgs e)
        {
            Data button1_Click_char  = new Data();
            button1_Click_char.Seter((long)Enter_age.Value, Enter_name.Text, 10, true, "hoge", 2);

            if (Select_male != null) button1_Click_char.Type = true;
            function.Post(button1_Click_char);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
