using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Editor
{
    public class Layer
    {
        public Bitmap bitmap;
        public Image image;

        public Panel panel { get; private set; }
        public Label label { get; private set; }
        public PictureBox pictureBox { get; private set; }
        public Form2 parentForm { get; private set; }
        public Button upLayerButton { get; private set; }
        public Button downLayerButton { get; private set; }

        public Layer(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            image = (Image)bitmap;
            CreateLayerBox();
        }

        public Layer(Bitmap bm)
        {
            bitmap = bm;
            image = (Image)bitmap;
            CreateLayerBox();
        }

        public Layer(Image i)
        {
            image = i;
            bitmap = (Bitmap)image;
            CreateLayerBox();
        }

        public void SetParent(Form2 f)
        {
            parentForm = f;
        }

        public void SetName(string s)
        {
            label.Text = s;
        }

        public void UpdateIcon()
        {
            image = (Image)bitmap;
            pictureBox.Image = image;
        }

        private void CreateLayerBox()
        {
            panel = new Panel();
            label = new Label();
            pictureBox = new PictureBox();
            downLayerButton = new Button();
            upLayerButton = new Button();

            panel.SuspendLayout();

            panel.Controls.Add(upLayerButton);
            panel.Controls.Add(downLayerButton);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Location = new Point(3, 3);
            panel.Name = "panel3";
            panel.Size = new Size(117, 134);
            panel.TabIndex = 0;
            panel.BackColor = Color.WhiteSmoke;


            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Location = new Point(-2, -2);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(120, 116);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            label.AutoSize = true;
            label.Location = new Point(38, 117);
            label.Name = "label4";
            label.Size = new Size(35, 13);
            label.TabIndex = 1;
            label.Text = "layer1";

            upLayerButton.Location = new Point(2, 91);
            upLayerButton.Name = "button";
            upLayerButton.Size = new Size(20, 20);
            upLayerButton.TabIndex = 1;
            upLayerButton.Text = "^";
            upLayerButton.UseVisualStyleBackColor = true;
            upLayerButton.Click += UpButtonClick;

            downLayerButton.Location = new Point(93, 91);
            downLayerButton.Name = "button";
            downLayerButton.Size = new Size(20, 20);
            downLayerButton.TabIndex = 1;
            downLayerButton.Text = "v";
            downLayerButton.UseVisualStyleBackColor = true;
            downLayerButton.Click += DownButtonClick;


            panel.Click += OnClick;
            pictureBox.Click += OnClick;
            label.Click += OnClick;

            panel.ResumeLayout(false);
        }
        

        public void OnClick(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.clickOnLayer(this);
                ShowSelection();
            }
        }

        public void UpButtonClick(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.LayerUp(this);
            }
        }
        
        public void DownButtonClick(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.LayerDown(this);
            }
        }

        public void ShowSelection()
        {
            panel.BackColor = Color.Gray;
        }

        public void RemoveSelection()
        {
            panel.BackColor = Color.WhiteSmoke;
        }

    }
}
