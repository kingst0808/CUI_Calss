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
            //MessageBox.Show("點擊3/13");
            Form form_Button = new Form_Button();
            form_Button.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form from_TextBox =new Form_TextBox();
            from_TextBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form HW_Form = new HW();
            HW_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form MidExam = new MidExam();
            MidExam.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new FormFinalGame();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form_TextBox();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form_TextBox();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form_3 = new Form3();
            form_3.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form_10 = new Form_checkbox();
            form_10.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form_10 = new FormLayout();
            form_10.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form_11 = new hw_timer();
            form_11.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form_12 = new panel();
            form_12.Show();
        }
    }
}
