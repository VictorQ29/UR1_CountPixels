using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CountPixel
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            thresholdTrackBar.Value = _threshold;
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                int newHeight = (frame.Size.Height * emguPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(emguPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);
                emguPictureBox.Image = frame.Bitmap;


                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                binaryPictureBox.Image = binaryFrame.Bitmap;

                
                Image<Gray, byte> binaryImage = binaryFrame.ToImage<Gray, byte>();
                
                List<int> PixelCount = new List<int>(); //list for the 7 slices
                int SliceWidth = binaryFrame.Width / 7;


                for (int slice = 0; slice < 7; slice++)
                {
                    int SliceXcoordinate = SliceWidth * slice;
                    PixelCount.Add(0);
                    for (int x = SliceXcoordinate; x < (SliceXcoordinate) + SliceWidth; x++) 
                    {
                        for (int y = 0; y < binaryImage.Height; y++)
                        {
                            if (binaryImage.Data[y, x, 0] == 255)
                                PixelCount[slice]++;
                        }
                    }
                }

                Invoke(new Action(() =>
                {
                    PixelCountLabel1.Text = $"{PixelCount[0]}";
                    PixelCountLabel2.Text = $"{PixelCount[1]}";
                    PixelCountLabel3.Text = $"{PixelCount[2]}";
                    PixelCountLabel4.Text = $"{PixelCount[3]}";
                    PixelCountLabel5.Text = $"{PixelCount[4]}";
                    PixelCountLabel6.Text = $"{PixelCount[5]}";
                    PixelCountLabel7.Text = $"{PixelCount[6]}";
                }));

                

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            _threshold = thresholdTrackBar.Value;
        }
        
    }
}