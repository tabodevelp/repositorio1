using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Configuration;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace textoimagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CREAMOS EL OBJETO IMAGEN
            Bitmap objBmp = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            //LE DAMOS EL FORMATO DE LA FUENTE
            Font objFont = new Font("Papirus", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            Graphics objGraphics = Graphics.FromImage(objBmp);

            Width = (int)objGraphics.MeasureString(textBox1.Text, objFont).Width;
            Height = (int)objGraphics.MeasureString(textBox1.Text, objFont).Height;

            objBmp = new Bitmap(objBmp, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBmp);

            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(textBox1.Text, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            objGraphics.Flush();
            pictureBox1.Image = objBmp;
        }
    }
}
