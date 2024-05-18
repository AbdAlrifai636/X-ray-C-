using Emgu.CV.Flann;
using MathNet.Numerics.Distributions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection.PortableExecutable;

namespace NewProject


{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        Point LocationXY;//start
        Point LocationX1Y1;//end
        bool isPressed = false; //to know move of mouse 
        String inputImage;
        // String outImage;
        int R;
        int G;
        int B;


        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void chooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Image!";
            //  ofd.InitialDirectory = "c:\\";
            // ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Filter = "PNG & JPG images|*.png;*.jpg";
            ofd.ShowDialog();
            inputImage = ofd.FileName;

            //«·€«¡ 
            FileStream fs = File.Open(inputImage, FileMode.Open);
            Bitmap bmp = new Bitmap(fs);
            fs.Close();
            picInput.Image = bmp;
            //bmp.Save(inputImage);

        }
        private void picInput_Click(object sender, EventArgs e)
        {
            AllowDrop = true;

        }

        private void picInput_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            LocationXY = e.Location;
        }

        private void picInput_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPressed == true)
            {
                LocationX1Y1 = e.Location;
                isPressed = false;
                if (rectangle != null)
                {
                    Bitmap bmpNew = new Bitmap(picInput.Image, picInput.Width, picInput.Height);//image procces

                    //to crop pic******************
                    //Bitmap imageProcces = new Bitmap(picInput.Image, rectangle.Width, rectangle.Height);
                    // Graphics g = Graphics.FromImage(imageProcces);
                    //g.DrawImage(bmpNew, 0, 0, rectangle, GraphicsUnit.Pixel);


                    //Color newColor = Color.Green;
                    Color pixelColor;
                    int r;
                    int g;
                    int b;

                    int total;


                    for (int i = LocationXY.X; i < LocationX1Y1.X; i++)
                    {
                        for (int j = LocationXY.Y; j < LocationX1Y1.Y; j++)
                        {
                            pixelColor = bmpNew.GetPixel(i, j);
                            r = pixelColor.R;
                            g = pixelColor.G;
                            b = pixelColor.B;
                            total = r + g + b;
                            if (total > 220 && total < 255)
                            {
                                bmpNew.SetPixel(i, j, Color.FromArgb(r, Color.Red));
                            }
                            else if (total > 50 && total < 220)
                            {
                                bmpNew.SetPixel(i, j, Color.FromArgb(g, Color.Green));
                            }
                            else if (total < 50 && total > 0)
                            {
                                bmpNew.SetPixel(i, j, Color.FromArgb(g, Color.Green));
                            }
                            else
                            {
                                bmpNew.SetPixel(i, j, Color.FromArgb(g, Color.Green));
                            }
                            Console.WriteLine("total is : " + total);
                        }
                        total = 0;
                    }
                    //  bmpNew =  MakeChromaChange(imageProcces, Color.Red, 110);
                    // picOutput.Image = bmpNew;
                    bmp = bmpNew;
                    // bmpNew.Save(inputImage);  
                }


            }
        }

        private void picInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Choose your path to save your image!";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = "unkown.jpg"; // Set default extension to JPG
                sfd.Filter = "JPG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png"; // Allow PNG and JPG formats

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string str = sfd.FileName;
                    try
                    {
                        //bmp.Save(str);
                        bmp.Save(str, ImageFormat.Jpeg); // Save as JPG by default
                        MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please load an image first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picInput_Paint(object sender, PaintEventArgs e)
        {
            if (rectangle != null)
            {
                e.Graphics.DrawRectangle(Pens.Yellow, GetRect());
            }
        }
        private Rectangle GetRect()
        {

            rectangle = new Rectangle();
            rectangle.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rectangle.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rectangle.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rectangle.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rectangle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogColor = colorOfImage.ShowDialog();
            if (dialogColor == DialogResult.OK)
            {
                nameColor.Text = colorOfImage.Color.Name;
                R = colorOfImage.Color.R;
                G = colorOfImage.Color.G;
                B = colorOfImage.Color.B;
                numOfColor.Text = R + " , " + G + " , " + B;
                autoColor.BackColor = Color.FromArgb(R,G,B);
            }

        }

        private bool changeColor(Bitmap bitmap, double x = 0.3, double y = 0.3, double z = 0.3)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color getColor = bitmap.GetPixel(i, j);
                    int r = getColor.R;
                    int g = getColor.G;
                    int b = getColor.B;

                    int colorModify = (byte)(x * r + y * g + z * b);
                    if (x == 1 && y == 0 && z == 0)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(colorModify, 0, 0));
                    }
                    else if (x == 0 && y == 1 && z == 0)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(0, colorModify, 0));
                    }
                    else if (x == 0 && y == 0 && z == 1)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(0, 0, colorModify));
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(colorModify, colorModify, colorModify));
                    }


                }
            }

            return true;

        }
        private void showImageOut_Click(object sender, EventArgs e)
        {
            picOutput.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void autoColor_Click(object sender, EventArgs e)
        {
            Bitmap bitmapOut = new Bitmap(picInput.Image);
            R = R / 255;
            G = G / 255;
            B = B / 255;

            if (R != 0 && G != 0 && B == 0)
            {
                changeColor(bitmapOut, R, G, 0);
                picOutput.Image = bitmapOut;
                bmp = bitmapOut;
            }
            else if (R != 0 && G == 0 && B != 0)
            {
                changeColor(bitmapOut, R, 0, B);
                picOutput.Image = bitmapOut;
                bmp = bitmapOut;
            }
            else if (R == 0 && G != 0 && B == 0)
            {
                changeColor(bitmapOut, 0, G, B);
                picOutput.Image = bitmapOut;
                bmp = bitmapOut;
            }
            else
            {
                changeColor(bitmapOut, R, G, B);
              
            }

            picOutput.Image = bitmapOut;
            bmp = bitmapOut;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmapOut = new Bitmap(picInput.Image);
            changeColor(bitmapOut, 1, 0, 0);
            picOutput.Image = bitmapOut;
            bmp = bitmapOut;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmapOut = new Bitmap(picInput.Image);
            changeColor(bitmapOut, 0, 1, 0);
            picOutput.Image = bitmapOut;
            bmp = bitmapOut;
        }


        private void blueBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmapOut = new Bitmap(picInput.Image);
            changeColor(bitmapOut, 0, 0, 1);
            picOutput.Image = bitmapOut;
            bmp = bitmapOut;
        }

        private void greyBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmapOut = new Bitmap(picInput.Image);
            changeColor(bitmapOut);
            picOutput.Image = bitmapOut;
            bmp = bitmapOut;
        }

        private void convertToGray_Click(object sender, EventArgs e)
        {
            Bitmap grayscaleImage = new Bitmap(picInput.Image, picInput.Width, picInput.Height);
            for (int x = 0; x < picInput.Width; x++)
            {
                for (int y = 0; y < picInput.Height; y++)
                {
                    Color pixel = grayscaleImage.GetPixel(x, y);
                    int grayValue = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    grayscaleImage.SetPixel(x, y, Color.FromArgb(pixel.A, grayValue, grayValue, grayValue));
                }
            }
            picOutput.Image = grayscaleImage;
            bmp = grayscaleImage;
        }
    }
}