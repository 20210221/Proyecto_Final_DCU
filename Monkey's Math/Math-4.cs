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
    public partial class Math_4 : Form
    {
        public Math_4()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "") { return; }

            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox2.Text) > 0) { }

            else { return; }

            this.Size = new Size(872, 612);

            if (comboBox1.Text == "Hipotenusa")
            {

                label2.Text = "CO";

                label2.Location = new Point(195, 39);

                textBox6.Location = new Point(344, 237);

                label4.Text = "CA";

                label6.Text = "H =";

                label7.Text = "H =";

                label8.Text = "H =";

                label9.Text = "H =";


                textBox3.Text = "(" + textBox1.Text + ")²" + " + " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertsum = convert1 + convert2;

                double convertraiz = Math.Sqrt(convertsum);

                textBox4.Text = "(" + convert1.ToString() + ")" + " + " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertsum.ToString();

                textBox6.Text = convertraiz.ToString();

            }

            else if (comboBox1.Text == "Cateto Opuesto")

            {

                label2.Text = "H";

                label2.Location = new Point(220, 39);

                textBox6.Location = new Point(374, 237);

                label4.Text = "CA";

                label6.Text = "CO =";

                label7.Text = "CO =";

                label8.Text = "CO =";

                label9.Text = "CO =";

                textBox3.Text = "(" + textBox1.Text + ")²" + " - " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertrest = convert1 - convert2;

                double convertraiz = Math.Sqrt(convertrest);

                textBox4.Text = "(" + convert1.ToString() + ")" + " - " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertrest.ToString();

                textBox6.Text = convertraiz.ToString();
            }

            else if (comboBox1.Text == "Cateto Adyacente")
            {

                label2.Text = "H";

                label2.Location = new Point(220, 39);

                textBox6.Location = new Point(374, 237);

                label4.Text = "CO";

                label6.Text = "CA =";

                label7.Text = "CA =";

                label8.Text = "CA =";

                label9.Text = "CA =";

                textBox3.Text = "(" + textBox1.Text + ")²" + " - " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertrest = convert1 - convert2;

                double convertraiz = Math.Sqrt(convertrest);

                textBox4.Text = "(" + convert1.ToString() + ")" + " - " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertrest.ToString();

                textBox6.Text = convertraiz.ToString();

            }
            }

      
        private void Math_4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "") { return; }

            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) > 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox2.Text) > 0) { }

            else { return; }

            if (comboBox1.Text == "Hipotenusa")
            {

                label2.Text = "CO";

                label2.Location = new Point(195, 39);

                textBox6.Location = new Point(344, 237);

                label4.Text = "CA";

                label6.Text = "H =";

                label7.Text = "H =";

                label8.Text = "H =";

                label9.Text = "H =";


                textBox3.Text = "(" + textBox1.Text + ")²" + " + " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertsum = convert1 + convert2;

                double convertraiz = Math.Sqrt(convertsum);

                textBox4.Text = "(" + convert1.ToString() + ")" + " + " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertsum.ToString();

                textBox6.Text = convertraiz.ToString();

            }

            else if (comboBox1.Text == "Cateto Opuesto")

            {

                label2.Text = "H";

                label2.Location = new Point(220, 39);

                textBox6.Location = new Point(374, 237);

                label4.Text = "CA";

                label6.Text = "CO =";

                label7.Text = "CO =";

                label8.Text = "CO =";

                label9.Text = "CO =";

                textBox3.Text = "(" + textBox1.Text + ")²" + " - " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertrest = convert1 - convert2;

                double convertraiz = Math.Sqrt(convertrest);

                textBox4.Text = "(" + convert1.ToString() + ")" + " - " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertrest.ToString();

                textBox6.Text = convertraiz.ToString();
            }

            else if (comboBox1.Text == "Cateto Adyacente")
            {

                label2.Text = "H";

                label2.Location = new Point(220, 39);

                textBox6.Location = new Point(374, 237);

                label4.Text = "CO";

                label6.Text = "CA =";

                label7.Text = "CA =";

                label8.Text = "CA =";

                label9.Text = "CA =";

                textBox3.Text = "(" + textBox1.Text + ")²" + " - " + "(" + textBox2.Text + ")²";

                int convert1 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);

                int convert2 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);

                int convertrest = convert1 - convert2;

                double convertraiz = Math.Sqrt(convertrest);

                textBox4.Text = "(" + convert1.ToString() + ")" + " - " + "(" + convert2.ToString() + ")";

                textBox5.Text = convertrest.ToString();

                textBox6.Text = convertraiz.ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
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

            this.Size = new Size(872, 213);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            medias media = new medias();

            media.Show();

            media.DataVideo("Teorema de Pitagoras", @"C:\Users\Rafael De La Cruz\source\repos\Monkey's Math\Monkey's Math\Medias\T_Pitagoras.mp4");

        }
    }
}
