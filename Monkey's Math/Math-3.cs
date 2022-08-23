using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monkey_s_Math
{
    public partial class Math_3 : Form
    {
        public Math_3()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") { return; }

            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox2.Text) > 0) { }

            else { return; }

            this.Size = new Size(774, 626);

            label7.Text = textBox1.Text + " X " + textBox2.Text;

            int multiporce = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);

            label9.Text = multiporce.ToString();

            label14.Text = (multiporce / 100).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            medias media = new medias();

            media.Hide();

            media.Close();

            media.Close();

            Home Homesection = new Home();

            Homesection.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox2.Text = "";

            this.Size = new Size(774, 166);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            medias media = new medias();

            media.Show();

            media.DataVideo("Porcentajes", @"C:\Users\Rafael De La Cruz\source\repos\Monkey's Math\Monkey's Math\Medias\Porcentajes.mp4");

        }
    }
}
