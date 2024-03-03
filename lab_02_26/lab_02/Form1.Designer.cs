namespace lab_02
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            degreeTextBox = new ToolStripTextBox();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            dxTextBox = new ToolStripTextBox();
            toolStripLabel5 = new ToolStripLabel();
            dyTextBox = new ToolStripTextBox();
            toolStripLabel6 = new ToolStripLabel();
            toolStripLabel8 = new ToolStripLabel();
            toolStripTextBox4 = new ToolStripTextBox();
            toolStripLabel9 = new ToolStripLabel();
            toolStripTextBox5 = new ToolStripTextBox();
            toolStripLabel10 = new ToolStripLabel();
            toolStripTextBox6 = new ToolStripTextBox();
            toolStripLabel7 = new ToolStripLabel();
            toolStripTextBox7 = new ToolStripTextBox();
            drawButton = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel11 = new ToolStripLabel();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, degreeTextBox, toolStripComboBox1, toolStripLabel3, toolStripLabel4, dxTextBox, toolStripLabel5, dyTextBox, toolStripLabel6, toolStripLabel8, toolStripTextBox4, toolStripLabel9, toolStripTextBox5, toolStripLabel10, toolStripTextBox6, toolStripLabel7, toolStripTextBox7, drawButton, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator1, toolStripLabel11, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(408, 1405);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(403, 49);
            toolStripLabel1.Text = "Поворот";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(403, 36);
            toolStripLabel2.Text = "Введите градусы поворота";
            // 
            // degreeTextBox
            // 
            degreeTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            degreeTextBox.Name = "degreeTextBox";
            degreeTextBox.Size = new Size(399, 44);
            degreeTextBox.Text = "0";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripComboBox1.Items.AddRange(new object[] { "по часовой", "против часовой" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(399, 44);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(403, 49);
            toolStripLabel3.Text = "Перенос";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(403, 36);
            toolStripLabel4.Text = "dx:";
            toolStripLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dxTextBox
            // 
            dxTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dxTextBox.Name = "dxTextBox";
            dxTextBox.Size = new Size(399, 44);
            dxTextBox.Text = "0";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(403, 36);
            toolStripLabel5.Text = "dy:";
            toolStripLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dyTextBox
            // 
            dyTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dyTextBox.Name = "dyTextBox";
            dyTextBox.Size = new Size(399, 44);
            dyTextBox.Text = "0";
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(403, 49);
            toolStripLabel6.Text = "Масштабирование";
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(403, 36);
            toolStripLabel8.Text = "Xo:";
            toolStripLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(399, 44);
            toolStripTextBox4.Text = "0";
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(403, 36);
            toolStripLabel9.Text = "Yo:";
            toolStripLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripTextBox5
            // 
            toolStripTextBox5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox5.Name = "toolStripTextBox5";
            toolStripTextBox5.Size = new Size(399, 44);
            toolStripTextBox5.Text = "0";
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(403, 36);
            toolStripLabel10.Text = "Kx:";
            toolStripLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripTextBox6
            // 
            toolStripTextBox6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox6.Name = "toolStripTextBox6";
            toolStripTextBox6.Size = new Size(399, 44);
            toolStripTextBox6.Text = "1";
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(403, 36);
            toolStripLabel7.Text = "Ky:";
            toolStripLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripTextBox7
            // 
            toolStripTextBox7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox7.Name = "toolStripTextBox7";
            toolStripTextBox7.Size = new Size(399, 44);
            toolStripTextBox7.Text = "1";
            // 
            // drawButton
            // 
            drawButton.AutoSize = false;
            drawButton.BackColor = Color.FromArgb(192, 192, 255);
            drawButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawButton.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            drawButton.ImageTransparentColor = Color.Magenta;
            drawButton.Name = "drawButton";
            drawButton.Overflow = ToolStripItemOverflow.Never;
            drawButton.RightToLeft = RightToLeft.Yes;
            drawButton.Size = new Size(403, 100);
            drawButton.Text = "Отрисовать";
            drawButton.TextImageRelation = TextImageRelation.TextAboveImage;
            drawButton.Click += drawButton_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(403, 46);
            toolStripButton4.Text = "Сброс";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(403, 46);
            toolStripButton5.Text = "Undo";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(403, 46);
            toolStripButton6.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(403, 6);
            // 
            // toolStripLabel11
            // 
            toolStripLabel11.Name = "toolStripLabel11";
            toolStripLabel11.Size = new Size(403, 32);
            toolStripLabel11.Text = "Информация";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(403, 36);
            toolStripButton2.Text = "Об авторе";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(403, 36);
            toolStripButton3.Text = "О программе";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(32, 32);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2177, 1405);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox degreeTextBox;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox dxTextBox;
        private ToolStripLabel toolStripLabel5;
        private ToolStripTextBox dyTextBox;
        private ToolStripLabel toolStripLabel6;
        private ToolStripLabel toolStripLabel8;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripLabel toolStripLabel9;
        private ToolStripTextBox toolStripTextBox5;
        private ToolStripLabel toolStripLabel10;
        private ToolStripTextBox toolStripTextBox6;
        private ToolStripLabel toolStripLabel7;
        private ToolStripTextBox toolStripTextBox7;
        private ToolStripButton drawButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel11;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
    }
}