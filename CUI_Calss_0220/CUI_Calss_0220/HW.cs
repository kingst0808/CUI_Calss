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
    public partial class HW : Form
    {
        public HW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = label1.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception e1)
            {
                label1.Text = "0";
            }

            //label2.Text =cout+"";
            label1.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String temp = label1.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) - 1;
            }
            catch (Exception e1)
            {
                label1.Text = "0";
            }

            //label2.Text =cout-"";
            label1.Text = count.ToString();
        }
    }
}
