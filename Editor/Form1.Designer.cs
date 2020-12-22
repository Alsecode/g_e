namespace Editor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеФормToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткаВертикальToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плиткаГоризонтальToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.расположениеФормToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // расположениеФормToolStripMenuItem
            // 
            this.расположениеФормToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадToolStripMenuItem,
            this.плиткаВертикальToolStripMenuItem,
            this.плиткаГоризонтальToolStripMenuItem});
            this.расположениеФормToolStripMenuItem.Name = "расположениеФормToolStripMenuItem";
            this.расположениеФормToolStripMenuItem.Size = new System.Drawing.Size(174, 27);
            this.расположениеФормToolStripMenuItem.Text = "Расположение форм";
            // 
            // каскадToolStripMenuItem
            // 
            this.каскадToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("каскадToolStripMenuItem.Image")));
            this.каскадToolStripMenuItem.Name = "каскадToolStripMenuItem";
            this.каскадToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.каскадToolStripMenuItem.Text = "Каскад";
            this.каскадToolStripMenuItem.Click += new System.EventHandler(this.каскадToolStripMenuItem_Click);
            // 
            // плиткаВертикальToolStripMenuItem
            // 
            this.плиткаВертикальToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("плиткаВертикальToolStripMenuItem.Image")));
            this.плиткаВертикальToolStripMenuItem.Name = "плиткаВертикальToolStripMenuItem";
            this.плиткаВертикальToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.плиткаВертикальToolStripMenuItem.Text = "Плитка вертикально";
            this.плиткаВертикальToolStripMenuItem.Click += new System.EventHandler(this.плиткаГоризонтальноToolStripMenuItem_Click);
            // 
            // плиткаГоризонтальToolStripMenuItem
            // 
            this.плиткаГоризонтальToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("плиткаГоризонтальToolStripMenuItem.Image")));
            this.плиткаГоризонтальToolStripMenuItem.Name = "плиткаГоризонтальToolStripMenuItem";
            this.плиткаГоризонтальToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.плиткаГоризонтальToolStripMenuItem.Text = "Плитка горизонтально";
            this.плиткаГоризонтальToolStripMenuItem.Click += new System.EventHandler(this.плиткаВертикальноToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(111, 132);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 132);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Открытые окна";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Главная";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem расположениеФормToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плиткаВертикальToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плиткаГоризонтальToolStripMenuItem;
    }
}

