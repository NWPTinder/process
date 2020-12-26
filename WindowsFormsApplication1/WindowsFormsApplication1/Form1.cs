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
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 from2 = new Form2();
            from2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data uuu = function.Get();
            textBox5.Text = uuu.UserName;
            textBox6.Text = uuu.No.ToString();
        }
    }
}
