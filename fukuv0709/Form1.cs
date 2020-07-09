using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0709
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ue_Click(object sender, EventArgs e)
        {
            shobon.Top = shobon.Top -10;
        }

        private void hidari_Click(object sender, EventArgs e)
        {
            shobon.Left = shobon.Left - 10;
        }

        private void migi_Click(object sender, EventArgs e)
        {
            shobon.Left = shobon.Left + 10;
        }

        private void sita_Click(object sender, EventArgs e)
        {
            shobon.Top = shobon.Top + 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shobon_Click(object sender, EventArgs e)
        {
            shobon.Text = "(`・ω・´)";
        }
    }
}
