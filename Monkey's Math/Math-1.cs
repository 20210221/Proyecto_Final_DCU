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
    public partial class Math_1 : Form
    {
        public Math_1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            this.Size = new Size(596, 421);

            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 0) { }

            else { return; }


            if (textBox1.Text == "")
            {

                label3.Text = "0" + " ! =";

                label4.Text = "0" + " ! =";

                textBox2.Text = "1";

                textBox3.Text = "1";

                return;

            }

            if (Convert.ToInt32(textBox1.Text) == 0) {

                label3.Text =  "0" + " ! =";

                label4.Text = "0" + " ! =";

                textBox2.Text = "1";

                textBox3.Text = "1";

                return;

            }

            double factor = 1;

            double count = 0;

            string fo = "";

            for (double i = 1; i <= Convert.ToInt32(textBox1.Text); i++) {

                count += 1;

                factor = factor * count;

                  fo += i.ToString() + "*";

            }

            textBox2.Text = fo.Substring(0, fo.ToString().Count() - 1);

            label3.Text = textBox1.Text + " ! =";

            label4.Text = textBox1.Text + " ! =";

            textBox3.Text = factor.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            medias media = new medias();

            media.Hide();

            media.Close();

            media.Dispose();

            Home Homesection = new Home();

            Homesection.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            this.Size = new Size(596, 176);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            medias media = new medias();

            media.Show();

            media.DataVideo("Factoriales", @"C:\Users\Rafael De La Cruz\source\repos\Monkey's Math\Monkey's Math\Medias\Factoriales.mp4");

            
        }
    }
}
