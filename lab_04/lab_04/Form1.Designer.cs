namespace lab_04
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
            this.AmountOfFiguresTextBox = new System.Windows.Forms.TextBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.RxTextBox = new System.Windows.Forms.TextBox();
            this.RyTextBox = new System.Windows.Forms.TextBox();
            this.AmountOfFiguresLabel = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.StepLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.RxLabel = new System.Windows.Forms.Label();
            this.OyLabel = new System.Windows.Forms.Label();
            this.RyLabel = new System.Windows.Forms.Label();
            this.OxLabel = new System.Windows.Forms.Label();
            this.OyTextBox = new System.Windows.Forms.TextBox();
            this.OxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuildWhatComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BresenhamRadioButton = new System.Windows.Forms.RadioButton();
            this.LibraryRadioButton = new System.Windows.Forms.RadioButton();
            this.ParametricRadioButton = new System.Windows.Forms.RadioButton();
            this.CanonicRadioButton = new System.Windows.Forms.RadioButton();
            this.Create = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.LineColorLabel = new System.Windows.Forms.Label();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1954, 48);
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
            this.CompareTimeToolStripMenuItem.Size = new System.Drawing.Size(686, 40);
            this.CompareTimeToolStripMenuItem.Text = "Сравнение времени построения окружности";
            this.CompareTimeToolStripMenuItem.Click += new System.EventHandler(this.CompareTimeToolStripMenuItem_Click);
            // 
            // CompareGradationToolStripMenuItem
            // 
            this.CompareGradationToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.CompareGradationToolStripMenuItem.Name = "CompareGradationToolStripMenuItem";
            this.CompareGradationToolStripMenuItem.Size = new System.Drawing.Size(638, 40);
            this.CompareGradationToolStripMenuItem.Text = "Сравнение времени построения эллипса";
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
            this.groupBox1.Controls.Add(this.AmountOfFiguresTextBox);
            this.groupBox1.Controls.Add(this.StepTextBox);
            this.groupBox1.Controls.Add(this.RxTextBox);
            this.groupBox1.Controls.Add(this.RyTextBox);
            this.groupBox1.Controls.Add(this.AmountOfFiguresLabel);
            this.groupBox1.Controls.Add(this.RTextBox);
            this.groupBox1.Controls.Add(this.StepLabel);
            this.groupBox1.Controls.Add(this.RLabel);
            this.groupBox1.Controls.Add(this.RxLabel);
            this.groupBox1.Controls.Add(this.OyLabel);
            this.groupBox1.Controls.Add(this.RyLabel);
            this.groupBox1.Controls.Add(this.OxLabel);
            this.groupBox1.Controls.Add(this.OyTextBox);
            this.groupBox1.Controls.Add(this.OxTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BuildWhatComboBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.Clear);
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
            // AmountOfFiguresTextBox
            // 
            this.AmountOfFiguresTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountOfFiguresTextBox.Location = new System.Drawing.Point(25, 652);
            this.AmountOfFiguresTextBox.Name = "AmountOfFiguresTextBox";
            this.AmountOfFiguresTextBox.Size = new System.Drawing.Size(198, 44);
            this.AmountOfFiguresTextBox.TabIndex = 12;
            this.AmountOfFiguresTextBox.Text = "15";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepTextBox.Location = new System.Drawing.Point(25, 566);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(198, 44);
            this.StepTextBox.TabIndex = 11;
            this.StepTextBox.Text = "5";
            // 
            // RxTextBox
            // 
            this.RxTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RxTextBox.Location = new System.Drawing.Point(166, 462);
            this.RxTextBox.Name = "RxTextBox";
            this.RxTextBox.Size = new System.Drawing.Size(198, 44);
            this.RxTextBox.TabIndex = 10;
            this.RxTextBox.Text = "70";
            // 
            // RyTextBox
            // 
            this.RyTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RyTextBox.Location = new System.Drawing.Point(166, 403);
            this.RyTextBox.Name = "RyTextBox";
            this.RyTextBox.Size = new System.Drawing.Size(198, 44);
            this.RyTextBox.TabIndex = 2;
            this.RyTextBox.Text = "100";
            // 
            // AmountOfFiguresLabel
            // 
            this.AmountOfFiguresLabel.AutoSize = true;
            this.AmountOfFiguresLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountOfFiguresLabel.Location = new System.Drawing.Point(19, 613);
            this.AmountOfFiguresLabel.Name = "AmountOfFiguresLabel";
            this.AmountOfFiguresLabel.Size = new System.Drawing.Size(290, 36);
            this.AmountOfFiguresLabel.TabIndex = 5;
            this.AmountOfFiguresLabel.Text = "Количество фигур:";
            // 
            // RTextBox
            // 
            this.RTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTextBox.Location = new System.Drawing.Point(166, 403);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(199, 44);
            this.RTextBox.TabIndex = 2;
            this.RTextBox.Text = "100";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepLabel.Location = new System.Drawing.Point(19, 520);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(251, 36);
            this.StepLabel.TabIndex = 4;
            this.StepLabel.Text = "Шаг изменения:";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RLabel.Location = new System.Drawing.Point(19, 411);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(129, 36);
            this.RLabel.TabIndex = 2;
            this.RLabel.Text = "Радиус:";
            // 
            // RxLabel
            // 
            this.RxLabel.AutoSize = true;
            this.RxLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RxLabel.Location = new System.Drawing.Point(19, 470);
            this.RxLabel.Name = "RxLabel";
            this.RxLabel.Size = new System.Drawing.Size(141, 36);
            this.RxLabel.TabIndex = 3;
            this.RxLabel.Text = "Ширина:";
            // 
            // OyLabel
            // 
            this.OyLabel.AutoSize = true;
            this.OyLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OyLabel.Location = new System.Drawing.Point(201, 348);
            this.OyLabel.Name = "OyLabel";
            this.OyLabel.Size = new System.Drawing.Size(64, 36);
            this.OyLabel.TabIndex = 9;
            this.OyLabel.Text = "Oy:";
            // 
            // RyLabel
            // 
            this.RyLabel.AutoSize = true;
            this.RyLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RyLabel.Location = new System.Drawing.Point(19, 411);
            this.RyLabel.Name = "RyLabel";
            this.RyLabel.Size = new System.Drawing.Size(132, 36);
            this.RyLabel.TabIndex = 2;
            this.RyLabel.Text = "Высота:";
            // 
            // OxLabel
            // 
            this.OxLabel.AutoSize = true;
            this.OxLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OxLabel.Location = new System.Drawing.Point(12, 348);
            this.OxLabel.Name = "OxLabel";
            this.OxLabel.Size = new System.Drawing.Size(63, 36);
            this.OxLabel.TabIndex = 2;
            this.OxLabel.Text = "Ox:";
            // 
            // OyTextBox
            // 
            this.OyTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OyTextBox.Location = new System.Drawing.Point(269, 343);
            this.OyTextBox.Name = "OyTextBox";
            this.OyTextBox.Size = new System.Drawing.Size(116, 44);
            this.OyTextBox.TabIndex = 8;
            this.OyTextBox.Text = "0";
            // 
            // OxTextBox
            // 
            this.OxTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OxTextBox.Location = new System.Drawing.Point(83, 343);
            this.OxTextBox.Name = "OxTextBox";
            this.OxTextBox.Size = new System.Drawing.Size(116, 44);
            this.OxTextBox.TabIndex = 2;
            this.OxTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Координаты центра:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Построить";
            // 
            // BuildWhatComboBox
            // 
            this.BuildWhatComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildWhatComboBox.FormattingEnabled = true;
            this.BuildWhatComboBox.Items.AddRange(new object[] {
            "Окружность",
            "Эллипс",
            "Спектр окружностей",
            "Спектр эллипсов"});
            this.BuildWhatComboBox.Location = new System.Drawing.Point(12, 45);
            this.BuildWhatComboBox.Name = "BuildWhatComboBox";
            this.BuildWhatComboBox.Size = new System.Drawing.Size(367, 44);
            this.BuildWhatComboBox.TabIndex = 2;
            this.BuildWhatComboBox.SelectedIndexChanged += new System.EventHandler(this.BuildWhatComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BresenhamRadioButton);
            this.groupBox2.Controls.Add(this.LibraryRadioButton);
            this.groupBox2.Controls.Add(this.ParametricRadioButton);
            this.groupBox2.Controls.Add(this.CanonicRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 764);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 309);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Алгоритм постоения";
            // 
            // BresenhamRadioButton
            // 
            this.BresenhamRadioButton.AutoSize = true;
            this.BresenhamRadioButton.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BresenhamRadioButton.Location = new System.Drawing.Point(12, 207);
            this.BresenhamRadioButton.Name = "BresenhamRadioButton";
            this.BresenhamRadioButton.Size = new System.Drawing.Size(341, 37);
            this.BresenhamRadioButton.TabIndex = 5;
            this.BresenhamRadioButton.Text = "Алгоритм Брезенхема";
            this.BresenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // LibraryRadioButton
            // 
            this.LibraryRadioButton.AutoSize = true;
            this.LibraryRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.LibraryRadioButton.Location = new System.Drawing.Point(12, 250);
            this.LibraryRadioButton.Name = "LibraryRadioButton";
            this.LibraryRadioButton.Size = new System.Drawing.Size(236, 37);
            this.LibraryRadioButton.TabIndex = 6;
            this.LibraryRadioButton.Text = "Библиотечная";
            this.LibraryRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParametricRadioButton
            // 
            this.ParametricRadioButton.AutoSize = true;
            this.ParametricRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.ParametricRadioButton.Location = new System.Drawing.Point(12, 131);
            this.ParametricRadioButton.Name = "ParametricRadioButton";
            this.ParametricRadioButton.Size = new System.Drawing.Size(304, 70);
            this.ParametricRadioButton.TabIndex = 3;
            this.ParametricRadioButton.Text = "Параметрического \r\nуравнения";
            this.ParametricRadioButton.UseVisualStyleBackColor = true;
            // 
            // CanonicRadioButton
            // 
            this.CanonicRadioButton.AutoSize = true;
            this.CanonicRadioButton.Checked = true;
            this.CanonicRadioButton.Font = new System.Drawing.Font("Arial", 10.875F);
            this.CanonicRadioButton.Location = new System.Drawing.Point(12, 55);
            this.CanonicRadioButton.Name = "CanonicRadioButton";
            this.CanonicRadioButton.Size = new System.Drawing.Size(252, 70);
            this.CanonicRadioButton.TabIndex = 2;
            this.CanonicRadioButton.TabStop = true;
            this.CanonicRadioButton.Text = "Канонического \r\nуравнения\r\n";
            this.CanonicRadioButton.UseVisualStyleBackColor = true;
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
            // LineColorButton
            // 
            this.LineColorButton.BackColor = System.Drawing.Color.Black;
            this.LineColorButton.Location = new System.Drawing.Point(12, 236);
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
            this.LineColorLabel.Location = new System.Drawing.Point(13, 188);
            this.LineColorLabel.Name = "LineColorLabel";
            this.LineColorLabel.Size = new System.Drawing.Size(186, 36);
            this.LineColorLabel.TabIndex = 2;
            this.LineColorLabel.Text = "Цвет линии";
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.BackColor = System.Drawing.Color.White;
            this.BackgroundColorButton.Location = new System.Drawing.Point(12, 137);
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
            this.label1.Location = new System.Drawing.Point(12, 98);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Label LineColorLabel;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BresenhamRadioButton;
        private System.Windows.Forms.RadioButton LibraryRadioButton;
        private System.Windows.Forms.RadioButton ParametricRadioButton;
        private System.Windows.Forms.RadioButton CanonicRadioButton;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuildWhatComboBox;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label OyLabel;
        private System.Windows.Forms.Label OxLabel;
        private System.Windows.Forms.TextBox OyTextBox;
        private System.Windows.Forms.TextBox OxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Label RyLabel;
        private System.Windows.Forms.Label RxLabel;
        private System.Windows.Forms.Label AmountOfFiguresLabel;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.TextBox RxTextBox;
        private System.Windows.Forms.TextBox RyTextBox;
        private System.Windows.Forms.TextBox AmountOfFiguresTextBox;
        private System.Windows.Forms.TextBox StepTextBox;
    }
}

