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
    public partial class Math_2 : Form
    {
        public Math_2()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "") { return; }

            else if (textBox5.Text == "") { return; }

            else if (textBox3.Text == "") { return; }

            else if (textBox2.Text == "") { return; }

            else if (textBox6.Text == "") { return; }

            else if (textBox4.Text == "") { return; }


            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox5.Text) <= 0 || Convert.ToInt32(textBox5.Text) > 0) { }

            else { return; }

            if (Convert.ToInt32(textBox3.Text) <= 0 || Convert.ToInt32(textBox3.Text) > 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox2.Text) > 0) { }

            else { return; }

            if (Convert.ToInt32(textBox6.Text) <= 0 || Convert.ToInt32(textBox6.Text) > 0 || Convert.ToInt32(textBox4.Text) <= 0 || Convert.ToInt32(textBox4.Text) > 0) { }

            else { return; }



            textBox12.Text = textBox1.Text;

            textBox7.Text = textBox5.Text;

            textBox11.Text = textBox3.Text;

            textBox10.Text = textBox2.Text;

            textBox9.Text = textBox6.Text;

            textBox8.Text = textBox4.Text;

            this.Size = new Size(800, 587);


            int d1 = Convert.ToInt32(textBox12.Text) * Convert.ToInt32(textBox7.Text);

            int p1 = Convert.ToInt32(textBox7.Text) - 1;

            textBox18.Text = d1.ToString();

            textBox13.Text = p1.ToString();


            int d2 = Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox10.Text);

            int p2 = Convert.ToInt32(textBox10.Text) - 1;

            textBox17.Text = d2.ToString();

            textBox16.Text = p2.ToString();


            int d3 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox8.Text);

            int p3 = Convert.ToInt32(textBox8.Text) - 1;

            textBox15.Text = d3.ToString();

            textBox14.Text = p3.ToString();




            int dd1 = Convert.ToInt32(textBox18.Text) * Convert.ToInt32(textBox13.Text);

            int pp1 = Convert.ToInt32(textBox13.Text) - 1;

            textBox24.Text = dd1.ToString();

            textBox19.Text = pp1.ToString();


            int dd2 = Convert.ToInt32(textBox17.Text) * Convert.ToInt32(textBox16.Text);

            int pp2 = Convert.ToInt32(textBox16.Text) - 1;

            textBox23.Text = dd2.ToString();

            textBox22.Text = pp2.ToString();


            int dd3 = Convert.ToInt32(textBox15.Text) * Convert.ToInt32(textBox14.Text);

            int pp3 = Convert.ToInt32(textBox14.Text) - 1;

            textBox21.Text = dd3.ToString();

            textBox20.Text = pp3.ToString();



            int ddd1 = Convert.ToInt32(textBox24.Text) * Convert.ToInt32(textBox19.Text);

            int ppp1 = Convert.ToInt32(textBox19.Text) - 1;

            textBox30.Text = ddd1.ToString();

            textBox25.Text = ppp1.ToString();


            int ddd2 = Convert.ToInt32(textBox23.Text) * Convert.ToInt32(textBox22.Text);

            int ppp2 = Convert.ToInt32(textBox22.Text) - 1;

            textBox29.Text = ddd2.ToString();

            textBox28.Text = ppp2.ToString();


            int ddd3 = Convert.ToInt32(textBox21.Text) * Convert.ToInt32(textBox20.Text);

            int ppp3 = Convert.ToInt32(textBox20.Text) - 1;

            textBox27.Text = ddd3.ToString();

            textBox26.Text = ppp3.ToString();
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

            this.Size = new Size(800, 175);

            textBox1.Text = "";

            textBox5.Text = "";

            textBox3.Text = "";

            textBox2.Text = "";

            textBox6.Text = "";

            textBox4.Text = "";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            medias media = new medias();

            media.Show();

            media.DataVideo("Derivadas", @"C:\Users\Rafael De La Cruz\source\repos\Monkey's Math\Monkey's Math\Medias\Derivadas.mp4");

        }
    }
}
