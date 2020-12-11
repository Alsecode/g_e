﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form2 : Form
    {

        private static int scale = 100; //переменная-масштаб изображения

        //PictureBox pic;
        Bitmap image;
        Color color;
        int x0, y0;     //Координаты для рисования кистью

        public Form2()
        {
            InitializeComponent();
            image = new Bitmap(1600, 800);
            ColorButton.BackColor = color;
            x0 = y0 = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            canvas.Image = new Bitmap(Width, Height);
            plusButton.Enabled = false;
            minusButton.Enabled = false;
        }

        bool Modified = false;

        //Открытие файла, модификатор доступа метода - public, для того, чтобы был доступ из Form1
        public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //разрешения файла
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            //если не удалось открыть файл
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Text = openFileDialog1.FileName;
            saveFileDialog1.FileName = openFileDialog1.FileName;
            //canvas.Image = new Bitmap(openFileDialog1.FileName);
            image = new Bitmap(openFileDialog1.FileName);

            Modified = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Modified) 
                return;
            //если нет изображения для сохранения
            if (saveFileDialog1.FileName == "*.jmp")
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
                return;
            }
            Bitmap b = (Bitmap)canvas.Image;
            try
            {
                b.Save(saveFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Сохранить не удалось");
            }

            Modified = false;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Text = saveFileDialog1.FileName;
            Modified = true;
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        Bitmap imadd(Bitmap Base, Bitmap Add)
        {
            Bitmap result = new Bitmap(Base);
            int maxX = Math.Min(Base.Width, Add.Width);
            int maxY = Math.Min(Base.Height, Add.Height);
            for (int x = 0; x < maxX; x++)
                for (int y = 0; y < maxY; y++)
                {
                    Color c1 = Base.GetPixel(x, y);
                    Color c2 = Add.GetPixel(x, y);
                    int r = c1.R + c2.R; if (r > 255) r = 255;
                    int g = c1.G + c2.G; if (g > 255) g = 255;
                    int b = c1.B + c2.B; if (b > 255) b = 255;
                    result.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            return result;
        }

        Bitmap imadd(Bitmap Base, int modify)
        {
            Bitmap result = new Bitmap(Base);
            int maxX = Base.Width;
            int maxY = Base.Height;
            for (int x = 0; x < maxX; x++)
                for (int y = 0; y < maxY; y++)
                {
                    Color c1 = Base.GetPixel(x, y);
                    int r = c1.R + modify; if (r > 255) r = 255; if (r < 0) r = 0;
                    int g = c1.G + modify; if (g > 255) g = 255; if (g < 0) g = 0;
                    int b = c1.B + modify; if (b > 255) b = 255; if (b < 0) b = 0;
                    result.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            return result;
        }

        private void смешатьСДругимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            Bitmap AddImage = new Bitmap(openFileDialog1.FileName);
            Bitmap BaseImage = (Bitmap)canvas.Image;

            canvas.Image = imadd(BaseImage, AddImage);
        }

        private void затемнитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image = imadd((Bitmap)canvas.Image, -10);
        }

        private void осветлитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image = imadd((Bitmap)canvas.Image, 10);
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }

        //ColorButton - выбор цвета
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                Button button = (Button)sender;
                button.BackColor = color;
            }
            pen = new Pen(colorDialog1.Color, trackBar1.Value);
        }

        //Выбор толщины
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format(" {0}", trackBar1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Шрифт надписи
        Font font = new Font("Courier New", 12);

        //Выбор шрифта надписи
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.OK) 
                return;
            font = fontDialog1.Font;
        }

        //Текст надписи по умолчанию:
        String text = "Новая надпись";

        //Выбор текста надписи:
        private void текстНадписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormText FT = new FormText();
            FT.textBox1.Text = text;
            FT.ShowDialog();
            text = FT.textBox1.Text;
        }

        //Перечисления для выбора того, что выводить при нажатии левой кнопкой мыши
        enum Mode
        {
            None,
            Line,
            Ellipse,
            Rectangle,
            Text
        };

        //значение по умолчанию:
        Mode mode = Mode.None;

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Line;
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Rectangle;
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Ellipse;
        }

        private void возвратККистиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.None;
        }

        private void надписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Text;
        }

        //Инструмент рисования
        Pen pen = Pens.Black;


        //Координаты начала и конца фигуры
        int x1, y1;
        int x2, y2;


        public void Fill(int x, int y)
        {
            if (x >= canvas.Width - 1)
                return;
            if (x < 1)
                return;
            if (y >= canvas.Height - 1)
                return;
            if (y < 1)
                return;
            Graphics g = Graphics.FromImage(image);
            g.DrawLine(pen, x, y, x, y + 0.5f);

            canvas.Invalidate();

            Bitmap b = image;
            if (b.GetPixel(x + 1, y).ToArgb() != color.ToArgb())
            {
                Fill(x + 1, y);
            }
            if (b.GetPixel(x - 1, y).ToArgb() != color.ToArgb())
            {
                Fill(x - 1, y);
            }
            if (b.GetPixel(x, y + 1).ToArgb() != color.ToArgb())
            {
                Fill(x, y + 1);
            }
            if (b.GetPixel(x, y - 1).ToArgb() != color.ToArgb())
            {
                Fill(x, y - 1);
            }
        }


        //Событие для начала рисования
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            canvas_MouseMove(sender, e);

            //Заливка
            if (e.Button == MouseButtons.Right)
            {
                Fill(e.X, e.Y);
            }
        }


        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Рисование кистью
            if (mode == Mode.None)
            {
                Pen pen = new Pen(color, trackBar1.Value);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                Graphics g;
                g = Graphics.FromImage(image);

                if (e.Button == MouseButtons.Left && image != null)
                {
                    g.DrawLine(pen, x0, y0, e.X, e.Y);
                    canvas.Image = image;
                }
                x0 = e.X;
                y0 = e.Y;
            }
            //Рисование фигур и надписи
            if (x1 == 0 && y1 == 0) 
                return;
            x2 = e.X;
            y2 = e.Y;
            canvas.Refresh();
        }

        //Событие процесса рисования фигур и надписи
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            switch (mode)
            {
                case Mode.None:
                    break;
                case Mode.Line:
                    pen = new Pen(colorDialog1.Color, trackBar1.Value);
                    G.DrawLine(pen, x1, y1, x2, y2);
                    break;
                case Mode.Ellipse:
                    pen = new Pen(colorDialog1.Color, trackBar1.Value);
                    G.DrawEllipse(pen, x1, y1, x2 - x1, y2 - y1);
                    break;
                case Mode.Rectangle:
                    pen = new Pen(colorDialog1.Color, trackBar1.Value);
                    G.DrawRectangle(pen, x1, y1, x2 - x1, y2 - y1);
                    break;
                case Mode.Text:
                    G.DrawString(text, font, Brushes.Black, x2, y2);
                    break;
            }
        }

        //События завершения рисования
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics G = Graphics.FromImage(canvas.Image);
            switch (mode)
            {
                case Mode.None:
                    break;
                case Mode.Line:
                    G.DrawLine(pen, x1, y1, e.X, e.Y);
                    break;
                case Mode.Ellipse:
                    G.DrawEllipse(pen, x1, y1, e.X - x1, e.Y - y1);
                    break;
                case Mode.Rectangle:
                    G.DrawRectangle(pen, x1, y1, e.X - x1, e.Y - y1);
                    break;
                case Mode.Text:
                    G.DrawString(text, font, Brushes.Black, e.X, e.Y);
                    mode = Mode.None;
                    break;
            }
            x2 = x1 = 0;
            y2 = y1 = 0;
            canvas.Refresh();
            Modified = true;
        }


        //Функции поворотов изображения
        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вправоНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            canvas.Refresh();
        }

        private void влевоНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            canvas.Refresh();
        }


        private void на180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            canvas.Refresh();
        }

        //Функции отображения изображения по горизонтали и вертикали
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

        //Инструменты

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                canvas.BackColor = color;
                ColorButton.BackColor = color;
            }
        }

        private void ластикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.None;
            color = canvas.BackColor;
            ColorButton.BackColor = color;
        }

        //Масштабирование изображения
        private void реальныйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            canvas.SizeMode = PictureBoxSizeMode.Normal;
            canvas.Dock = DockStyle.Fill;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            label3.Enabled = false;
            label3.Text = "100 %";
        }

        private void поЦентруToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            canvas.SizeMode = PictureBoxSizeMode.CenterImage;
            canvas.Dock = DockStyle.Fill;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            label3.Enabled = false;
            label3.Text = "100 %";
        }

        private void масштабироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            canvas.SizeMode = PictureBoxSizeMode.Zoom;
            canvas.Dock = DockStyle.Fill;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            label3.Enabled = false;
            label3.Text = "100 %";
        }

        private void сохранятьПропоцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            canvas.Dock = DockStyle.Fill;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            label3.Enabled = false;
            label3.Text = "100 %";
        }

        private void пользовательскоеМасштабированиеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            canvas.Dock = DockStyle.None;

            label3.Text = "100 %";
            scale = 100;

            plusButton.Enabled = true;
            minusButton.Enabled = true;
            label3.Enabled = true;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            canvas.Width = (int)(canvas.Width * 1.1);
            canvas.Height = (int)(canvas.Height * 1.1);

            scale = (int)(scale * 1.1);
            label3.Text = scale.ToString() + "%";
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            canvas.Width = (int)(canvas.Width / 1.1);
            canvas.Height = (int)(canvas.Height / 1.1);

            scale = (int)(scale / 1.1);
            label3.Text = scale.ToString() + "%";
        }



    }

    /*//Undo и Redo
public abstract class HistoryItem
{
    public abstract void Undo(PictureBox pic);
    public abstract void Redo(PictureBox pic);
}
public class History
{
    readonly List<HistoryItem> items = new List<HistoryItem>();

    PictureBox pic;
    int currentIndex = -1;

    public History(PictureBox pic)
    {
        this.pic = pic;
    }
    public bool CanUndo { get { return currentIndex >= 0; } }
    public bool CanRedo { get { return items.Count > 0 && currentIndex < items.Count - 1; } }

    public void Undo()
    {
        if (!CanUndo)
            return;
        items[currentIndex].Undo(pic);
        this.currentIndex--;
    }

    public void Redo()
    {
        if (!CanRedo)
            return;
        this.currentIndex++;
        items[currentIndex].Redo(pic);
    }

    public void Add(HistoryItem item)
    {
        CutOffHistory();
        items.Add(item);
        this.currentIndex++;
    }

    void CutOffHistory()
    {
        int index = currentIndex + 1;
        if (index < currentIndex)
            items.RemoveRange(index, currentIndex - index);
    }
}

public class DocumentHistoryItem : HistoryItem
{
    readonly DocumentState previousState;
    readonly DocumentState nextState;

    public DocumentHistoryItem(DocumentState previousState, DocumentState nextState)
    {
        this.previousState = previousState;
        this.nextState = nextState;
    }

    public override void Undo(Document document)
    {
        document.ApplyState(previousState);
    }
    public override void Redo(Document document)
    {
        document.ApplyState(nextState);
    }
}

public class CompositeHistoryItem : HistoryItem
{
    readonly List<HistoryItem> items = new List<HistoryItem>();

    public void AddItem(HistoryItem item)
    {
        items.Add(item);
    }
    protected override void UndoCore()
    {
        for (int i = items.Count - 1; i >= 0; i--)
            items[i].Undo();
    }
    protected override void RedoCore()
    {
        int count = items.Count;
        for (int i = 0; i < count; i++)
            items[i].Redo();
    }*/
}
