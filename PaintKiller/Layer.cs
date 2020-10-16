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
    public class Layer
    {
        public Panel panel;
        public Label label;
        public PictureBox pictureBox;
        public Bitmap image;

        public delegate void LayerClick(Layer layer);
        public LayerClick OnLayerClick;


        public Layer(int width, int height)
        {
            panel = new Panel();
            label = new Label();
            pictureBox = new PictureBox();

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Location = new Point(3, 3);
            panel.Size = new Size(170, 195);
            panel.Click += new EventHandler(OnPanelClick);

            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            label.Location = new Point(50, 4);
            label.Size = new Size(20, 20);
            label.Text = "Layer1";
            label.Click += new EventHandler(OnPanelClick);

            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left)
               | AnchorStyles.Right)));
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(-1, 24);
            pictureBox.Size = new Size(170, 170);
            pictureBox.TabStop = false;
            pictureBox.Click += new EventHandler(OnPanelClick);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            image = new Bitmap(width, height);
            pictureBox.Image = image;
        }

        private void OnPanelClick(object sender, EventArgs e)
        {
            OnLayerClick?.Invoke(this);
        }

        public void Dispose()
        {
            label.Dispose();
            pictureBox.Dispose();
            panel.Dispose();
        }

    }
}

