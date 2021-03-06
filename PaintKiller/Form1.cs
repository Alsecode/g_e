﻿using System;
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
        Bitmap image;
        Color color;
        int x0, y0;

        public Form1()
        {
            InitializeComponent();
            color = Color.Black;
            ChooseColor.BackColor = color;
            x0 = y0 = 0;
            
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && image != null)
            {
                Pen pen = new Pen(color, trackBar1.Value);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                Graphics graphics = Graphics.FromImage(currentLayer.image);
                graphics.DrawLine(pen, x0, y0, e.X, e.Y);
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
            canvas.MouseMove += new MouseEventHandler(Canvas_MouseMove);
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
