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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Portada Portadasection = new Portada();

            Portadasection.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Math_1 Math_1_section = new Math_1();

            Math_1_section.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Math_2 Math_2_section = new Math_2();

            Math_2_section.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Math_3 Math_3_section = new Math_3();

            Math_3_section.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Math_4 Math_4_section = new Math_4();

            Math_4_section.Show();
        }
    }
}
