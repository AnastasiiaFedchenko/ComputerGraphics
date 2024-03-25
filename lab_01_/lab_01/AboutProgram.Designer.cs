namespace lab_01
{
    partial class AboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgram));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(994, 160);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(287, 36);
            label2.TabIndex = 1;
            label2.Text = "Решаемая задача:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 289);
            label3.Name = "label3";
            label3.Size = new Size(282, 36);
            label3.TabIndex = 2;
            label3.Text = "Всё про вершины:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 341);
            label4.Name = "label4";
            label4.Size = new Size(929, 224);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 596);
            label5.Name = "label5";
            label5.Size = new Size(392, 36);
            label5.TabIndex = 4;
            label5.Text = "Остальные пункты меню:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 657);
            label6.Name = "label6";
            label6.Size = new Size(886, 192);
            label6.TabIndex = 5;
            label6.Text = resources.GetString("label6.Text");
            // 
            // AboutProgram
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1023, 1168);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AboutProgram";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}