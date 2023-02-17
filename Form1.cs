using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoaula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbCharmander_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Charmander;
        }

        private void rbtSquirtle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Squirtle;
        }

        private void rbtBulbasaur_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Bulbasaur;
        }
    }
}
