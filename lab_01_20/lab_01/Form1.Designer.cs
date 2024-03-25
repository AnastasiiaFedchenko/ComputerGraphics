using System.Drawing;
using System.Windows.Forms;

namespace lab_01
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoFocusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationToolStripMenuItem,
            this.AddPointToolStripMenuItem,
            this.SetComboBox,
            this.CalculateToolStripMenuItem,
            this.PlusStripMenuItem,
            this.MinusStripMenuItem,
            this.AutoFocusToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InformationToolStripMenuItem
            // 
            this.InformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem,
            this.AboutAuthorToolStripMenuItem});
            this.InformationToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
            this.InformationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.InformationToolStripMenuItem.Size = new System.Drawing.Size(227, 56);
            this.InformationToolStripMenuItem.Text = "Информация";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(341, 44);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // AboutAuthorToolStripMenuItem
            // 
            this.AboutAuthorToolStripMenuItem.Name = "AboutAuthorToolStripMenuItem";
            this.AboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(341, 44);
            this.AboutAuthorToolStripMenuItem.Text = "Об авторе";
            this.AboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.AboutAuthorToolStripMenuItem_Click);
            // 
            // AddPointToolStripMenuItem
            // 
            this.AddPointToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.AddPointToolStripMenuItem.Name = "AddPointToolStripMenuItem";
            this.AddPointToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.AddPointToolStripMenuItem.Size = new System.Drawing.Size(259, 56);
            this.AddPointToolStripMenuItem.Text = "Добавить точку";
            this.AddPointToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.AddPointToolStripMenuItem.Click += new System.EventHandler(this.AddPointToolStripMenuItem_Click);
            // 
            // SetComboBox
            // 
            this.SetComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetComboBox.DropDownWidth = 121;
            this.SetComboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.SetComboBox.ForeColor = System.Drawing.Color.Black;
            this.SetComboBox.Items.AddRange(new object[] {
            "1-ое множество",
            "2-ое множество"});
            this.SetComboBox.Name = "SetComboBox";
            this.SetComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SetComboBox.Size = new System.Drawing.Size(320, 56);
            this.SetComboBox.SelectedIndexChanged += new System.EventHandler(this.SetComboBox_SelectedIndexChanged);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(189, 56);
            this.CalculateToolStripMenuItem.Text = "Посчитать";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateToolStripMenuItem_Click);
            // 
            // PlusStripMenuItem
            // 
            this.PlusStripMenuItem.Font = new System.Drawing.Font("Arial", 13.875F);
            this.PlusStripMenuItem.Name = "PlusStripMenuItem";
            this.PlusStripMenuItem.Size = new System.Drawing.Size(60, 56);
            this.PlusStripMenuItem.Text = "+";
            this.PlusStripMenuItem.Click += new System.EventHandler(this.PlusStripMenuItem_Click);
            // 
            // MinusStripMenuItem
            // 
            this.MinusStripMenuItem.Font = new System.Drawing.Font("Arial", 13.875F);
            this.MinusStripMenuItem.Name = "MinusStripMenuItem";
            this.MinusStripMenuItem.Size = new System.Drawing.Size(50, 56);
            this.MinusStripMenuItem.Text = "-";
            this.MinusStripMenuItem.Click += new System.EventHandler(this.MinusStripMenuItem_Click);
            // 
            // AutoFocusToolStripMenuItem
            // 
            this.AutoFocusToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.AutoFocusToolStripMenuItem.Name = "AutoFocusToolStripMenuItem";
            this.AutoFocusToolStripMenuItem.Size = new System.Drawing.Size(187, 56);
            this.AutoFocusToolStripMenuItem.Text = "AutoFocus";
            this.AutoFocusToolStripMenuItem.Click += new System.EventHandler(this.AutoFocusToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(125, 56);
            this.ClearToolStripMenuItem.Text = "Сброс";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1359, 1329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 1329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 1404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 964);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Лабораторная работа №1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem InformationToolStripMenuItem;
        private ToolStripMenuItem AboutProgramToolStripMenuItem;
        private ToolStripMenuItem AboutAuthorToolStripMenuItem;
        private ToolStripMenuItem AddPointToolStripMenuItem;
        private ToolStripComboBox SetComboBox;
        private ToolStripMenuItem CalculateToolStripMenuItem;
        private ToolStripMenuItem PlusStripMenuItem;
        private ToolStripMenuItem MinusStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem AutoFocusToolStripMenuItem;
        private ToolStripMenuItem ClearToolStripMenuItem;

    }
}

