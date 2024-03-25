namespace lab_01
{
    partial class Main
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            InformationToolStripMenuItem = new ToolStripMenuItem();
            AboutProgramToolStripMenuItem = new ToolStripMenuItem();
            AboutAuthorToolStripMenuItem = new ToolStripMenuItem();
            AddPointToolStripMenuItem = new ToolStripMenuItem();
            SetComboBox = new ToolStripComboBox();
            CalculateToolStripMenuItem = new ToolStripMenuItem();
            PlusStripMenuItem = new ToolStripMenuItem();
            MinusStripMenuItem = new ToolStripMenuItem();
            AutoFocusToolStripMenuItem = new ToolStripMenuItem();
            ClearToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { InformationToolStripMenuItem, AddPointToolStripMenuItem, SetComboBox, CalculateToolStripMenuItem, PlusStripMenuItem, MinusStripMenuItem, AutoFocusToolStripMenuItem, ClearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1470, 60);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // InformationToolStripMenuItem
            // 
            InformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutProgramToolStripMenuItem, AboutAuthorToolStripMenuItem });
            InformationToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
            InformationToolStripMenuItem.Padding = new Padding(8);
            InformationToolStripMenuItem.Size = new Size(227, 56);
            InformationToolStripMenuItem.Text = "Информация";
            // 
            // AboutProgramToolStripMenuItem
            // 
            AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            AboutProgramToolStripMenuItem.Size = new Size(341, 44);
            AboutProgramToolStripMenuItem.Text = "О программе";
            AboutProgramToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
            // 
            // AboutAuthorToolStripMenuItem
            // 
            AboutAuthorToolStripMenuItem.Name = "AboutAuthorToolStripMenuItem";
            AboutAuthorToolStripMenuItem.Size = new Size(341, 44);
            AboutAuthorToolStripMenuItem.Text = "Об авторе";
            AboutAuthorToolStripMenuItem.Click += AboutAuthorToolStripMenuItem_Click;
            // 
            // AddPointToolStripMenuItem
            // 
            AddPointToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddPointToolStripMenuItem.Name = "AddPointToolStripMenuItem";
            AddPointToolStripMenuItem.Padding = new Padding(8);
            AddPointToolStripMenuItem.Size = new Size(259, 56);
            AddPointToolStripMenuItem.Text = "Добавить точку";
            AddPointToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            AddPointToolStripMenuItem.Click += AddPointToolStripMenuItem_Click;
            // 
            // SetComboBox
            // 
            SetComboBox.BackColor = SystemColors.Window;
            SetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetComboBox.DropDownWidth = 121;
            SetComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetComboBox.ForeColor = Color.Black;
            SetComboBox.Items.AddRange(new object[] { "1-ое множество", "2-ое множество" });
            SetComboBox.Name = "SetComboBox";
            SetComboBox.RightToLeft = RightToLeft.No;
            SetComboBox.Size = new Size(320, 56);
            SetComboBox.SelectedIndexChanged += SetComboBox_SelectedIndexChanged;
            // 
            // CalculateToolStripMenuItem
            // 
            CalculateToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            CalculateToolStripMenuItem.Size = new Size(189, 56);
            CalculateToolStripMenuItem.Text = "Посчитать";
            CalculateToolStripMenuItem.Click += CalculateToolStripMenuItem_Click;
            // 
            // PlusStripMenuItem
            // 
            PlusStripMenuItem.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            PlusStripMenuItem.Name = "PlusStripMenuItem";
            PlusStripMenuItem.Size = new Size(60, 56);
            PlusStripMenuItem.Text = "+";
            PlusStripMenuItem.Click += PlusStripMenuItem_Click;
            // 
            // MinusStripMenuItem
            // 
            MinusStripMenuItem.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MinusStripMenuItem.Name = "MinusStripMenuItem";
            MinusStripMenuItem.Size = new Size(50, 56);
            MinusStripMenuItem.Text = "-";
            MinusStripMenuItem.Click += MinusStripMenuItem_Click;
            // 
            // AutoFocusToolStripMenuItem
            // 
            AutoFocusToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AutoFocusToolStripMenuItem.Name = "AutoFocusToolStripMenuItem";
            AutoFocusToolStripMenuItem.Size = new Size(187, 56);
            AutoFocusToolStripMenuItem.Text = "AutoFocus";
            AutoFocusToolStripMenuItem.Click += AutoFocusToolStripMenuItem_Click;
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.Size = new Size(125, 56);
            ClearToolStripMenuItem.Text = "Сброс";
            ClearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1359, 1329);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 1329);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 79);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 1404);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(1470, 1491);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = " Лабораторная работа №1";
            Load += Form1_Load;
            Paint += Main_Paint;
            MouseDoubleClick += Main_MouseDoubleClick;
            MouseDown += Main_MouseDown;
            MouseMove += Main_MouseMove;
            MouseUp += Main_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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