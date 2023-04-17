using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUI_Calss_0220
{
    public partial class MidExam : Form
    {
        public MidExam()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(textBox1.Text);
            double f = c * (9 / 5.0) + 32;
            label3.Text = f.ToString() + "F"; 
        }
    }
}
