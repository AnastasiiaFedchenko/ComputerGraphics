namespace lab_01
{
    partial class AboutAuthor
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(374, 42);
            label1.TabIndex = 0;
            label1.Text = "Федченко Анастасия";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(165, 42);
            label2.TabIndex = 1;
            label2.Text = "ИУ7-45б";
            // 
            // AboutAuthor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(432, 154);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AboutAuthor";
            Text = "Об авторе";
            Load += AboutAuthor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}