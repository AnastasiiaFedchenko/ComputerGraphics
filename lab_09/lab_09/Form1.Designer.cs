﻿namespace lab_09
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BuildFrame = new System.Windows.Forms.Button();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CutOff = new System.Windows.Forms.Button();
            this.BuildLineButton = new System.Windows.Forms.Button();
            this.YsTextBox = new System.Windows.Forms.TextBox();
            this.XsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultColorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FrameColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.CloseFigureButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseFigureButton);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.BuildFrame);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.CutOff);
            this.groupBox1.Controls.Add(this.BuildLineButton);
            this.groupBox1.Controls.Add(this.YsTextBox);
            this.groupBox1.Controls.Add(this.XsTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ResultColorButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FrameColorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LineColorButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 1063);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(198, 629);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 50);
            this.label15.TabIndex = 22;
            this.label15.Text = "можно добавить \r\nлевой кнопкой мыши";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(186, 390);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 50);
            this.label14.TabIndex = 2;
            this.label14.Text = "можно добавить \r\nправой кнопкой мыши";
            // 
            // BuildFrame
            // 
            this.BuildFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildFrame.Location = new System.Drawing.Point(33, 752);
            this.BuildFrame.Name = "BuildFrame";
            this.BuildFrame.Size = new System.Drawing.Size(351, 54);
            this.BuildFrame.TabIndex = 12;
            this.BuildFrame.Text = "Построить отсекатель";
            this.BuildFrame.UseVisualStyleBackColor = true;
            this.BuildFrame.Click += new System.EventHandler(this.BuildFrame_Click);
            // 
            // YTextBox
            // 
            this.YTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTextBox.Location = new System.Drawing.Point(284, 689);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 44);
            this.YTextBox.TabIndex = 19;
            // 
            // XTextBox
            // 
            this.XTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XTextBox.Location = new System.Drawing.Point(94, 689);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 44);
            this.XTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(215, 696);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 37);
            this.label10.TabIndex = 17;
            this.label10.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(26, 696);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(15, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "Отсекатель:";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(33, 1000);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(351, 54);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Отчистить экран";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CutOff
            // 
            this.CutOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CutOff.Location = new System.Drawing.Point(33, 940);
            this.CutOff.Name = "CutOff";
            this.CutOff.Size = new System.Drawing.Size(351, 54);
            this.CutOff.TabIndex = 1;
            this.CutOff.Text = "Отсечь";
            this.CutOff.UseVisualStyleBackColor = true;
            this.CutOff.Click += new System.EventHandler(this.CutOff_Click);
            // 
            // BuildLineButton
            // 
            this.BuildLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildLineButton.Location = new System.Drawing.Point(33, 512);
            this.BuildLineButton.Name = "BuildLineButton";
            this.BuildLineButton.Size = new System.Drawing.Size(351, 54);
            this.BuildLineButton.TabIndex = 1;
            this.BuildLineButton.Text = "Построить точку";
            this.BuildLineButton.UseVisualStyleBackColor = true;
            this.BuildLineButton.Click += new System.EventHandler(this.BuildLineButton_Click);
            // 
            // YsTextBox
            // 
            this.YsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YsTextBox.Location = new System.Drawing.Point(284, 450);
            this.YsTextBox.Name = "YsTextBox";
            this.YsTextBox.Size = new System.Drawing.Size(100, 44);
            this.YsTextBox.TabIndex = 9;
            // 
            // XsTextBox
            // 
            this.XsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XsTextBox.Location = new System.Drawing.Point(94, 450);
            this.XsTextBox.Name = "XsTextBox";
            this.XsTextBox.Size = new System.Drawing.Size(100, 44);
            this.XsTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(215, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Фигура:";
            // 
            // ResultColorButton
            // 
            this.ResultColorButton.BackColor = System.Drawing.Color.Red;
            this.ResultColorButton.Location = new System.Drawing.Point(22, 328);
            this.ResultColorButton.Name = "ResultColorButton";
            this.ResultColorButton.Size = new System.Drawing.Size(297, 58);
            this.ResultColorButton.TabIndex = 4;
            this.ResultColorButton.UseVisualStyleBackColor = false;
            this.ResultColorButton.Click += new System.EventHandler(this.ResultColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет результата:";
            // 
            // FrameColorButton
            // 
            this.FrameColorButton.BackColor = System.Drawing.Color.Blue;
            this.FrameColorButton.Location = new System.Drawing.Point(22, 213);
            this.FrameColorButton.Name = "FrameColorButton";
            this.FrameColorButton.Size = new System.Drawing.Size(297, 58);
            this.FrameColorButton.TabIndex = 2;
            this.FrameColorButton.UseVisualStyleBackColor = false;
            this.FrameColorButton.Click += new System.EventHandler(this.FrameColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цвет отcекателя:";
            // 
            // LineColorButton
            // 
            this.LineColorButton.BackColor = System.Drawing.Color.Black;
            this.LineColorButton.Location = new System.Drawing.Point(22, 99);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(297, 58);
            this.LineColorButton.TabIndex = 1;
            this.LineColorButton.UseVisualStyleBackColor = false;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет отрезка:";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(464, 37);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1068, 1038);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // CloseFigureButton
            // 
            this.CloseFigureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFigureButton.Location = new System.Drawing.Point(33, 572);
            this.CloseFigureButton.Name = "CloseFigureButton";
            this.CloseFigureButton.Size = new System.Drawing.Size(351, 54);
            this.CloseFigureButton.TabIndex = 2;
            this.CloseFigureButton.Text = "Замкнуть фигуру";
            this.CloseFigureButton.UseVisualStyleBackColor = true;
            this.CloseFigureButton.Click += new System.EventHandler(this.CloseFigureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1080);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Лр 9";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FrameColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultColorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuildFrame;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CutOff;
        private System.Windows.Forms.Button BuildLineButton;
        private System.Windows.Forms.TextBox YsTextBox;
        private System.Windows.Forms.TextBox XsTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.Button CloseFigureButton;
    }
}

