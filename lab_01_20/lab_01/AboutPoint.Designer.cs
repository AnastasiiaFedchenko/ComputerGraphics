using System.Drawing;
using System.Windows.Forms;

namespace lab_01
{
    partial class AboutPoint
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 42);
            label1.TabIndex = 0;
            label1.Text = "Множество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 42);
            label2.TabIndex = 1;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 42);
            label3.TabIndex = 2;
            label3.Text = "Y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(250, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 42);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(250, 61);
            label5.Name = "label5";
            label5.Size = new Size(0, 42);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(250, 116);
            label6.Name = "label6";
            label6.Size = new Size(0, 42);
            label6.TabIndex = 5;
            // 
            // AboutPoint
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 183);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AboutPoint";
            StartPosition = FormStartPosition.Manual;
            Text = "AboutPoint";
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