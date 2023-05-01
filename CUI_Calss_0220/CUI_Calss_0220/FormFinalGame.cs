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
    public partial class FormFinalGame : Form
    {
        public FormFinalGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();//宣告一個 Random 物件:r
            MessageBox.Show(r.Next().ToString());
            Console.WriteLine(r.Next().ToString());
            Console.WriteLine(r.Next(100).ToString());
            Console.WriteLine(r.Next(-20, -10));
        }

        private void button_2_Click(object sender, EventArgs e)
        {

        }
    }
}
