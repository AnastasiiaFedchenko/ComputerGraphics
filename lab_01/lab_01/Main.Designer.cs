namespace lab_01
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            информацияToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            обАвтореToolStripMenuItem = new ToolStripMenuItem();
            добавитьТочкуВПервоеМножествоToolStripMenuItem = new ToolStripMenuItem();
            добавитьТочкуToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            посчитатьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { информацияToolStripMenuItem, добавитьТочкуВПервоеМножествоToolStripMenuItem, добавитьТочкуToolStripMenuItem, toolStripMenuItem1, toolStripComboBox1, посчитатьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1474, 66);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, обАвтореToolStripMenuItem });
            информацияToolStripMenuItem.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Padding = new Padding(8);
            информацияToolStripMenuItem.Size = new Size(264, 62);
            информацияToolStripMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(381, 50);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // обАвтореToolStripMenuItem
            // 
            обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            обАвтореToolStripMenuItem.Size = new Size(381, 50);
            обАвтореToolStripMenuItem.Text = "Об авторе";
            обАвтореToolStripMenuItem.Click += обАвтореToolStripMenuItem_Click;
            // 
            // добавитьТочкуВПервоеМножествоToolStripMenuItem
            // 
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Name = "добавитьТочкуВПервоеМножествоToolStripMenuItem";
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Padding = new Padding(8);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Size = new Size(301, 62);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Text = "Добавить точку";
            добавитьТочкуВПервоеМножествоToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Click += добавитьТочкуВПервоеМножествоToolStripMenuItem_Click;
            // 
            // добавитьТочкуToolStripMenuItem
            // 
            добавитьТочкуToolStripMenuItem.Name = "добавитьТочкуToolStripMenuItem";
            добавитьТочкуToolStripMenuItem.Size = new Size(20, 62);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(20, 62);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = SystemColors.Window;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.DropDownWidth = 121;
            toolStripComboBox1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripComboBox1.ForeColor = Color.Black;
            toolStripComboBox1.Items.AddRange(new object[] { "1-ое множество", "2-ое множество" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.RightToLeft = RightToLeft.No;
            toolStripComboBox1.Size = new Size(320, 62);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // посчитатьToolStripMenuItem
            // 
            посчитатьToolStripMenuItem.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            посчитатьToolStripMenuItem.Name = "посчитатьToolStripMenuItem";
            посчитатьToolStripMenuItem.Size = new Size(218, 62);
            посчитатьToolStripMenuItem.Text = "Посчитать";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1474, 1495);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = " Лабораторная работа №1";
            Load += Form1_Load;
            Paint += Main_Paint;
            MouseDoubleClick += Main_MouseDoubleClick;
            MouseDown += Main_MouseDown;
            MouseMove += Main_MouseMove;
            MouseUp += Main_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem информацияToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem обАвтореToolStripMenuItem;
        private ToolStripMenuItem добавитьТочкуВПервоеМножествоToolStripMenuItem;
        private ToolStripMenuItem добавитьТочкуToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem посчитатьToolStripMenuItem;
    }
}