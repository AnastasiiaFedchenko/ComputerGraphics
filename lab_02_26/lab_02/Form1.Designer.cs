using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.Ox1TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.Oy1TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.degreeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dxTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dyTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.Ox2TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.Oy2TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.kxTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.kyTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.drawButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel12,
            this.Ox1TextBox,
            this.toolStripLabel13,
            this.Oy1TextBox,
            this.toolStripLabel2,
            this.degreeTextBox,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.dxTextBox,
            this.toolStripLabel5,
            this.dyTextBox,
            this.toolStripLabel6,
            this.toolStripLabel8,
            this.Ox2TextBox,
            this.toolStripLabel9,
            this.Oy2TextBox,
            this.toolStripLabel10,
            this.kxTextBox,
            this.toolStripLabel7,
            this.kyTextBox,
            this.drawButton,
            this.toolStripButton4,
            this.UndoButton,
            this.RedoButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(408, 1330);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 16.125F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(403, 49);
            this.toolStripLabel1.Text = "Поворот";
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel12.Text = "Ox:";
            this.toolStripLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ox1TextBox
            // 
            this.Ox1TextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.Ox1TextBox.Name = "Ox1TextBox";
            this.Ox1TextBox.Size = new System.Drawing.Size(399, 44);
            this.Ox1TextBox.Text = "0";
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel13.Text = "Oy:";
            this.toolStripLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Oy1TextBox
            // 
            this.Oy1TextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.Oy1TextBox.Name = "Oy1TextBox";
            this.Oy1TextBox.Size = new System.Drawing.Size(399, 44);
            this.Oy1TextBox.Text = "0";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel2.Text = "Введите градусы поворота";
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(399, 44);
            this.degreeTextBox.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Arial", 16.125F);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(403, 49);
            this.toolStripLabel3.Text = "Перенос";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel4.Text = "dx:";
            this.toolStripLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dxTextBox
            // 
            this.dxTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(399, 44);
            this.dxTextBox.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel5.Text = "dy:";
            this.toolStripLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dyTextBox
            // 
            this.dyTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.dyTextBox.Name = "dyTextBox";
            this.dyTextBox.Size = new System.Drawing.Size(399, 44);
            this.dyTextBox.Text = "0";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Arial", 16.125F);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(403, 49);
            this.toolStripLabel6.Text = "Масштабирование";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel8.Text = "Ox:";
            this.toolStripLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ox2TextBox
            // 
            this.Ox2TextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.Ox2TextBox.Name = "Ox2TextBox";
            this.Ox2TextBox.Size = new System.Drawing.Size(399, 44);
            this.Ox2TextBox.Text = "0";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel9.Text = "Oy:";
            this.toolStripLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Oy2TextBox
            // 
            this.Oy2TextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.Oy2TextBox.Name = "Oy2TextBox";
            this.Oy2TextBox.Size = new System.Drawing.Size(399, 44);
            this.Oy2TextBox.Text = "0";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel10.Text = "Kx:";
            this.toolStripLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kxTextBox
            // 
            this.kxTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.kxTextBox.Name = "kxTextBox";
            this.kxTextBox.Size = new System.Drawing.Size(399, 44);
            this.kxTextBox.Text = "1";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(403, 36);
            this.toolStripLabel7.Text = "Ky:";
            this.toolStripLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kyTextBox
            // 
            this.kyTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.kyTextBox.Name = "kyTextBox";
            this.kyTextBox.Size = new System.Drawing.Size(399, 44);
            this.kyTextBox.Text = "1";
            // 
            // drawButton
            // 
            this.drawButton.AutoSize = false;
            this.drawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drawButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.drawButton.Font = new System.Drawing.Font("Arial", 16.125F);
            this.drawButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawButton.Name = "drawButton";
            this.drawButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.drawButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drawButton.Size = new System.Drawing.Size(200, 100);
            this.drawButton.Text = "Отрисовать";
            this.drawButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Arial", 13.875F);
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(403, 46);
            this.toolStripButton4.Text = "Сброс";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UndoButton.Enabled = false;
            this.UndoButton.Font = new System.Drawing.Font("Arial", 13.875F);
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(403, 46);
            this.UndoButton.Text = "Undo";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RedoButton.Enabled = false;
            this.RedoButton.Font = new System.Drawing.Font("Arial", 13.875F);
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(403, 46);
            this.RedoButton.Text = "Redo";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(403, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 1330);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2177, 1405);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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