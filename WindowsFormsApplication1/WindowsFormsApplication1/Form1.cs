﻿using Emgu.CV;
using Emgu.CV.Structure;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog Openfile = new OpenFileDialog();
            //if (Openfile.ShowDialog() == DialogResult.OK)
            //{
            // Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
            // pictureBox1.Image = My_Image.ToBitmap();
            //}
            string str = "d:\\lena.jpg";
            Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(str);
            pictureBox1.Image = My_Image.ToBitmap();
        }
    }
}
