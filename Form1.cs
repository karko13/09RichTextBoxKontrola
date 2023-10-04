using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxControlIvanoKarkovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrisiButton_Click(object sender, EventArgs e)
        {
            kutija.Clear();
        }

        private void CitajButton_Click(object sender, EventArgs e)
        {
           kutija.LoadFile(@"C:Tempproba.rtf");
        }

        private void SpremiButton_Click(object sender, EventArgs e)
        {
            kutija.SaveFile(@"C:Tempproba.rtf");

            MessageBox.Show("Tekst spremljen");
        }
    }
}
