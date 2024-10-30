using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_del_arduino_y_foco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Bioxor\Source\Repos\GifSample\GifSample\minion-enamorado");
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }
    }
}
