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
            toolStripLabel12 = new ToolStripLabel();
            Ox1TextBox = new ToolStripTextBox();
            toolStripLabel13 = new ToolStripLabel();
            Oy1TextBox = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            degreeTextBox = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            dxTextBox = new ToolStripTextBox();
            toolStripLabel5 = new ToolStripLabel();
            dyTextBox = new ToolStripTextBox();
            toolStripLabel6 = new ToolStripLabel();
            toolStripLabel8 = new ToolStripLabel();
            Ox2TextBox = new ToolStripTextBox();
            toolStripLabel9 = new ToolStripLabel();
            Oy2TextBox = new ToolStripTextBox();
            toolStripLabel10 = new ToolStripLabel();
            kxTextBox = new ToolStripTextBox();
            toolStripLabel7 = new ToolStripLabel();
            kyTextBox = new ToolStripTextBox();
            drawButton = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            UndoButton = new ToolStripButton();
            RedoButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel12, Ox1TextBox, toolStripLabel13, Oy1TextBox, toolStripLabel2, degreeTextBox, toolStripLabel3, toolStripLabel4, dxTextBox, toolStripLabel5, dyTextBox, toolStripLabel6, toolStripLabel8, Ox2TextBox, toolStripLabel9, Oy2TextBox, toolStripLabel10, kxTextBox, toolStripLabel7, kyTextBox, drawButton, toolStripButton4, UndoButton, RedoButton, toolStripSeparator1 });
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
            // toolStripLabel12
            // 
            toolStripLabel12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel12.Name = "toolStripLabel12";
            toolStripLabel12.Size = new Size(403, 36);
            toolStripLabel12.Text = "Ox:";
            toolStripLabel12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ox1TextBox
            // 
            Ox1TextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ox1TextBox.Name = "Ox1TextBox";
            Ox1TextBox.Size = new Size(399, 44);
            Ox1TextBox.Text = "0";
            // 
            // toolStripLabel13
            // 
            toolStripLabel13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel13.Name = "toolStripLabel13";
            toolStripLabel13.Size = new Size(403, 36);
            toolStripLabel13.Text = "Oy:";
            toolStripLabel13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Oy1TextBox
            // 
            Oy1TextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Oy1TextBox.Name = "Oy1TextBox";
            Oy1TextBox.Size = new Size(399, 44);
            Oy1TextBox.Text = "0";
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
            toolStripLabel8.Text = "Ox:";
            toolStripLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ox2TextBox
            // 
            Ox2TextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ox2TextBox.Name = "Ox2TextBox";
            Ox2TextBox.Size = new Size(399, 44);
            Ox2TextBox.Text = "0";
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(403, 36);
            toolStripLabel9.Text = "Oy:";
            toolStripLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Oy2TextBox
            // 
            Oy2TextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Oy2TextBox.Name = "Oy2TextBox";
            Oy2TextBox.Size = new Size(399, 44);
            Oy2TextBox.Text = "0";
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(403, 36);
            toolStripLabel10.Text = "Kx:";
            toolStripLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kxTextBox
            // 
            kxTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kxTextBox.Name = "kxTextBox";
            kxTextBox.Size = new Size(399, 44);
            kxTextBox.Text = "1";
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(403, 36);
            toolStripLabel7.Text = "Ky:";
            toolStripLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kyTextBox
            // 
            kyTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kyTextBox.Name = "kyTextBox";
            kyTextBox.Size = new Size(399, 44);
            kyTextBox.Text = "1";
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
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // UndoButton
            // 
            UndoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UndoButton.Enabled = false;
            UndoButton.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            UndoButton.Image = (Image)resources.GetObject("UndoButton.Image");
            UndoButton.ImageTransparentColor = Color.Magenta;
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(403, 46);
            UndoButton.Text = "Undo";
            UndoButton.Click += UndoButton_Click;
            // 
            // RedoButton
            // 
            RedoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RedoButton.Enabled = false;
            RedoButton.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            RedoButton.Image = (Image)resources.GetObject("RedoButton.Image");
            RedoButton.ImageTransparentColor = Color.Magenta;
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(403, 46);
            RedoButton.Text = "Redo";
            RedoButton.Click += RedoButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(403, 6);
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
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox dxTextBox;
        private ToolStripLabel toolStripLabel5;
        private ToolStripTextBox dyTextBox;
        private ToolStripLabel toolStripLabel6;
        private ToolStripLabel toolStripLabel8;
        private ToolStripTextBox Ox2TextBox;
        private ToolStripLabel toolStripLabel9;
        private ToolStripTextBox Oy2TextBox;
        private ToolStripLabel toolStripLabel10;
        private ToolStripTextBox kxTextBox;
        private ToolStripLabel toolStripLabel7;
        private ToolStripTextBox kyTextBox;
        private ToolStripButton drawButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton UndoButton;
        private ToolStripButton RedoButton;
        private ToolStripLabel toolStripLabel12;
        private ToolStripTextBox Ox1TextBox;
        private ToolStripLabel toolStripLabel13;
        private ToolStripTextBox Oy1TextBox;
    }
}