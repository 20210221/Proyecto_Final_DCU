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
    public partial class medias : Form
    {
        public medias()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void DataVideo(String Name,String url)
        {

            label1.Text = Name;

            axWindowsMediaPlayer1.URL = url;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
