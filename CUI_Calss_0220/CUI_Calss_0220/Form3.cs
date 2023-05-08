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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int add1 = 0;
            int add2 = 0;
            try
            {
                MessageBox.Show("請輸入數字");
                add1 = 0;
                add2 = 0;
            }
            finally
            {
                MessageBox.Show("Try Catch結束");
            }
            label3.Text = (add1 + add2).ToString();
        }
    }
}

