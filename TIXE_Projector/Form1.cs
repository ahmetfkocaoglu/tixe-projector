using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShockwaveFlashObjects;
using AxShockwaveFlashObjects;

namespace TIXE_Projector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axShockwaveFlash1.Movie = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (axShockwaveFlash1.Movie != Application.StartupPath + @"\\temp.swf")
            {
                axShockwaveFlash1.Movie = Application.StartupPath + @"\\temp.swf";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (axShockwaveFlash1.Movie != Application.StartupPath + @"\\temp.swf" || axShockwaveFlash1.Movie != " ")
            {
                axShockwaveFlash1.Movie = " ";
            }
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + @"\\temp.swf";
        }
    }
}