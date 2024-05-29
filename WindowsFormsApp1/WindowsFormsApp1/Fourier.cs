using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;


namespace WindowsFormsApp1
{
    public partial class Fourier : Form
    {
        System.Drawing.Image originalImage;
        public Fourier()
        {
            InitializeComponent();
        }

        private void SelectImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    image.Image = System.Drawing.Image.FromFile(selectedImagePath);
                    originalImage = image.Image;
                }
            }
        }


        private void ConvertFFT(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                SetErrorText();
                return;
            }
            ResetErrorText();
            var grayScaleImage = ResizeToPowerOfTwo(ConvertToGrayScale(new Bitmap(originalImage)));

            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(grayScaleImage);
            ComplexImage complexImage = ComplexImage.FromBitmap(grayImage);
            complexImage.ForwardFourierTransform();
            Bitmap magnitudeImage = complexImage.ToBitmap();
            image.Image = magnitudeImage;
        }
        private void SetErrorText()
        {
            result.Text = "Choose an image first!";
            result.ForeColor = Color.Red;
        }

        private void ResetErrorText()
        {
            result.Text = "";
            result.ForeColor = Color.Black;
        }


        private Bitmap ConvertToGrayScale(Bitmap image)
        {
            Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int grayValue = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayscaleImage.SetPixel(x, y, grayColor);
                }
            }

            return grayscaleImage;
        }

        public Bitmap ResizeToPowerOfTwo(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;

            int newWidth = GetNearestPowerOfTwo(width);
            int newHeight = GetNearestPowerOfTwo(height);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private int GetNearestPowerOfTwo(int value)
        {
            int powerOfTwo = (int)Math.Pow(2, (int)Math.Ceiling(Math.Log(value, 2)));
            return powerOfTwo;
        }
    }
}
