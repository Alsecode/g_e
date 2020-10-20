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
    public partial class CreateImage : Form
    {
        int height;
        int width;

        public int Height
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public CreateImage()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            height = Convert.ToInt32(textBox1.Text);
            width = Convert.ToInt32(textBox2.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
