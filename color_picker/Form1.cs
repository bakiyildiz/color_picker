using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace color_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox txtrgb = new TextBox();
        TextBox txthex = new TextBox();
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox1.BackColor = c;

                //aVal.Text = c.A.ToString();
                label1.Text = "R: " + c.R.ToString();
                label2.Text = "G: " + c.G.ToString();
                label3.Text = "B: " + c.B.ToString();

                picr.BackColor = Color.FromArgb(c.R, 0, 0);
                picg.BackColor = Color.FromArgb(0, c.G, 0);
                picb.BackColor = Color.FromArgb(0, 0, c.B);
                picrgb.BackColor = Color.FromArgb(c.R, c.G, c.B);
                picrgb2.BackColor = Color.FromArgb(c.R, c.G, c.B);

                txtrgb.Text = c.R + ";" + c.G + ";" + c.B;

                Color myColor = Color.FromArgb(c.R, c.G, c.B);
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                label4.Text = "HEX && HTML: " + hex;

                txthex.Text = hex;
            }
            catch (Exception ex)
            {
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                Clipboard.SetDataObject((object)txtrgb.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txtrgb.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txtrgb.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txtrgb.Text, "");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Clipboard.SetDataObject((object)txthex.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txthex.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txthex.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txthex.Text, "");
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                Clipboard.SetDataObject((object)txtrgb.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txtrgb.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txtrgb.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txtrgb.Text, "");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Clipboard.SetDataObject((object)txthex.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txthex.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txthex.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txthex.Text, "");
            }
        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                Clipboard.SetDataObject((object)txtrgb.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txtrgb.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txtrgb.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txtrgb.Text, "");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Clipboard.SetDataObject((object)txthex.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txthex.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txthex.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txthex.Text, "");
            }
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                Clipboard.SetDataObject((object)txtrgb.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txtrgb.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txtrgb.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txtrgb.Text, "");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Clipboard.SetDataObject((object)txthex.Text, false);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add(txthex.Text + " - " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    listBox1.Items.Add("");
                    int adt = listBox1.Items.Count - 1;
                    for (int i = 0; i < listBox1.Items.Count - 1; i++)
                    {
                        listBox1.Items[adt - i] = listBox1.Items[adt - (i + 1)];
                    }
                    listBox1.Items[0] = txthex.Text + " - " + DateTime.Now.ToLongTimeString();
                }
                MessageBox.Show("Panoya kopyalandı. " + txthex.Text, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(foto);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
            pictureBox1.Image = foto;
            this.Opacity = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Environment.Exit(1);
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colortest cts = new colortest();
            cts.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Renk Bulucu 1.0" + Environment.NewLine + "https://www.bakiyildiz.org", "");
        }
    }
}