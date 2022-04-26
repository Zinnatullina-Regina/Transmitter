
using System.Windows.Forms;
using System.IO;

namespace Transmitter
{
    partial class Transmitter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transmitter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.Naming = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new GongSolutions.Shell.ShellTreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.shellView = new GongSolutions.Shell.ShellView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Modified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Forward = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Min);
            this.panel1.Controls.Add(this.Max);
            this.panel1.Controls.Add(this.Naming);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 70);
            this.panel1.TabIndex = 1;
            // 
            // Min
            // 
            this.Min.Image = global::Transmitter.Properties.Resources.Space;
            this.Min.Location = new System.Drawing.Point(956, 15);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(22, 19);
            this.Min.TabIndex = 12;
            this.Min.TabStop = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Max
            // 
            this.Max.Image = global::Transmitter.Properties.Resources.Square;
            this.Max.Location = new System.Drawing.Point(1003, 15);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(22, 19);
            this.Max.TabIndex = 11;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Naming
            // 
            this.Naming.AutoSize = true;
            this.Naming.Location = new System.Drawing.Point(111, 15);
            this.Naming.Name = "Naming";
            this.Naming.Size = new System.Drawing.Size(72, 17);
            this.Naming.TabIndex = 10;
            this.Naming.Text = "Поводник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "|";
            // 
            // Exit
            // 
            this.Exit.Image = global::Transmitter.Properties.Resources.comp;
            this.Exit.Location = new System.Drawing.Point(1051, 15);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 19);
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.menuStrip2);
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 28);
            this.panel4.TabIndex = 5;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(948, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Image = global::Transmitter.Properties.Resources.Вопрос;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Transmitter.Properties.Resources.Вопрос;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Image = global::Transmitter.Properties.Resources.Вопрос;
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::Transmitter.Properties.Resources.Close;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Transmitter.Properties.Resources.comp;
            this.pictureBox3.Location = new System.Drawing.Point(72, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 21);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Transmitter.Properties.Resources.comp;
            this.pictureBox2.Location = new System.Drawing.Point(46, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transmitter.Properties.Resources.comp;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 565);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.shellView);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 565);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(331, 565);
            this.treeView.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(331, 565);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "open_folder_file");
            this.imageList1.Images.SetKeyName(1, "document");
            // 
            // shellView
            // 
            this.shellView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellView.Location = new System.Drawing.Point(0, 0);
            this.shellView.Name = "shellView";
            this.shellView.Size = new System.Drawing.Size(755, 565);
            this.shellView.StatusBar = null;
            this.shellView.TabIndex = 1;
            this.shellView.Text = "shellView1";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.Type,
            this.Last_Modified});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 565);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Names
            // 
            this.Names.Text = "Имя";
            this.Names.Width = 190;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 211;
            // 
            // Last_Modified
            // 
            this.Last_Modified.Text = "Дата изменения";
            this.Last_Modified.Width = 231;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 39);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.Forward);
            this.panel5.Controls.Add(this.Back);
            this.panel5.Location = new System.Drawing.Point(2, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1088, 40);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Transmitter.Properties.Resources.Вопрос;
            this.pictureBox5.Location = new System.Drawing.Point(1039, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 29);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.White;
            this.Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forward.Font = new System.Drawing.Font("Wingdings 3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Forward.Location = new System.Drawing.Point(47, -2);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(51, 40);
            this.Forward.TabIndex = 1;
            this.Forward.Text = "4";
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Wingdings 3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Back.Location = new System.Drawing.Point(-2, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 40);
            this.Back.TabIndex = 0;
            this.Back.Text = "3";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Transmitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 708);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transmitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Last_Modified;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem1;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private PictureBox Exit;
        private Label label1;
        private Label Naming;
        private Panel panel5;
        private Button Forward;
        private Button Back;
        private PictureBox pictureBox5;
        private PictureBox Min;
        private PictureBox Max;
        private GongSolutions.Shell.ShellTreeView treeView;
        private GongSolutions.Shell.ShellView shellView;
    }
}

