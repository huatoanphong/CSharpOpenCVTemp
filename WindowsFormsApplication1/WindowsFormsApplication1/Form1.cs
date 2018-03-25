using Emgu;
using Emgu.CV;
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
        public bool isCheckBrowser = false;
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgOutput;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                    imgbInput.Image = imgInput;
                    imgbInput.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
                    isCheckBrowser = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (isCheckBrowser)
            {
                imgOutput = imgInput.Convert<Gray, byte>();
                pazOutput.Image = imgOutput.Bitmap;

                
            }
            else
            {
                MessageBox.Show("Not Browser Image!");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHbInput_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { imgInput[0] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            hbInput.AddHistogram("Blue Channel HistoGram", Color.Blue, m, 256, new float[] { 0, 256 });
            hbInput.Refresh();
        }

        private void btnHbOutput_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { imgOutput[0] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            hbOutput.AddHistogram("Gray Channel HistoGram", Color.Blue, m, 256, new float[] { 0, 256 });
            hbOutput.Refresh();
        }
    }
}
