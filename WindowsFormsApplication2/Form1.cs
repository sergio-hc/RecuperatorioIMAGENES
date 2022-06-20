//Sergio Luis Huanca Cuellar
//INF 324
//DOCENTE: Lic. Moises Silva
//I/2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap resultante;
        int[,] conv3x3 = new int[3, 3];

        int anchov, altov;

        int pR, pG, pB;
        int[] texturas = new int[9];
        public Form1()
        {
            InitializeComponent();
            resultante = new Bitmap(800, 600);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos *.*|";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;

            anchov = bmp.Width;
            altov = bmp.Height;

            //resultante = bmp;
            //pictureBox2.Image = resultante;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            c = bmp.GetPixel(15, 15);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = new Color();
            //c = bmp.GetPixel(e.X, e.Y);
            //textBox1.Text = c.R.ToString();
            //textBox2.Text = c.G.ToString();
            //textBox3.Text = c.B.ToString();
            //pR = c.R;
            //pG = c.G;
            //pB = c.B;
            pR = 0;
            pG = 0;
            pB = 0;
            for (int ki = e.X; ki < e.X + 10; ki++)
                for (int kj = e.Y; kj < e.Y + 10; kj++)
                {
                    c = bmp.GetPixel(ki, kj);
                    pR = pR + c.R;
                    pG = pG + c.G;
                    pB = pB + c.B;
                }
            pR = pR / 100;
            pG = pG / 100;
            pB = pB / 100;
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Color c = new Color();
            int mR = 0, mG = 0, mB = 0;
            for (int i = 15; i < 25; i++)
                for (int j = 15; j < 25; j++)
                {
                    c = bmp.GetPixel(i, j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mB + c.B;
                }
            mR = mR / 100;
            mG = mG / 100;
            mB = mB / 100;

            textBox1.Text = mR.ToString();
            textBox2.Text = mG.ToString();
            textBox3.Text = mB.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        { // cambio a textura fucsia 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R-10<= pR && pR <=c.R+10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int mR = 0, mG = 0, mB = 0;
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width-10; i = i + 10)
            {for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    mR = 0;
                    mG = 0;
                    mB = 0;
                    for (int ki = i; ki < i + 10; ki++)
                    {
                        for (int kj = j; kj < j + 10; kj++)
                        {
                            c = bmp.GetPixel(ki, kj);
                            mR = mR + c.R;
                            mG = mG + c.G;
                            mB = mB + c.B;
                        }
                        mR = mR / 100;
                        mG = mG / 100;
                        mB = mB / 100;
                    }

                    
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Fuchsia);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
                
            pictureBox2.Image = bmpR;
        }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // cambio a textura yellow 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Yellow);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            // cambio a textura 10 x 10
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R - 10 <= pR && pR <= c.R + 10) && (c.G - 10 <= pG && pG <= c.G + 10) && (c.B - 10 <= pB && pB <= c.B + 10))
                    {
                        bmpR.SetPixel(i, j, Color.Beige);
                    }
                    else
                    {
                        bmpR.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            pictureBox2.Image = bmpR;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
           Bitmap imgg = new Bitmap(bmp.Width, bmp.Height);
           // resultante = new Bitmap(bmp.Width, bmp.Height);
            Color rc = new Color();
            Color oc = new Color();
            float g = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    oc = bmp.GetPixel(i, j);
                    g = oc.R * 0.299f + oc.G * 0.587f + oc.B * 0.114f;

                    rc = Color.FromArgb((int)g, (int)g, (int)g);
                    imgg.SetPixel(i, j, rc);
                }

            }

            resultante = new Bitmap(bmp.Width, bmp.Height);
            //matriz 3x3 para bordes
            conv3x3 = new int[,] { { -1, 0, -1 }, { 0, 4, 0 }, { -1, 0, -1 } };
            Bitmap intermedio = (Bitmap)imgg.Clone();


            ConvGris(conv3x3, intermedio, 32, 64);


            this.Invalidate();

            //pictureBox2.Image = imgg;

        }
        private void ConvGris(int[,] pmatriz, Bitmap pImg, int pinf, int psup)
        {

            //pictureBox2.Image = pImg;
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            Color oco;

           

            int suma = 0;
            for (x = 1; x < pImg.Width - 1; x++)
            {
                for (y = 1; y< pImg.Height - 1; y++)
                {
                    suma = 0;
                    for (a = -1; a < 2; a++)
                    {
                        for (b = -1; b < 2; b++)
                        {
                            oco = pImg.GetPixel(x + a, y + b);
                            suma = suma + (oco.R * pmatriz[a + 1, b + 1]);
                        }
                    }
                    if (suma < pinf)
                        suma = 0;
                    else if (suma > psup)
                    { suma = 255; }

                    resultante.SetPixel(x, y, Color.FromArgb(suma, suma, suma));

                }

            }
            pictureBox2.Image = resultante;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i<bmp.Width; i++){
                for(int j=0; j< bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                }
                pictureBox2.Image = bmpR;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            Bitmap bmpR = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmpR.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                }
                pictureBox2.Image = bmpR;
            }
        }
    }
}
