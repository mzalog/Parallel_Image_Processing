using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Parallel_Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    Bitmap originalImage = new Bitmap(filePath);
                    pictureBoxOriginal.Image = originalImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
        }


        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                Bitmap originalImage = new Bitmap(pictureBoxOriginal.Image);
                ApplyFilters(originalImage);
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private void ApplyFilters(Bitmap originalImage)
        {
            Bitmap grayScale = (Bitmap)originalImage.Clone();
            Bitmap negative = (Bitmap)originalImage.Clone();
            Bitmap threshold = (Bitmap)originalImage.Clone();
            Bitmap mirror = (Bitmap)originalImage.Clone();

            Parallel.Invoke(
                () => ImageFilters.ConvertToGrayscale(grayScale),
                () => ImageFilters.ApplyNegative(negative),
                () => ImageFilters.ApplyThreshold(threshold, 128),
                () => ImageFilters.ApplyMirrorEffect(mirror)
            );

            pictureBoxGray.Image = grayScale;
            pictureBoxNegative.Image = negative;
            pictureBoxThreshold.Image = threshold;
            pictureBoxMirror.Image = mirror;
        }
        private void ButtonProcessThreads_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                Bitmap originalImage = new Bitmap(pictureBoxOriginal.Image);
                ThreadFilterImages(originalImage);
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private void ThreadFilterImages(Bitmap originalImage)
        {
            Bitmap grayScale = (Bitmap)originalImage.Clone();
            Bitmap negative = (Bitmap)originalImage.Clone();
            Bitmap threshold = (Bitmap)originalImage.Clone();
            Bitmap mirror = (Bitmap)originalImage.Clone();

            Thread grayThread = new Thread(() => ImageFilters.ConvertToGrayscale(grayScale));
            Thread negativeThread = new Thread(() => ImageFilters.ApplyNegative(negative));
            Thread thresholdThread = new Thread(() => ImageFilters.ApplyThreshold(threshold, 128));
            Thread mirrorThread = new Thread(() => ImageFilters.ApplyMirrorEffect(mirror));

            grayThread.Start();
            negativeThread.Start();
            thresholdThread.Start();
            mirrorThread.Start();

            grayThread.Join();
            negativeThread.Join();
            thresholdThread.Join();
            mirrorThread.Join();

            this.Invoke((MethodInvoker)delegate
            {
                pictureBoxGray.Image = grayScale;
                pictureBoxNegative.Image = negative;
                pictureBoxThreshold.Image = threshold;
                pictureBoxMirror.Image = mirror;
            });
        }


    }
}
