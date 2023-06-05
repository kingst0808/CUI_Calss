﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CUI_Calss_0220
{
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
            File.WriteAllText("Temp.txt", "Hello Ya\n");
            File.AppendAllText("Temp.txt", "我是第二行\n");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";

            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    if (((CheckBox)c).Checked== true)
                    {
                        mainFood += c.Text + " ";
                    }
                }
            }
            MessageBox.Show("主食:" + mainFood);


            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideFood += c.Text + " ";
                    }
                }
            }
            MessageBox.Show("主食:" + mainFood+Environment.NewLine+"配菜"+sideFood);
        }
    }
}


