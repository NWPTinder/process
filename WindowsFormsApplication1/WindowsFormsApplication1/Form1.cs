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



        //Thumbup to server
        private void Thumbup_button_Click(object sender, EventArgs e)
        {
            function.Get();
        }

        //singup 
        private void Registration_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {

        }
    }
}
