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
            Data iii = new Data();
            iii.UserName = textBox1.Text;
            iii.No = (int)numericUpDown1.Value;
            iii.Jusho = textBox2.Text;
            iii.Shumi = textBox3.Text;
            if (radioButton1 != null) iii.Type = true;
            function.Post(iii);
            this.Close();
        }

         
    }

    
}
