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
        List<Layer> layers = new List<Layer>();
        Layer currentLayer;

        PictureBox canvas;
        string mode;
        Bitmap image;
        Bitmap image1;  //дополнительный слой для отрисовки фигур
        Color color;
        int x0, y0;
        int xclick1, yclick1;

        public Form1()
        {
            mode = "Линия"; //Линия - значение по умолчанию
            timer.Interval = 1000;
            timer.Elapsed += timer1_Tick;
            timer.Enabled = true;
            InitializeComponent();
            color = Color.Black;
            ChooseColor.BackColor = color;
            x0 = y0 = 0;

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && image != null)
            {
                Pen pen = new Pen(color, trackBar1.Value);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                Graphics graphics1 = Graphics.FromImage(currentLayer.image);
                Graphics graphics = Graphics.FromImage(currentLayer.image);

                if (e.Button == MouseButtons.Left)
                {   
                    if (mode == "Линия")
                    {
                        graphics.DrawLine(pen, x0, y0, e.X, e.Y);
                    }

                    if (mode == "Прямоугольник")
                    {
                        graphics1.Clear(canvas.BackColor);
                        graphics1.DrawRectangle(pen, xclick1, yclick1, e.X - xclick1, e.Y - yclick1);
                    }

                    if (mode == "Овал")
                    {
                        graphics1.Clear(canvas.BackColor);
                        graphics1.DrawEllipse(pen, xclick1, yclick1, e.X - xclick1, e.Y - yclick1);
                    }

                    graphics.DrawImage(image1, 0, 0);

                }
                currentLayer.pictureBox.Image = currentLayer.image;
                ShowLayersOnCanvas();
            }
            x0 = e.X;
            y0 = e.Y;
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateImage createImageDialog = new CreateImage();
            if (createImageDialog.ShowDialog() == DialogResult.OK)
            {
                DesposeLayers();
                CreateCanvas(createImageDialog.Width, createImageDialog.Height);
                image = new Bitmap(createImageDialog.Width, createImageDialog.Height);
                image1 = new Bitmap(createImageDialog.Width, createImageDialog.Height);
                canvas.Image = image;
                AddLayer();
                LayerClick(layers[0]);
            }
        }

        private void ShowLayersOnCanvas()
        {
            Graphics graphics = Graphics.FromImage(image);
            for (int i = 0; i < layers.Count; i++)
            {
                graphics.DrawImage(layers[i].image, new Point(0, 0));
                canvas.Image = image;
            }
        }

        private void CreateCanvas(int width, int height)
        {
            if (canvas != null) canvas.Dispose();
            canvas = new PictureBox();
            canvas.BackColor = SystemColors.Control;
            canvas.BorderStyle = BorderStyle.FixedSingle;
            canvas.Name = "canvas";
            canvas.Size = new Size(width, height);
            canvas.SizeMode = PictureBoxSizeMode.AutoSize;
            canvas.TabStop = false;
            Background.Controls.Add(canvas);
            CanvasCenterBackground();
            canvas.MouseMove += new MouseEventHandler(canvas_MouseMove);
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                Button button = (Button)sender;
                button.BackColor = color;
            }
        }

        private void СохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                if (image != null) image.Save(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddLayerButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                AddLayer();
            }
        }

        private void AddLayer()
        {
            Layer newLayer = new Layer(image.Width, image.Height);
            newLayer.OnLayerClick += LayerClick;
            layersPanel.Controls.Add(newLayer.panel);
            layers.Add(newLayer);
        }

        private void DesposeLayers()
        {
            for (int i = 0; i < layers.Count; i++)
            {
                layers[i].Dispose();
            }
            layers.Clear();
        }

        private void LayerClick(Layer layer)
        {
           if (currentLayer != null)
           {
                currentLayer.panel.BackColor = SystemColors.Control;
           }
            layer.panel.BackColor = SystemColors.AppWorkspace;
            currentLayer = layer;
        }



        private void Panel2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteLayerButton_Click(object sender, EventArgs e)
        {
            if (currentLayer != null)
            {
                currentLayer.panel.Dispose();
            }
        }

        private void Background_Resize(object sender, EventArgs e)
        {
            if (canvas != null) CanvasCenterBackground();
        }

        private void CanvasCenterBackground()
        {
            canvas.Location = new Point((Background.Width - canvas.Width) / 2, (Background.Height - canvas.Height) / 2);
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Линия";
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Прямоугольник";
        }

        private void овалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Овал";
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(color, trackBar1.Value);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            Graphics graphics = Graphics.FromImage(currentLayer.image);

            if (mode == "Прямоугольник")
            {
              graphics.DrawRectangle(pen, xclick1, yclick1, e.X - xclick1, e.Y - yclick1);
            }

            if (mode == "Овал")
            {
                graphics.DrawEllipse(pen, xclick1, yclick1, e.X - xclick1, e.Y - yclick1);
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            color = canvas.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                this.BackColor = color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                canvas.BackColor = color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Graphics g = Graphics.FromImage(currentLayer.image);
            g.DrawString("Hello", new Font("Arial", 14), Brushes.Black, 2, 2);*/
            //Controls.Add(image);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы действительно хотите выйти?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                this.Close();

           // this.TopMost = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(currentLayer.image);
            graphics.Clear(canvas.BackColor);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        System.Timers.Timer timer = new System.Timers.Timer();

        private void timer1_Tick(object sender, EventArgs e)
        {
            var str = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            if (label4.InvokeRequired) label4.Invoke(new Action<string>((s) => label4.Text = s), str);
            else
                label4.Text = "Текущее время: " + str;
        }

        private void вправона90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            canvas.Refresh();
        }

        private void влевона90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            canvas.Refresh();
        }

        private void отображениеПоГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            canvas.Refresh();
        }

        private void отображениеПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            canvas.Refresh();
        }

        private void на180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            canvas.Refresh();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
                xclick1 = e.X;
                yclick1 = e.Y;
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                image = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                canvas.Image = image;
            }
        }

    }
}
