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
    public partial class colortest : Form
    {
        public colortest()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != trackBar1.Value.ToString())
            {
                textBox1.Text = trackBar1.Value.ToString();
            }
            renkgoster();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != trackBar2.Value.ToString())
            {
                textBox2.Text = trackBar2.Value.ToString();
            }
            renkgoster();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != trackBar3.Value.ToString())
            {
                textBox3.Text = trackBar3.Value.ToString();
            }
            renkgoster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar2.Value = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar3.Value = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
            }
        }

        void renkgoster()
        {
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txtrgb = new TextBox();
            txtrgb.Text = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text;
            Clipboard.SetDataObject((object)txtrgb.Text, false);
            MessageBox.Show("Panoya kopyalandı. " + txtrgb.Text, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox txthex = new TextBox();

            Color myColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            txthex.Text = hex;
            Clipboard.SetDataObject((object)txthex.Text, false);
            MessageBox.Show("Panoya kopyalandı. " + txthex.Text, "");
        }
    }
}
