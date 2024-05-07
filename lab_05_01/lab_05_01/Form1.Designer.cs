namespace lab_05_01
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorThePictureButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PointsListBox = new System.Windows.Forms.ListBox();
            this.CloseFigureButton = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(444, 34);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1080, 977);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorThePictureButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.PointsListBox);
            this.groupBox1.Controls.Add(this.CloseFigureButton);
            this.groupBox1.Controls.Add(this.AddPointButton);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ColorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 999);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню:";
            // 
            // ColorThePictureButton
            // 
            this.ColorThePictureButton.Location = new System.Drawing.Point(12, 770);
            this.ColorThePictureButton.Name = "ColorThePictureButton";
            this.ColorThePictureButton.Size = new System.Drawing.Size(384, 117);
            this.ColorThePictureButton.TabIndex = 2;
            this.ColorThePictureButton.Text = "Выполнить закраску";
            this.ColorThePictureButton.UseVisualStyleBackColor = true;
            this.ColorThePictureButton.Click += new System.EventHandler(this.ColorThePictureButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 909);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(384, 54);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Отчистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PointsListBox
            // 
            this.PointsListBox.FormattingEnabled = true;
            this.PointsListBox.ItemHeight = 42;
            this.PointsListBox.Location = new System.Drawing.Point(12, 359);
            this.PointsListBox.Name = "PointsListBox";
            this.PointsListBox.ScrollAlwaysVisible = true;
            this.PointsListBox.Size = new System.Drawing.Size(370, 382);
            this.PointsListBox.TabIndex = 2;
            // 
            // CloseFigureButton
            // 
            this.CloseFigureButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFigureButton.Location = new System.Drawing.Point(12, 295);
            this.CloseFigureButton.Name = "CloseFigureButton";
            this.CloseFigureButton.Size = new System.Drawing.Size(384, 58);
            this.CloseFigureButton.TabIndex = 5;
            this.CloseFigureButton.Text = "Замкнуть фигуру";
            this.CloseFigureButton.UseVisualStyleBackColor = true;
            this.CloseFigureButton.Click += new System.EventHandler(this.CloseFigureButton_Click);
            // 
            // AddPointButton
            // 
            this.AddPointButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPointButton.Location = new System.Drawing.Point(12, 231);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(384, 58);
            this.AddPointButton.TabIndex = 2;
            this.AddPointButton.Text = "Добавить точку";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // YTextBox
            // 
            this.YTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTextBox.Location = new System.Drawing.Point(260, 162);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(122, 44);
            this.YTextBox.TabIndex = 4;
            this.YTextBox.Text = "0";
            // 
            // XTextBox
            // 
            this.XTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XTextBox.Location = new System.Drawing.Point(66, 162);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(122, 44);
            this.XTextBox.TabIndex = 2;
            this.XTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(211, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Fuchsia;
            this.ColorButton.Location = new System.Drawing.Point(12, 98);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(384, 56);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет закраски:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1023);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Button CloseFigureButton;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.ListBox PointsListBox;
        private System.Windows.Forms.Button ColorThePictureButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

