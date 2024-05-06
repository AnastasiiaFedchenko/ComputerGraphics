namespace lab_06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddZatravka = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ColorThePictureButton = new System.Windows.Forms.Button();
            this.MakeCircleButton = new System.Windows.Forms.Button();
            this.MakeEllipseButton = new System.Windows.Forms.Button();
            this.RyTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RxTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OyTextBox = new System.Windows.Forms.TextBox();
            this.OxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FillingColorButton = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PointsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddZatravka);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.ColorThePictureButton);
            this.groupBox1.Controls.Add(this.MakeCircleButton);
            this.groupBox1.Controls.Add(this.MakeEllipseButton);
            this.groupBox1.Controls.Add(this.RyTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.RxTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.OyTextBox);
            this.groupBox1.Controls.Add(this.OxTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.AddPointButton);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FillingColorButton);
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 1152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню:";
            // 
            // AddZatravka
            // 
            this.AddZatravka.Location = new System.Drawing.Point(22, 368);
            this.AddZatravka.Name = "AddZatravka";
            this.AddZatravka.Size = new System.Drawing.Size(483, 60);
            this.AddZatravka.TabIndex = 23;
            this.AddZatravka.Text = "Построить затравку";
            this.AddZatravka.UseVisualStyleBackColor = true;
            this.AddZatravka.Click += new System.EventHandler(this.AddZatravka_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 993);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(447, 76);
            this.button9.TabIndex = 22;
            this.button9.Text = "Отчистить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // ColorThePictureButton
            // 
            this.ColorThePictureButton.Location = new System.Drawing.Point(24, 895);
            this.ColorThePictureButton.Name = "ColorThePictureButton";
            this.ColorThePictureButton.Size = new System.Drawing.Size(447, 76);
            this.ColorThePictureButton.TabIndex = 4;
            this.ColorThePictureButton.Text = "Выполнить закраску";
            this.ColorThePictureButton.UseVisualStyleBackColor = true;
            this.ColorThePictureButton.Click += new System.EventHandler(this.ColorThePictureButton_Click);
            // 
            // MakeCircleButton
            // 
            this.MakeCircleButton.Location = new System.Drawing.Point(24, 756);
            this.MakeCircleButton.Name = "MakeCircleButton";
            this.MakeCircleButton.Size = new System.Drawing.Size(225, 133);
            this.MakeCircleButton.TabIndex = 21;
            this.MakeCircleButton.Text = "Построить окружность";
            this.MakeCircleButton.UseVisualStyleBackColor = true;
            this.MakeCircleButton.Click += new System.EventHandler(this.MakeCircleButton_Click);
            // 
            // MakeEllipseButton
            // 
            this.MakeEllipseButton.Location = new System.Drawing.Point(272, 756);
            this.MakeEllipseButton.Name = "MakeEllipseButton";
            this.MakeEllipseButton.Size = new System.Drawing.Size(225, 133);
            this.MakeEllipseButton.TabIndex = 4;
            this.MakeEllipseButton.Text = "Построить эллипс";
            this.MakeEllipseButton.UseVisualStyleBackColor = true;
            this.MakeEllipseButton.Click += new System.EventHandler(this.MakeEllipseButton_Click);
            // 
            // RyTextBox
            // 
            this.RyTextBox.Location = new System.Drawing.Point(344, 695);
            this.RyTextBox.Name = "RyTextBox";
            this.RyTextBox.Size = new System.Drawing.Size(153, 44);
            this.RyTextBox.TabIndex = 19;
            this.RyTextBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 698);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 37);
            this.label13.TabIndex = 20;
            this.label13.Text = "Ry:";
            // 
            // RxTextBox
            // 
            this.RxTextBox.Location = new System.Drawing.Point(344, 634);
            this.RxTextBox.Name = "RxTextBox";
            this.RxTextBox.Size = new System.Drawing.Size(153, 44);
            this.RxTextBox.TabIndex = 17;
            this.RxTextBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 637);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "Rx:";
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(95, 634);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(153, 44);
            this.RTextBox.TabIndex = 15;
            this.RTextBox.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 37);
            this.label11.TabIndex = 16;
            this.label11.Text = "R:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 37);
            this.label10.TabIndex = 14;
            this.label10.Text = "Эллипс:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 37);
            this.label9.TabIndex = 4;
            this.label9.Text = "Окружность:";
            // 
            // OyTextBox
            // 
            this.OyTextBox.Location = new System.Drawing.Point(344, 525);
            this.OyTextBox.Name = "OyTextBox";
            this.OyTextBox.Size = new System.Drawing.Size(153, 44);
            this.OyTextBox.TabIndex = 13;
            this.OyTextBox.Text = "100";
            // 
            // OxTextBox
            // 
            this.OxTextBox.Location = new System.Drawing.Point(95, 522);
            this.OxTextBox.Name = "OxTextBox";
            this.OxTextBox.Size = new System.Drawing.Size(153, 44);
            this.OxTextBox.TabIndex = 10;
            this.OxTextBox.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "OY:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "OX:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 445);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(483, 60);
            this.button5.TabIndex = 9;
            this.button5.Text = "Замкнуть фигуру";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CloseFigureButton_Click);
            // 
            // AddPointButton
            // 
            this.AddPointButton.Location = new System.Drawing.Point(22, 293);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(483, 60);
            this.AddPointButton.TabIndex = 2;
            this.AddPointButton.Text = "Добавить точку";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(329, 236);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(168, 44);
            this.YTextBox.TabIndex = 8;
            this.YTextBox.Text = "101";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(80, 233);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(168, 44);
            this.XTextBox.TabIndex = 2;
            this.XTextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // FillingColorButton
            // 
            this.FillingColorButton.BackColor = System.Drawing.Color.Purple;
            this.FillingColorButton.Location = new System.Drawing.Point(244, 103);
            this.FillingColorButton.Name = "FillingColorButton";
            this.FillingColorButton.Size = new System.Drawing.Size(261, 52);
            this.FillingColorButton.TabIndex = 4;
            this.FillingColorButton.UseVisualStyleBackColor = false;
            this.FillingColorButton.Click += new System.EventHandler(this.FillingColorButton_Click);
            // 
            // LineColorButton
            // 
            this.LineColorButton.BackColor = System.Drawing.Color.Fuchsia;
            this.LineColorButton.Location = new System.Drawing.Point(244, 48);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(261, 52);
            this.LineColorButton.TabIndex = 1;
            this.LineColorButton.UseVisualStyleBackColor = false;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет закраски:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет границ:";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(541, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(863, 1152);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.PictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDoubleClick);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // PointsListBox
            // 
            this.PointsListBox.FormattingEnabled = true;
            this.PointsListBox.ItemHeight = 25;
            this.PointsListBox.Location = new System.Drawing.Point(1419, 57);
            this.PointsListBox.Name = "PointsListBox";
            this.PointsListBox.Size = new System.Drawing.Size(427, 1079);
            this.PointsListBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1422, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Построено:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1171);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PointsListBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FillingColorButton;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox OyTextBox;
        private System.Windows.Forms.TextBox OxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.ListBox PointsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddZatravka;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ColorThePictureButton;
        private System.Windows.Forms.Button MakeCircleButton;
        private System.Windows.Forms.Button MakeEllipseButton;
        private System.Windows.Forms.TextBox RyTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RxTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

