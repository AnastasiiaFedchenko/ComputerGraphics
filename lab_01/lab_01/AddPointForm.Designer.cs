namespace lab_01
{
    partial class AddPointForm
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите множество";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Blue;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(0, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(173, 46);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Второе";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Red;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(6, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(178, 46);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Первое";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(57, 485);
            button1.Name = "button1";
            button1.Size = new Size(296, 80);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 343);
            label1.Name = "label1";
            label1.Size = new Size(53, 42);
            label1.TabIndex = 2;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 425);
            label2.Name = "label2";
            label2.Size = new Size(49, 42);
            label2.TabIndex = 3;
            label2.Text = "Y:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 428);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(419, 49);
            label3.TabIndex = 6;
            label3.Text = "Координатный ввод";
            // 
            // AddPointForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 590);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AddPointForm";
            Text = "AddPointForm";
            Load += AddPointForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}