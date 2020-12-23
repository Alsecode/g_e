namespace Editor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCanvasToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.widthCanvasText = new System.Windows.Forms.ToolStripTextBox();
            this.heightCanvasText = new System.Windows.Forms.ToolStripTextBox();
            this.createCanvasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСлойКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затемнитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осветлитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смешатьСДругимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вправоНа90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.влевоНа90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображениеПоГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображениеПоВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстНадписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарисоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратККистиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранятьПропоцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательскоеМасштабированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.easel = new System.Windows.Forms.Panel();
            this.LayersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.removeLayerButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.нарисоватьToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.масштабToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCanvasToolTip,
            this.открытьToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.открытьПроектToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьСлойКакToolStripMenuItem,
            this.затемнитьИзображениеToolStripMenuItem,
            this.осветлитьИзображениеToolStripMenuItem,
            this.смешатьСДругимToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createCanvasToolTip
            // 
            this.createCanvasToolTip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthCanvasText,
            this.heightCanvasText,
            this.createCanvasButton});
            this.createCanvasToolTip.Name = "createCanvasToolTip";
            this.createCanvasToolTip.Size = new System.Drawing.Size(213, 26);
            this.createCanvasToolTip.Text = "Создать";
            // 
            // widthCanvasText
            // 
            this.widthCanvasText.BackColor = System.Drawing.SystemColors.Window;
            this.widthCanvasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthCanvasText.Name = "widthCanvasText";
            this.widthCanvasText.Size = new System.Drawing.Size(100, 23);
            this.widthCanvasText.Text = "Width";
            this.widthCanvasText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightCanvasText
            // 
            this.heightCanvasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightCanvasText.Name = "heightCanvasText";
            this.heightCanvasText.Size = new System.Drawing.Size(100, 23);
            this.heightCanvasText.Text = "Height";
            this.heightCanvasText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createCanvasButton
            // 
            this.createCanvasButton.Name = "createCanvasButton";
            this.createCanvasButton.Size = new System.Drawing.Size(160, 22);
            this.createCanvasButton.Text = "Создать холст";
            this.createCanvasButton.Click += new System.EventHandler(this.createCanvasButton_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьСлойКакToolStripMenuItem
            // 
            this.сохранитьСлойКакToolStripMenuItem.Name = "сохранитьСлойКакToolStripMenuItem";
            this.сохранитьСлойКакToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.сохранитьСлойКакToolStripMenuItem.Text = "Сохранить слой как...";
            this.сохранитьСлойКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСлойКакToolStripMenuItem_Click);
            // 
            // затемнитьИзображениеToolStripMenuItem
            // 
            this.затемнитьИзображениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("затемнитьИзображениеToolStripMenuItem.Image")));
            this.затемнитьИзображениеToolStripMenuItem.Name = "затемнитьИзображениеToolStripMenuItem";
            this.затемнитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.затемнитьИзображениеToolStripMenuItem.Text = "Затемнить изображение";
            this.затемнитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.затемнитьИзображениеToolStripMenuItem_Click);
            // 
            // осветлитьИзображениеToolStripMenuItem
            // 
            this.осветлитьИзображениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("осветлитьИзображениеToolStripMenuItem.Image")));
            this.осветлитьИзображениеToolStripMenuItem.Name = "осветлитьИзображениеToolStripMenuItem";
            this.осветлитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.осветлитьИзображениеToolStripMenuItem.Text = "Осветлить изображение";
            this.осветлитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.осветлитьИзображениеToolStripMenuItem_Click);
            // 
            // смешатьСДругимToolStripMenuItem
            // 
            this.смешатьСДругимToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("смешатьСДругимToolStripMenuItem.Image")));
            this.смешатьСДругимToolStripMenuItem.Name = "смешатьСДругимToolStripMenuItem";
            this.смешатьСДругимToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.смешатьСДругимToolStripMenuItem.Text = "Смешать с другим";
            this.смешатьСДругимToolStripMenuItem.Click += new System.EventHandler(this.смешатьСДругимToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вправоНа90ToolStripMenuItem,
            this.влевоНа90ToolStripMenuItem,
            this.на180ToolStripMenuItem,
            this.отображениеПоГоризонталиToolStripMenuItem,
            this.отображениеПоВертикалиToolStripMenuItem});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // вправоНа90ToolStripMenuItem
            // 
            this.вправоНа90ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вправоНа90ToolStripMenuItem.Image")));
            this.вправоНа90ToolStripMenuItem.Name = "вправоНа90ToolStripMenuItem";
            this.вправоНа90ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.вправоНа90ToolStripMenuItem.Text = "Вправо на 90°";
            this.вправоНа90ToolStripMenuItem.Click += new System.EventHandler(this.вправоНа90ToolStripMenuItem_Click);
            // 
            // влевоНа90ToolStripMenuItem
            // 
            this.влевоНа90ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("влевоНа90ToolStripMenuItem.Image")));
            this.влевоНа90ToolStripMenuItem.Name = "влевоНа90ToolStripMenuItem";
            this.влевоНа90ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.влевоНа90ToolStripMenuItem.Text = "Влево на 90°";
            this.влевоНа90ToolStripMenuItem.Click += new System.EventHandler(this.влевоНа90ToolStripMenuItem_Click);
            // 
            // на180ToolStripMenuItem
            // 
            this.на180ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("на180ToolStripMenuItem.Image")));
            this.на180ToolStripMenuItem.Name = "на180ToolStripMenuItem";
            this.на180ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.на180ToolStripMenuItem.Text = "На 180°";
            this.на180ToolStripMenuItem.Click += new System.EventHandler(this.на180ToolStripMenuItem_Click);
            // 
            // отображениеПоГоризонталиToolStripMenuItem
            // 
            this.отображениеПоГоризонталиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отображениеПоГоризонталиToolStripMenuItem.Image")));
            this.отображениеПоГоризонталиToolStripMenuItem.Name = "отображениеПоГоризонталиToolStripMenuItem";
            this.отображениеПоГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.отображениеПоГоризонталиToolStripMenuItem.Text = "Отображение по горизонтали";
            this.отображениеПоГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.отображениеПоГоризонталиToolStripMenuItem_Click);
            // 
            // отображениеПоВертикалиToolStripMenuItem
            // 
            this.отображениеПоВертикалиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отображениеПоВертикалиToolStripMenuItem.Image")));
            this.отображениеПоВертикалиToolStripMenuItem.Name = "отображениеПоВертикалиToolStripMenuItem";
            this.отображениеПоВертикалиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.отображениеПоВертикалиToolStripMenuItem.Text = "Отображение по вертикали";
            this.отображениеПоВертикалиToolStripMenuItem.Click += new System.EventHandler(this.отображениеПоВертикалиToolStripMenuItem_Click);
            // 
            // нарисоватьToolStripMenuItem
            // 
            this.нарисоватьToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.нарисоватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.надписьToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.прямоугольникToolStripMenuItem,
            this.эллипсToolStripMenuItem,
            this.возвратККистиToolStripMenuItem});
            this.нарисоватьToolStripMenuItem.Name = "нарисоватьToolStripMenuItem";
            this.нарисоватьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.нарисоватьToolStripMenuItem.Text = "Нарисовать";
            // 
            // надписьToolStripMenuItem
            // 
            this.надписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.текстНадписиToolStripMenuItem,
            this.нарисоватьToolStripMenuItem1});
            this.надписьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("надписьToolStripMenuItem.Image")));
            this.надписьToolStripMenuItem.Name = "надписьToolStripMenuItem";
            this.надписьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.надписьToolStripMenuItem.Text = "Надпись";
            this.надписьToolStripMenuItem.Click += new System.EventHandler(this.надписьToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("шрифтToolStripMenuItem.Image")));
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // текстНадписиToolStripMenuItem
            // 
            this.текстНадписиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("текстНадписиToolStripMenuItem.Image")));
            this.текстНадписиToolStripMenuItem.Name = "текстНадписиToolStripMenuItem";
            this.текстНадписиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.текстНадписиToolStripMenuItem.Text = "Текст надписи";
            this.текстНадписиToolStripMenuItem.Click += new System.EventHandler(this.текстНадписиToolStripMenuItem_Click);
            // 
            // нарисоватьToolStripMenuItem1
            // 
            this.нарисоватьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("нарисоватьToolStripMenuItem1.Image")));
            this.нарисоватьToolStripMenuItem1.Name = "нарисоватьToolStripMenuItem1";
            this.нарисоватьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.нарисоватьToolStripMenuItem1.Text = "Нарисовать";
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("линияToolStripMenuItem.Image")));
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.линияToolStripMenuItem_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("прямоугольникToolStripMenuItem.Image")));
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("эллипсToolStripMenuItem.Image")));
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.эллипсToolStripMenuItem.Text = "Эллипс";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // возвратККистиToolStripMenuItem
            // 
            this.возвратККистиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("возвратККистиToolStripMenuItem.Image")));
            this.возвратККистиToolStripMenuItem.Name = "возвратККистиToolStripMenuItem";
            this.возвратККистиToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.возвратККистиToolStripMenuItem.Text = "Возврат к кисти";
            this.возвратККистиToolStripMenuItem.Click += new System.EventHandler(this.возвратККистиToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ластикToolStripMenuItem,
            this.цветФонаToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.инструментыToolStripMenuItem.Text = "Инструмент";
            // 
            // ластикToolStripMenuItem
            // 
            this.ластикToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ластикToolStripMenuItem.Image")));
            this.ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            this.ластикToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ластикToolStripMenuItem.Text = "Ластик";
            this.ластикToolStripMenuItem.Click += new System.EventHandler(this.ластикToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("цветФонаToolStripMenuItem.Image")));
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЦентруToolStripMenuItem,
            this.масштабироватьToolStripMenuItem,
            this.сохранятьПропоцииToolStripMenuItem,
            this.пользовательскоеМасштабированиеToolStripMenuItem,
            this.автоматическийToolStripMenuItem,
            this.реальныйToolStripMenuItem});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            this.масштабToolStripMenuItem.Visible = false;
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поЦентруToolStripMenuItem.Image")));
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            // 
            // масштабироватьToolStripMenuItem
            // 
            this.масштабироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("масштабироватьToolStripMenuItem.Image")));
            this.масштабироватьToolStripMenuItem.Name = "масштабироватьToolStripMenuItem";
            this.масштабироватьToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.масштабироватьToolStripMenuItem.Text = "Масштабировать";
            // 
            // сохранятьПропоцииToolStripMenuItem
            // 
            this.сохранятьПропоцииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранятьПропоцииToolStripMenuItem.Image")));
            this.сохранятьПропоцииToolStripMenuItem.Name = "сохранятьПропоцииToolStripMenuItem";
            this.сохранятьПропоцииToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.сохранятьПропоцииToolStripMenuItem.Text = "Сохранять пропоции";
            // 
            // пользовательскоеМасштабированиеToolStripMenuItem
            // 
            this.пользовательскоеМасштабированиеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательскоеМасштабированиеToolStripMenuItem.Image")));
            this.пользовательскоеМасштабированиеToolStripMenuItem.Name = "пользовательскоеМасштабированиеToolStripMenuItem";
            this.пользовательскоеМасштабированиеToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.пользовательскоеМасштабированиеToolStripMenuItem.Text = "Пользовательское масштабирование";
            // 
            // автоматическийToolStripMenuItem
            // 
            this.автоматическийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("автоматическийToolStripMenuItem.Image")));
            this.автоматическийToolStripMenuItem.Name = "автоматическийToolStripMenuItem";
            this.автоматическийToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.автоматическийToolStripMenuItem.Text = "Автоматический";
            // 
            // реальныйToolStripMenuItem
            // 
            this.реальныйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("реальныйToolStripMenuItem.Image")));
            this.реальныйToolStripMenuItem.Name = "реальныйToolStripMenuItem";
            this.реальныйToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.реальныйToolStripMenuItem.Text = "Реальный";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.";
            this.saveFileDialog1.Filter = "bmp|*.bmp|jpg|*.jpg|png|*.png|gif|*.gif|tif|*.tif*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = " ";
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(385, 0);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(25, 25);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(509, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.OldLace;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(414, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(91, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(323, 1);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(21, 23);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(298, 1);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(21, 23);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(348, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "100%";
            // 
            // easel
            // 
            this.easel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easel.AutoScroll = true;
            this.easel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.easel.Location = new System.Drawing.Point(0, 27);
            this.easel.Margin = new System.Windows.Forms.Padding(2);
            this.easel.Name = "easel";
            this.easel.Size = new System.Drawing.Size(636, 362);
            this.easel.TabIndex = 9;
            this.easel.Resize += new System.EventHandler(this.easel_Resize);
            // 
            // LayersPanel
            // 
            this.LayersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayersPanel.AutoScroll = true;
            this.LayersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LayersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayersPanel.Location = new System.Drawing.Point(641, 27);
            this.LayersPanel.Name = "LayersPanel";
            this.LayersPanel.Size = new System.Drawing.Size(130, 333);
            this.LayersPanel.TabIndex = 3;
            this.LayersPanel.WrapContents = false;
            // 
            // addLayerButton
            // 
            this.addLayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addLayerButton.Location = new System.Drawing.Point(641, 366);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(60, 23);
            this.addLayerButton.TabIndex = 4;
            this.addLayerButton.Text = "+Слой";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // removeLayerButton
            // 
            this.removeLayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLayerButton.Location = new System.Drawing.Point(707, 366);
            this.removeLayerButton.Name = "removeLayerButton";
            this.removeLayerButton.Size = new System.Drawing.Size(60, 23);
            this.removeLayerButton.TabIndex = 5;
            this.removeLayerButton.Text = "-Слой";
            this.removeLayerButton.UseVisualStyleBackColor = true;
            this.removeLayerButton.Click += new System.EventHandler(this.removeLayerButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(539, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(25, 25);
            this.undoButton.TabIndex = 10;
            this.undoButton.Text = "<-";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(570, 0);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(25, 25);
            this.redoButton.TabIndex = 11;
            this.redoButton.Text = "->";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // сохранитьПроектToolStripMenuItem
            // 
            this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
            this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
            this.сохранитьПроектToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПроектToolStripMenuItem_Click);
            // 
            // открытьПроектToolStripMenuItem
            // 
            this.открытьПроектToolStripMenuItem.Name = "открытьПроектToolStripMenuItem";
            this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.открытьПроектToolStripMenuItem.Text = "Открыть проект";
            this.открытьПроектToolStripMenuItem.Click += new System.EventHandler(this.открытьПроектToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 400);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addLayerButton);
            this.Controls.Add(this.removeLayerButton);
            this.Controls.Add(this.easel);
            this.Controls.Add(this.LayersPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Форма";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затемнитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осветлитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смешатьСДругимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вправоНа90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem влевоНа90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображениеПоГоризонталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображениеПоВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранятьПропоцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательскоеМасштабированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстНадписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возвратККистиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реальныйToolStripMenuItem;
        private System.Windows.Forms.Panel easel;
        private System.Windows.Forms.FlowLayoutPanel LayersPanel;
        private System.Windows.Forms.Button removeLayerButton;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.ToolStripMenuItem createCanvasToolTip;
        private System.Windows.Forms.ToolStripTextBox widthCanvasText;
        private System.Windows.Forms.ToolStripTextBox heightCanvasText;
        private System.Windows.Forms.ToolStripMenuItem createCanvasButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСлойКакToolStripMenuItem;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПроектToolStripMenuItem;
    }
}