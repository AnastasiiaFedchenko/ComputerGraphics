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
            toolStripComboBox1 = new ToolStripComboBox();
            посчитатьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            autoFocusToolStripMenuItem = new ToolStripMenuItem();
            сбросToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { информацияToolStripMenuItem, добавитьТочкуВПервоеМножествоToolStripMenuItem, toolStripComboBox1, посчитатьToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, autoFocusToolStripMenuItem, сбросToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1470, 60);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, обАвтореToolStripMenuItem });
            информацияToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Padding = new Padding(8);
            информацияToolStripMenuItem.Size = new Size(227, 56);
            информацияToolStripMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(359, 44);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // обАвтореToolStripMenuItem
            // 
            обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            обАвтореToolStripMenuItem.Size = new Size(359, 44);
            обАвтореToolStripMenuItem.Text = "Об авторе";
            обАвтореToolStripMenuItem.Click += обАвтореToolStripMenuItem_Click;
            // 
            // добавитьТочкуВПервоеМножествоToolStripMenuItem
            // 
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Name = "добавитьТочкуВПервоеМножествоToolStripMenuItem";
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Padding = new Padding(8);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Size = new Size(259, 56);
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Text = "Добавить точку";
            добавитьТочкуВПервоеМножествоToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            добавитьТочкуВПервоеМножествоToolStripMenuItem.Click += добавитьТочкуВПервоеМножествоToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = SystemColors.Window;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.DropDownWidth = 121;
            toolStripComboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripComboBox1.ForeColor = Color.Black;
            toolStripComboBox1.Items.AddRange(new object[] { "1-ое множество", "2-ое множество" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.RightToLeft = RightToLeft.No;
            toolStripComboBox1.Size = new Size(320, 56);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // посчитатьToolStripMenuItem
            // 
            посчитатьToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            посчитатьToolStripMenuItem.Name = "посчитатьToolStripMenuItem";
            посчитатьToolStripMenuItem.Size = new Size(189, 56);
            посчитатьToolStripMenuItem.Text = "Посчитать";
            посчитатьToolStripMenuItem.Click += посчитатьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(60, 56);
            toolStripMenuItem2.Text = "+";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(50, 56);
            toolStripMenuItem3.Text = "-";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // autoFocusToolStripMenuItem
            // 
            autoFocusToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autoFocusToolStripMenuItem.Name = "autoFocusToolStripMenuItem";
            autoFocusToolStripMenuItem.Size = new Size(187, 56);
            autoFocusToolStripMenuItem.Text = "AutoFocus";
            autoFocusToolStripMenuItem.Click += autoFocusToolStripMenuItem_Click;
            // 
            // сбросToolStripMenuItem
            // 
            сбросToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            сбросToolStripMenuItem.Size = new Size(125, 56);
            сбросToolStripMenuItem.Text = "Сброс";
            сбросToolStripMenuItem.Click += сбросToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1359, 1329);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 1329);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 79);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 1404);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(1470, 1491);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem посчитатьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem autoFocusToolStripMenuItem;
        private ToolStripMenuItem сбросToolStripMenuItem;
    }
}