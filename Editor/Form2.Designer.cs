﻿namespace Editor
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.canvas = new System.Windows.Forms.PictureBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.затемнитьИзображениеToolStripMenuItem,
            this.осветлитьИзображениеToolStripMenuItem,
            this.смешатьСДругимToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // затемнитьИзображениеToolStripMenuItem
            // 
            this.затемнитьИзображениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("затемнитьИзображениеToolStripMenuItem.Image")));
            this.затемнитьИзображениеToolStripMenuItem.Name = "затемнитьИзображениеToolStripMenuItem";
            this.затемнитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.затемнитьИзображениеToolStripMenuItem.Text = "Затемнить изображение";
            this.затемнитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.затемнитьИзображениеToolStripMenuItem_Click);
            // 
            // осветлитьИзображениеToolStripMenuItem
            // 
            this.осветлитьИзображениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("осветлитьИзображениеToolStripMenuItem.Image")));
            this.осветлитьИзображениеToolStripMenuItem.Name = "осветлитьИзображениеToolStripMenuItem";
            this.осветлитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.осветлитьИзображениеToolStripMenuItem.Text = "Осветлить изображение";
            this.осветлитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.осветлитьИзображениеToolStripMenuItem_Click);
            // 
            // смешатьСДругимToolStripMenuItem
            // 
            this.смешатьСДругимToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("смешатьСДругимToolStripMenuItem.Image")));
            this.смешатьСДругимToolStripMenuItem.Name = "смешатьСДругимToolStripMenuItem";
            this.смешатьСДругимToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
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
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поЦентруToolStripMenuItem.Image")));
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click_1);
            // 
            // масштабироватьToolStripMenuItem
            // 
            this.масштабироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("масштабироватьToolStripMenuItem.Image")));
            this.масштабироватьToolStripMenuItem.Name = "масштабироватьToolStripMenuItem";
            this.масштабироватьToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.масштабироватьToolStripMenuItem.Text = "Масштабировать";
            this.масштабироватьToolStripMenuItem.Click += new System.EventHandler(this.масштабироватьToolStripMenuItem_Click_1);
            // 
            // сохранятьПропоцииToolStripMenuItem
            // 
            this.сохранятьПропоцииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранятьПропоцииToolStripMenuItem.Image")));
            this.сохранятьПропоцииToolStripMenuItem.Name = "сохранятьПропоцииToolStripMenuItem";
            this.сохранятьПропоцииToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.сохранятьПропоцииToolStripMenuItem.Text = "Сохранять пропоции";
            this.сохранятьПропоцииToolStripMenuItem.Click += new System.EventHandler(this.сохранятьПропоцииToolStripMenuItem_Click);
            // 
            // пользовательскоеМасштабированиеToolStripMenuItem
            // 
            this.пользовательскоеМасштабированиеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательскоеМасштабированиеToolStripMenuItem.Image")));
            this.пользовательскоеМасштабированиеToolStripMenuItem.Name = "пользовательскоеМасштабированиеToolStripMenuItem";
            this.пользовательскоеМасштабированиеToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.пользовательскоеМасштабированиеToolStripMenuItem.Text = "Пользовательское масштабирование";
            this.пользовательскоеМасштабированиеToolStripMenuItem.Click += new System.EventHandler(this.пользовательскоеМасштабированиеToolStripMenuItem_Click_1);
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
            this.реальныйToolStripMenuItem.Click += new System.EventHandler(this.реальныйToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.InitialImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(755, 340);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
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
            this.ColorButton.Location = new System.Drawing.Point(476, -1);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(61, 24);
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
            this.label1.Location = new System.Drawing.Point(636, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.OldLace;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(541, -1);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.plusButton.Location = new System.Drawing.Point(412, 0);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.minusButton.Location = new System.Drawing.Point(387, 0);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label3.Location = new System.Drawing.Point(438, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "100%";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.canvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 342);
            this.panel1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Форма";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}