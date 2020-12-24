using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Editor
{
    public partial class Form2 : Form
    {

        int defaultWidth = 500;     //ширина по умолчанию
        int defaultHeight = 400;    //высота по умолчанию

        List<Layer> layers = new List<Layer>();     //список слоёв
        Layer currentLayer = null;      //для хранения текущего слоя

        Color color = Color.Black;    //Переменная, хранящая текущий цвет
        int x0, y0;     //Координаты для рисования кистью

        float scale = 1f;   //переменная-масштаб изображения
        float kx, ky;       //переменные для изменения масштаба

        public Form2()
        {
            //Инициализация формы
            InitializeComponent();
            ColorButton.BackColor = color;
            x0 = y0 = 0;
            kx = ky = 1f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Параметры по умолчанию при загрузке новой формы
            UpdateLayersPanel();
            CheckUndoRedoButtons();

            //Всплывающие подсказки при наведении мыши
            ToolTip t = new ToolTip();
            t.SetToolTip(minusButton, "Уменьшить размер в 1.1 раз");
            t.SetToolTip(plusButton, "Увеличить размер в 1.1 раз");
            t.SetToolTip(label3, "Текущий масштаб изображения");
            t.SetToolTip(trackBar1, "Выберите толщину кисти или фигуры");
            t.SetToolTip(ColorButton, "Выберите цвет");
            t.SetToolTip(label1, "Текущая толщина");

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

            Bitmap b = new Bitmap(openFileDialog1.FileName);

            CreateNewCanvas(b.Width, b.Height);

            AddLayer(b);
            RepaintAllLayers();
            CheckUndoRedoButtons();

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

        //Создание нового холста, холст может быть только 1
        public void CreateNewCanvas(int width, int height)
        {
            if (canvas != null) canvas.Dispose();
            RemoveAllLayers();
            ResetScale();
            canvas = new PictureBox();
            easel.Controls.Add(canvas);
            canvas.BackColor = SystemColors.ControlLightLight;
            canvas.BorderStyle = BorderStyle.FixedSingle;
            canvas.InitialImage = null;
            canvas.Location = new Point(77, 31);
            canvas.Name = "canvas";
            canvas.Size = new Size(width, height);
            canvas.TabIndex = 1;
            canvas.TabStop = false;
            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            canvas.Click += new EventHandler(canvas_Click);
            canvas.Paint += new PaintEventHandler(canvas_Paint);
            canvas.MouseDown += new MouseEventHandler(canvas_MouseDown);
            canvas.MouseMove += new MouseEventHandler(canvas_MouseMove);
            canvas.MouseUp += new MouseEventHandler(canvas_MouseUp);
            defaultWidth = width;
            defaultHeight = height;
            CenterTheCanvas();
        }

        //вызывается при создании нового холста - убирает все старые слои
        private void RemoveAllLayers()
        {
            for (int i = 0; i < layers.Count; i++)
            {
                layers[i].panel.Dispose();
            }
            currentLayer = null;
            layers.Clear();
            UpdateLayersPanel();
            CheckUndoRedoButtons();
        }

        //Функции для добавления затемнения, осветления и смешивания изображения
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
            if (currentLayer == null) return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            currentLayer.SaveState();
            Bitmap AddImage = new Bitmap(openFileDialog1.FileName);
            Bitmap BaseImage = currentLayer.bitmap;

            currentLayer.bitmap = imadd(BaseImage, AddImage);

            RepaintAllLayers();

        }

        private void затемнитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.Image = imadd((Bitmap)canvas.Image, -10);
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.bitmap = imadd(currentLayer.bitmap, -10);

            RepaintAllLayers();
        }

        private void осветлитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.Image = imadd((Bitmap)canvas.Image, 10);
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.bitmap = imadd(currentLayer.bitmap, 10);

            RepaintAllLayers();
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


        //Функция заливки небольших фрагментов
        public void Fill(int x, int y)
        {
            if (currentLayer == null) return;
            if (x >= canvas.Width - 1)
                return;
            if (x < 1)
                return;
            if (y >= canvas.Height - 1)
                return;
            if (y < 1)
                return;
            Graphics g = Graphics.FromImage(currentLayer.image);
            g.DrawLine(pen, x, y, x, y + 0.5f);

            canvas.Invalidate();

            Bitmap b = currentLayer.bitmap;
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
            if (currentLayer == null) return;
            if (e.Button == MouseButtons.Right)
            {
                currentLayer.SaveState();
                Fill(e.X, e.Y);
            }
        }

        bool firstDrawing = true;
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Рисование кистью
            if (mode == Mode.None)
            {
                Pen pen = new Pen(color, trackBar1.Value);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                if (e.Button == MouseButtons.Left && currentLayer != null)
                {
                    if (firstDrawing) currentLayer.SaveState();
                    Graphics layerG = Graphics.FromImage(currentLayer.image);
                    layerG.DrawLine(pen, x0 * kx, y0 * ky, e.X * kx, e.Y * ky);
                    firstDrawing = false;
                }
                x0 = e.X;
                y0 = e.Y;
            }
            //Рисование фигур и надписи
            if (x1 == 0 && y1 == 0)
                return;
            x2 = e.X;
            y2 = e.Y;
            //canvas.Refresh();
            RepaintAllLayers();
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

        //Событие завершения рисования
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentLayer == null) return;
            CheckUndoRedoButtons();
            Graphics G = Graphics.FromImage(currentLayer.image);
            switch (mode)
            {
                case Mode.None:
                    firstDrawing = true;
                    break;
                case Mode.Line:
                    currentLayer.SaveState();
                    G.DrawLine(pen, x1 * kx, y1 * ky, e.X * kx, e.Y * ky);
                    break;
                case Mode.Ellipse:
                    currentLayer.SaveState();
                    G.DrawEllipse(pen, x1 * kx, y1 * ky, (e.X - x1) * kx, (e.Y - y1) * ky);
                    break;
                case Mode.Rectangle:
                    currentLayer.SaveState();
                    G.DrawRectangle(pen, x1 * kx, y1 * ky, (e.X - x1) * kx, (e.Y - y1) * ky);
                    break;
                case Mode.Text:
                    currentLayer.SaveState();
                    G.DrawString(text, font, Brushes.Black, e.X * kx, e.Y * ky);
                    mode = Mode.None;
                    break;
            }
            x2 = x1 = 0;
            y2 = y1 = 0;

            RepaintAllLayers();
            Modified = true;
        }


        //Функции поворотов изображения
        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вправоНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            RepaintAllLayers();
        }

        private void влевоНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            RepaintAllLayers();
        }


        private void на180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            RepaintAllLayers();
        }

        //Функции отображения изображения по горизонтали и вертикали
        private void отображениеПоГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            RepaintAllLayers();
        }

        private void отображениеПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.SaveState();
            currentLayer.image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            RepaintAllLayers();
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

        //Функции перемещения слоёв (вниз/вверх)
        public void LayerUp(Layer layer)
        {
            if (layers.Count < 2) return;
            int index = layers.IndexOf(layer);
            if (index == 0) return;
            layers.Remove(layer);
            layers.Insert(index - 1, layer);
            UpdateLayersPanel();
        }

        public void LayerDown(Layer layer)
        {
            if (layers.Count < 2) return;
            int index = layers.IndexOf(layer);
            if (index == layers.Count - 1) return;
            layers.Remove(layer);
            layers.Insert(index + 1, layer);
            UpdateLayersPanel();
        }

        //создание и добавление нового слоя
        public void AddLayer()
        {
            Layer newLayer = new Layer(defaultWidth, defaultHeight);
            layers.Insert(0, newLayer);
            newLayer.SetParent(this);
            newLayer.SetName($"Layer {layers.Count}");
            LayersPanel.Controls.Add(newLayer.panel);
            UpdateLayersPanel();
            CheckUndoRedoButtons();
        }

        public void AddLayer(Bitmap bm)
        {
            Layer newLayer = new Layer(bm);
            layers.Insert(0, newLayer);
            newLayer.SetParent(this);
            newLayer.SetName($"Layer {layers.Count}");
            LayersPanel.Controls.Add(newLayer.panel);
            UpdateLayersPanel();
            CheckUndoRedoButtons();
        }

        //Добавить новый слой
        private void addLayerButton_Click(object sender, EventArgs e)
        {
            if (canvas == null) return;
            AddLayer();
            
        }

        //Удалить текущий слой
        private void removeLayerButton_Click(object sender, EventArgs e)
        {
            //если не выбран слой
            if (currentLayer == null) 
                return; 
            layers.Remove(currentLayer);
            currentLayer.panel.Dispose();
            currentLayer = null;
            UpdateLayersPanel();
            RepaintAllLayers();
            CheckUndoRedoButtons();
        }

        //обновляет панель слоёв и кнопки
        private void UpdateLayersPanel()
        {
            if (layers.Count > 1 && canvas != null) removeLayerButton.Enabled = true;
            else removeLayerButton.Enabled = false;

            for (int i = 0; i < layers.Count; i++)
            {
                LayersPanel.Controls.SetChildIndex(layers[i].panel, i);
            }

            RepaintAllLayers();
        }



        private void RepaintAllLayers()
        {
            if (layers.Count > 0)
            {
                canvas.Image = new Bitmap(defaultWidth, defaultHeight);
                for (int i = layers.Count - 1; i >= 0; i--)
                {
                    Graphics g = Graphics.FromImage(canvas.Image);
                    layers[i].image = layers[i].bitmap;
                    g.DrawImage(layers[i].image, new Point(0, 0));
                    layers[i].UpdateIcon();
                }
                CheckUndoRedoButtons();
            }
        }

        //кликнули на слой, вызывается из класса Layer
        public void clickOnLayer(Layer lay)
        {
            if (currentLayer != null)
            {
                currentLayer.RemoveSelection();
            }
            currentLayer = lay;
            currentLayer.ShowSelection();
            CheckUndoRedoButtons();
        }

        //Создание новго холста
        private void createCanvasButton_Click(object sender, EventArgs e)
        {
            bool right = true;

            int w, h;
            if (int.TryParse(widthCanvasText.Text, out w) && w > 0) widthCanvasText.BackColor = Color.White;
            else
            {
                widthCanvasText.BackColor = Color.Red;
                right = false;
            }

            if (int.TryParse(heightCanvasText.Text, out h) && h > 0) heightCanvasText.BackColor = Color.White;
            else
            {
                heightCanvasText.BackColor = Color.Red;
                right = false;
            }

            if (right) CreateNewCanvas(w, h);
        }

        private void easel_Resize(object sender, EventArgs e)
        {
            CenterTheCanvas();
        }

        //Сохранение текущего слоя
        private void сохранитьСлойКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLayer == null)
            {
                MessageBox.Show("Не выбран слой для сохранения");
                return;
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Text = saveFileDialog1.FileName;
            Modified = true;

            if (!Modified)
                return;
            //если нет изображения для сохранения
            if (saveFileDialog1.FileName == "*.jmp")
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
                return;
            }
            try
            {
                currentLayer.bitmap.Save(saveFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Сохранить не удалось");
            }

            Modified = false;
        }

        private void CheckUndoRedoButtons()
        {
            if (currentLayer == null)
            {
                undoButton.Enabled = false;
                redoButton.Enabled = false;
                return;
            }

            if (currentLayer.undoList.Count < 1)
            {
                undoButton.Enabled = false;
            }
            else undoButton.Enabled = true;

            if (currentLayer.redoList.Count < 1)
            {
                redoButton.Enabled = false;
            }
            else redoButton.Enabled = true;
        }

        //Кнопка "Отменить"
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.Undo();
            RepaintAllLayers();
            CheckUndoRedoButtons();
        }

        //Кнопка "Вернуть"
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (currentLayer == null) return;
            currentLayer.Redo();
            RepaintAllLayers();
            CheckUndoRedoButtons();
        }

        string[] separator = new string[] { "[SEPARATOR]" };
        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string data = $"{layers.Count}{separator[0]}{defaultWidth}{separator[0]}{defaultHeight}{separator[0]}";
            for (int i = 0; i < layers.Count; i++)
            {
                MemoryStream memoryStream = new MemoryStream();
                layers[i].image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = memoryStream.ToArray();
                data += Convert.ToBase64String(imageBytes);

                if (i != layers.Count - 1) data += separator[0];
            }
            saveFileDialog1.Filter = "Art Maker|*.artmaker";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            byte[] projectBytes = Encoding.Default.GetBytes(data);
            //File.WriteAllText(saveFileDialog1.FileName, data, System.Text.Encoding.Default);
            File.WriteAllBytes(saveFileDialog1.FileName, projectBytes);
        }

        private void открытьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Art Maker|*.artmaker";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            byte[] projectsBytes = File.ReadAllBytes(openFileDialog1.FileName);

            string data = Encoding.Default.GetString(projectsBytes);
            //string data = File.ReadAllText(openFileDialog1.FileName);
            string[] dataArray = data.Split(separator, StringSplitOptions.None);
            if (!int.TryParse(dataArray[0], out int countLayers))
            {
                MessageBox.Show("Не удалось открыть проект (1)");
                return;
            }
            if (!int.TryParse(dataArray[1], out int canvasWidth))
            {
                MessageBox.Show($"Не удалось открыть проект (2)");
                return;
            }
            if (!int.TryParse(dataArray[2], out int canvasHeight))
            {
                MessageBox.Show($"Не удалось открыть проект (3)");
                return;
            }

            CreateNewCanvas(canvasWidth, canvasHeight);
            
            for (int i = dataArray.Length - 1; i >= 3; i--)
            {
                byte[] layerBytes = Convert.FromBase64String(dataArray[i]);
                Image layerImage = Image.FromStream(new MemoryStream(layerBytes));
                AddLayer(new Bitmap(layerImage));
            }

            RepaintAllLayers();
            UpdateLayersPanel();
        }

        private void createCanvasToolTip_Click(object sender, EventArgs e)
        {

        }

        //Кнопка увеличения масштаба
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (canvas == null) return;
            scale += .1f;

            label3.Text = $"{Math.Round(scale * 100)} %";
            canvas.Width = (int)(defaultWidth * scale);
            canvas.Height = (int)(defaultHeight * scale);
            kx = (float)defaultWidth / canvas.Width;
            ky = (float)defaultHeight / canvas.Height;
            //CenterTheCanvas();
        }

        //Кнопка уменьшения масштаба
        private void minusButton_Click_1(object sender, EventArgs e)
        {
            if (canvas == null) return;
            if (scale < 0.1f) return;
            scale -= .1f;
            canvas.Width = (int)(defaultWidth * scale);
            canvas.Height = (int)(defaultHeight * scale);
            kx = (float)defaultWidth / canvas.Width;
            ky = (float)defaultHeight / canvas.Height;
            label3.Text = $"{Math.Round(scale * 100)} %";
            CenterTheCanvas();
        }

        private void ResetScale()
        {
            if (canvas == null) return;
            scale = 1f;
            canvas.Width = (int)(defaultWidth * scale);
            canvas.Height = (int)(defaultHeight * scale);
            kx = 1f;
            ky = 1f;
            label3.Text = $"{Math.Round(scale * 100)} %";
            CenterTheCanvas();
        }

        private void CenterTheCanvas()
        {
            if (canvas == null) return;
            int x = easel.Width / 2 - canvas.Width / 2;
            int y = easel.Height / 2 - canvas.Height / 2;
            canvas.Location = new Point(x, y);
        }

    }
}
