using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        //Инициализация
        public Form1()
        {
            InitializeComponent();
        }

        //Список текущих форм
        List<Form2> Forms = new List<Form2>();

        void WindowList()
        {
            listBox1.Items.Clear();
            foreach (var f in Forms)
                listBox1.Items.Add(f.Text);
        }


        //Создание новой формы
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            //добавление новой формы в список
            Forms.Add(childForm);
            childForm.Text = "Новая форма " + Forms.Count.ToString();
            //родительская MDI форма
            childForm.MdiParent = this;
            childForm.Show();
            WindowList();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Forms[listBox1.SelectedIndex].BringToFront();
        }

        //Открытие файла
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если никакой формы нет, создаём новую
            if (ActiveMdiChild == null)
                создатьToolStripMenuItem_Click(sender, e);
            //Выбор формы
            Form2 childForm = (Form2)ActiveMdiChild;
            childForm.открытьToolStripMenuItem_Click(sender, e);
            WindowList();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void плиткаГоризонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void плиткаВертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }


    }
}
