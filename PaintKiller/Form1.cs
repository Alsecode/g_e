using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintKiller
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Color color;
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Scale();
            pictureBox1.Size = new Size(0, 0);
            color = Color.Black;
            ChooseColor.BackColor = color;
            x0 = y0 = 0;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && image != null)
            {
                Pen pen = new Pen(color, trackBar1.Value);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                Graphics graphics = Graphics.FromImage(image);
                graphics.DrawLine(pen, x0, y0, e.X, e.Y);
                pictureBox1.Image = image;
            }
            x0 = e.X;
            y0 = e.Y;
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateImage createImageDialog = new CreateImage();
            if (createImageDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(createImageDialog.Height, createImageDialog.Width);
                pictureBox1.Image = image;
            }
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                Button button = (Button)sender;
                button.BackColor = color;
            }
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void СохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                if (image != null) image.Save(saveFileDialog1.FileName);
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                image = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

    }
}
