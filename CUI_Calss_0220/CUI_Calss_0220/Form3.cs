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
                
                add1 = Int32.Parse(textBox1.Text);
                add2 = Int32.Parse(textBox2.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {
                MessageBox.Show("Try Catch結束");
            }
            label3.Text = (add1 + add2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int add7 = 0;
            int add8 = 0;
            try
            {
                
                add7 = Int32.Parse(textBox7.Text);
                add8 = Int32.Parse(textBox8.Text);
            }
            catch(SystemException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {
                MessageBox.Show("Try Catch結束");
            }
            label12.Text = (add7 / add8).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int add3 = 0;
            int add4 = 0;
            try
            {
                
                add3 = Int32.Parse(textBox3.Text);
                add4 = Int32.Parse(textBox4.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {
                MessageBox.Show("Try Catch結束");
            }
            label10.Text = (add3 - add4).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int add5 = 0;
            int add6 = 0;
            try
            {
                
                add5 = Int32.Parse(textBox5.Text);
                add6 = Int32.Parse(textBox6.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {
                MessageBox.Show("Try Catch結束");
            }
            label11.Text = (add5 * add6).ToString();
        }
    }
}

