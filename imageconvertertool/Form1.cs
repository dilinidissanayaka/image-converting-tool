using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageconvertertool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox2.Image.Save(saveFileDialog1.FileName);
        }

        private void gray_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newimg = new Bitmap(img.Width, img.Height);


            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int gray = (int)((c.R * 0.2) + (c.G * 0.5) + (c.B * 0.2));
                    Color newC = Color.FromArgb(c.A, gray, gray, gray);
                    newimg.SetPixel(i, j, newC);

                }
            }
            pictureBox2.Image = newimg;

        }

        private void negative_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            int width = img.Width;
            int height = img.Height;



            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    img.SetPixel(i, j, Color.FromArgb(a, r, g, b));


                }
            }

            pictureBox2.Image = img;

        }

        private void redimage_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newimg = new Bitmap(img.Width, img.Height);


            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    Color newr = Color.FromArgb(c.A, c.R, 0, 0);

                    newimg.SetPixel(i, j, newr);
                }
                pictureBox2.Image = newimg;


            }

        }

        private void green_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newimg = new Bitmap(img.Width, img.Height);


            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    Color newr = Color.FromArgb(c.A, 0, c.G, 0);

                    newimg.SetPixel(i, j, newr);

                }
            }
            pictureBox2.Image = newimg;

        }

        private void blue_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newimg = new Bitmap(img.Width, img.Height);


            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    Color newr = Color.FromArgb(c.A, 0, 0, c.B);

                    newimg.SetPixel(i, j, newr);

                }
            }
            pictureBox2.Image = newimg;

        }

        private void binary_Click(object sender, EventArgs e)
        {

            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newimg = new Bitmap(img.Width, img.Height);
            string texto = "";


 
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
              
        if (img.GetPixel(j, i).A.ToString() == "255" 
                        && img.GetPixel(j, i).B.ToString() == "255" 
                        && img.GetPixel(j, i).G.ToString() == "255"
                        && img.GetPixel(j, i).R.ToString() == "255")
                    {
                        texto = texto + "0";
                    }
                    else
                    {
                        texto = texto + "1";
                    }
                }
                texto = texto + "\r\n";   
            }

            pictureBox2.Image = newimg;



        }
    }
}
