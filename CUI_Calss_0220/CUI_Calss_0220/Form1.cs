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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_buttonl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點擊3/13");
            Form Button_ = new Form_Button();
            Button_.Show();
        }
    }
}
