namespace lab_03
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareGradationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DegreeTextBox = new System.Windows.Forms.TextBox();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.LineLengthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SpectrumRadioButton = new System.Windows.Forms.RadioButton();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.LineLengthLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WuRadioButton = new System.Windows.Forms.RadioButton();
            this.LibraryRadioButton = new System.Windows.Forms.RadioButton();
            this.BsRadioButton = new System.Windows.Forms.RadioButton();
            this.BiRadioButton = new System.Windows.Forms.RadioButton();
            this.BfRadioButton = new System.Windows.Forms.RadioButton();
            this.DDARadioButton = new System.Windows.Forms.RadioButton();
            this.Create = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.YfTextBox = new System.Windows.Forms.TextBox();
            this.XfTextBox = new System.Windows.Forms.TextBox();
            this.YfLabel = new System.Windows.Forms.Label();
            this.XfLabel = new System.Windows.Forms.Label();
            this.YsTextBox = new System.Windows.Forms.TextBox();
            this.XsTextBox = new System.Windows.Forms.TextBox();
            this.YsLabel = new System.Windows.Forms.Label();
            this.XsLabel = new System.Windows.Forms.Label();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.LineColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.CompareTimeToolStripMenuItem,
            this.CompareGradationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1954, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(447, 40);
            this.toolStripMenuItem1.Text = "                                                           ";
            // 
            // CompareTimeToolStripMenuItem
            // 
            this.CompareTimeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.CompareTimeToolStripMenuItem.Name = "CompareTimeToolStripMenuItem";
            this.CompareTimeToolStripMenuItem.Size = new System.Drawing.Size(330, 40);
            this.CompareTimeToolStripMenuItem.Text = "Сравнение времени";
            this.CompareTimeToolStripMenuItem.Click += new System.EventHandler(this.CompareTimeToolStripMenuItem_Click);
            // 
            // CompareGradationToolStripMenuItem
            // 
            this.CompareGradationToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.CompareGradationToolStripMenuItem.Name = "CompareGradationToolStripMenuItem";
            this.CompareGradationToolStripMenuItem.Size = new System.Drawing.Size(417, 40);
            this.CompareGradationToolStripMenuItem.Text = "Сравнение ступенчатости";
            this.CompareGradationToolStripMenuItem.Click += new System.EventHandler(this.CompareGradationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 40);
            this.toolStripMenuItem2.Text = "+";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 40);
            this.toolStripMenuItem3.Text = "--";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.DegreeTextBox);
            this.groupBox1.Controls.Add(this.DegreeLabel);
            this.groupBox1.Controls.Add(this.LineLengthTextBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LineLengthLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.YfTextBox);
            this.groupBox1.Controls.Add(this.XfTextBox);
            this.groupBox1.Controls.Add(this.YfLabel);
            this.groupBox1.Controls.Add(this.XfLabel);
            this.groupBox1.Controls.Add(this.YsTextBox);
            this.groupBox1.Controls.Add(this.XsTextBox);
            this.groupBox1.Controls.Add(this.YsLabel);
            this.groupBox1.Controls.Add(this.XsLabel);
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.LineColorLabel);
            this.groupBox1.Controls.Add(this.BackgroundColorButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 1207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // DegreeTextBox
            // 
            this.DegreeTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.DegreeTextBox.Location = new System.Drawing.Point(18, 470);
            this.DegreeTextBox.Name = "DegreeTextBox";
            this.DegreeTextBox.Size = new System.Drawing.Size(312, 44);
            this.DegreeTextBox.TabIndex = 4;
            this.DegreeTextBox.Text = "1";
            this.DegreeTextBox.Visible = false;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.DegreeLabel.Location = new System.Drawing.Point(16, 431);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(230, 36);
            this.DegreeLabel.TabIndex = 2;
            this.DegreeLabel.Text = "Угол поворота:";
            this.DegreeLabel.Visible = false;
            // 
            // LineLengthTextBox
            // 
            this.LineLengthTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.LineLengthTextBox.Location = new System.Drawing.Point(18, 377);
            this.LineLengthTextBox.Name = "LineLengthTextBox";
            this.LineLengthTextBox.Size = new System.Drawing.Size(312, 44);
            this.LineLengthTextBox.TabIndex = 3;
            this.LineLengthTextBox.Text = "100";
            this.LineLengthTextBox.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SpectrumRadioButton);
            this.groupBox3.Controls.Add(this.LineRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(18, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // SpectrumRadioButton
            // 
            this.SpectrumRadioButton.AutoSize = true;
            this.SpectrumRadioButton.Location = new System.Drawing.Point(6, 77);
            this.SpectrumRadioButton.Name = "SpectrumRadioButton";
            this.SpectrumRadioButton.Size = new System.Drawing.Size(356, 46);
            this.SpectrumRadioButton.TabIndex = 2;
            this.SpectrumRadioButton.Text = "Построить спектр";
            this.SpectrumRadioButton.UseVisualStyleBackColor = true;
            this.SpectrumRadioButton.CheckedChanged += new System.EventHandler(this.SpectrumRadioButton_CheckedChanged);
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.AutoSize = true;
            this.LineRadioButton.Checked = true;
            this.LineRadioButton.Location = new System.Drawing.Point(6, 25);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(355, 46);
            this.LineRadioButton.TabIndex = 2;
            this.LineRadioButton.TabStop = true;
            this.LineRadioButton.Text = "Построить линию";
            this.LineRadioButton.UseVisualStyleBackColor = true;
            this.LineRadioButton.CheckedChanged += new System.EventHandler(this.LineRadioButton_CheckedChanged);
            // 
            // LineLengthLabel
            // 
            this.LineLengthLabel.AutoSize = true;
            this.LineLengthLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.LineLengthLabel.Location = new System.Drawing.Point(12, 338);
            this.LineLengthLabel.Name = "LineLengthLabel";
            this.LineLengthLabel.Size = new System.Drawing.Size(218, 36);
            this.LineLengthLabel.TabIndex = 2;
            this.LineLengthLabel.Text = "Длина линии:";
            this.LineLengthLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WuRadioButton);
            this.groupBox2.Controls.Add(this.LibraryRadioButton);
            this.groupBox2.Controls.Add(this.BsRadioButton);
            this.groupBox2.Controls.Add(this.BiRadioButton);
            this.groupBox2.Controls.Add(this.BfRadioButton);
            this.groupBox2.Controls.Add(this.DDARadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 518);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Алгоритм постоения";
            // 
            // WuRadioButton
            // 
            this.WuRadioButton.AutoSize = true;
            this.WuRadioButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WuRadioButton.Location = new System.Drawing.Point(18, 387);
            this.WuRadioButton.Name = "WuRadioButton";
            this.WuRadioButton.Size = new System.Drawing.Size(78, 37);
            this.WuRadioButton.TabIndex = 5;
            this.WuRadioButton.Text = "Ву";
            this.WuRadioButton.UseVisualStyleBackColor = true;
            // 
            // LibraryRadioButton
            // 
            this.LibraryRadioButton.AutoSize = true;
            this.LibraryRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.LibraryRadioButton.Location = new System.Drawing.Point(18, 455);
            this.LibraryRadioButton.Name = "LibraryRadioButton";
            this.LibraryRadioButton.Size = new System.Drawing.Size(236, 37);
            this.LibraryRadioButton.TabIndex = 6;
            this.LibraryRadioButton.Text = "Библиотечная";
            this.LibraryRadioButton.UseVisualStyleBackColor = true;
            // 
            // BsRadioButton
            // 
            this.BsRadioButton.AutoSize = true;
            this.BsRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.BsRadioButton.Location = new System.Drawing.Point(12, 257);
            this.BsRadioButton.Name = "BsRadioButton";
            this.BsRadioButton.Size = new System.Drawing.Size(260, 103);
            this.BsRadioButton.TabIndex = 4;
            this.BsRadioButton.Text = "Брезенхем \r\n(с устранением \r\nступенчатости)";
            this.BsRadioButton.UseVisualStyleBackColor = true;
            // 
            // BiRadioButton
            // 
            this.BiRadioButton.AutoSize = true;
            this.BiRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.BiRadioButton.Location = new System.Drawing.Point(12, 190);
            this.BiRadioButton.Name = "BiRadioButton";
            this.BiRadioButton.Size = new System.Drawing.Size(307, 37);
            this.BiRadioButton.TabIndex = 3;
            this.BiRadioButton.Text = "Брезенхем (integer)";
            this.BiRadioButton.UseVisualStyleBackColor = true;
            // 
            // BfRadioButton
            // 
            this.BfRadioButton.AutoSize = true;
            this.BfRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.BfRadioButton.Location = new System.Drawing.Point(18, 128);
            this.BfRadioButton.Name = "BfRadioButton";
            this.BfRadioButton.Size = new System.Drawing.Size(273, 37);
            this.BfRadioButton.TabIndex = 2;
            this.BfRadioButton.Text = "Брезенхем (float)";
            this.BfRadioButton.UseVisualStyleBackColor = true;
            // 
            // DDARadioButton
            // 
            this.DDARadioButton.AutoSize = true;
            this.DDARadioButton.Checked = true;
            this.DDARadioButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DDARadioButton.Location = new System.Drawing.Point(18, 67);
            this.DDARadioButton.Name = "DDARadioButton";
            this.DDARadioButton.Size = new System.Drawing.Size(106, 37);
            this.DDARadioButton.TabIndex = 2;
            this.DDARadioButton.TabStop = true;
            this.DDARadioButton.Text = "ЦДА";
            this.DDARadioButton.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(18, 1079);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(346, 57);
            this.Create.TabIndex = 7;
            this.Create.Text = "Построить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(18, 1142);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(346, 57);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Отчистить экран";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // YfTextBox
            // 
            this.YfTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.YfTextBox.Location = new System.Drawing.Point(186, 470);
            this.YfTextBox.Name = "YfTextBox";
            this.YfTextBox.Size = new System.Drawing.Size(144, 44);
            this.YfTextBox.TabIndex = 3;
            // 
            // XfTextBox
            // 
            this.XfTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.XfTextBox.Location = new System.Drawing.Point(18, 470);
            this.XfTextBox.Name = "XfTextBox";
            this.XfTextBox.Size = new System.Drawing.Size(144, 44);
            this.XfTextBox.TabIndex = 4;
            // 
            // YfLabel
            // 
            this.YfLabel.AutoSize = true;
            this.YfLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.YfLabel.Location = new System.Drawing.Point(180, 431);
            this.YfLabel.Name = "YfLabel";
            this.YfLabel.Size = new System.Drawing.Size(59, 36);
            this.YfLabel.TabIndex = 5;
            this.YfLabel.Text = "Yк:";
            // 
            // XfLabel
            // 
            this.XfLabel.AutoSize = true;
            this.XfLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.XfLabel.Location = new System.Drawing.Point(12, 431);
            this.XfLabel.Name = "XfLabel";
            this.XfLabel.Size = new System.Drawing.Size(59, 36);
            this.XfLabel.TabIndex = 6;
            this.XfLabel.Text = "Xк:";
            // 
            // YsTextBox
            // 
            this.YsTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.YsTextBox.Location = new System.Drawing.Point(186, 377);
            this.YsTextBox.Name = "YsTextBox";
            this.YsTextBox.Size = new System.Drawing.Size(144, 44);
            this.YsTextBox.TabIndex = 2;
            // 
            // XsTextBox
            // 
            this.XsTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.XsTextBox.Location = new System.Drawing.Point(18, 377);
            this.XsTextBox.Name = "XsTextBox";
            this.XsTextBox.Size = new System.Drawing.Size(144, 44);
            this.XsTextBox.TabIndex = 2;
            // 
            // YsLabel
            // 
            this.YsLabel.AutoSize = true;
            this.YsLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.YsLabel.Location = new System.Drawing.Point(180, 338);
            this.YsLabel.Name = "YsLabel";
            this.YsLabel.Size = new System.Drawing.Size(63, 36);
            this.YsLabel.TabIndex = 2;
            this.YsLabel.Text = "Yн:";
            // 
            // XsLabel
            // 
            this.XsLabel.AutoSize = true;
            this.XsLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.XsLabel.Location = new System.Drawing.Point(12, 338);
            this.XsLabel.Name = "XsLabel";
            this.XsLabel.Size = new System.Drawing.Size(63, 36);
            this.XsLabel.TabIndex = 2;
            this.XsLabel.Text = "Xн:";
            // 
            // LineColorButton
            // 
            this.LineColorButton.BackColor = System.Drawing.Color.Black;
            this.LineColorButton.Location = new System.Drawing.Point(12, 287);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(253, 48);
            this.LineColorButton.TabIndex = 2;
            this.LineColorButton.UseVisualStyleBackColor = false;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // LineColorLabel
            // 
            this.LineColorLabel.AutoSize = true;
            this.LineColorLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.LineColorLabel.Location = new System.Drawing.Point(12, 248);
            this.LineColorLabel.Name = "LineColorLabel";
            this.LineColorLabel.Size = new System.Drawing.Size(186, 36);
            this.LineColorLabel.TabIndex = 2;
            this.LineColorLabel.Text = "Цвет линии";
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.BackColor = System.Drawing.Color.White;
            this.BackgroundColorButton.Location = new System.Drawing.Point(12, 197);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(253, 48);
            this.BackgroundColorButton.TabIndex = 2;
            this.BackgroundColorButton.UseVisualStyleBackColor = false;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет фона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1954, 1259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CompareTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompareGradationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox YsTextBox;
        private System.Windows.Forms.TextBox XsTextBox;
        private System.Windows.Forms.Label YsLabel;
        private System.Windows.Forms.Label XsLabel;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Label LineColorLabel;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox YfTextBox;
        private System.Windows.Forms.TextBox XfTextBox;
        private System.Windows.Forms.Label YfLabel;
        private System.Windows.Forms.Label XfLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton WuRadioButton;
        private System.Windows.Forms.RadioButton LibraryRadioButton;
        private System.Windows.Forms.RadioButton BiRadioButton;
        private System.Windows.Forms.RadioButton BsRadioButton;
        private System.Windows.Forms.RadioButton BfRadioButton;
        private System.Windows.Forms.RadioButton DDARadioButton;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SpectrumRadioButton;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox LineLengthTextBox;
        private System.Windows.Forms.Label LineLengthLabel;
        private System.Windows.Forms.TextBox DegreeTextBox;
        private System.Windows.Forms.Label DegreeLabel;
    }
}

