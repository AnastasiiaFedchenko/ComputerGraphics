namespace lab_03
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WuCheckBox = new System.Windows.Forms.CheckBox();
            this.BsCheckBox = new System.Windows.Forms.CheckBox();
            this.BiCheckBox = new System.Windows.Forms.CheckBox();
            this.BfCheckBox = new System.Windows.Forms.CheckBox();
            this.DDACheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(-39, -3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series21.BorderWidth = 10;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.MarkerSize = 10;
            series21.Name = "ЦДА";
            series22.BorderWidth = 10;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "Брезенхем float";
            series23.BorderWidth = 10;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "Брезенхем int";
            series24.BorderWidth = 10;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "Брезенхем сглаженный";
            series25.BorderWidth = 10;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.Legend = "Legend1";
            series25.Name = "Ву";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Size = new System.Drawing.Size(1930, 1235);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WuCheckBox);
            this.groupBox1.Controls.Add(this.BsCheckBox);
            this.groupBox1.Controls.Add(this.BiCheckBox);
            this.groupBox1.Controls.Add(this.BfCheckBox);
            this.groupBox1.Controls.Add(this.DDACheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1454, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы";
            // 
            // WuCheckBox
            // 
            this.WuCheckBox.AutoSize = true;
            this.WuCheckBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.WuCheckBox.Checked = true;
            this.WuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WuCheckBox.Location = new System.Drawing.Point(6, 291);
            this.WuCheckBox.Name = "WuCheckBox";
            this.WuCheckBox.Size = new System.Drawing.Size(83, 40);
            this.WuCheckBox.TabIndex = 4;
            this.WuCheckBox.Text = "Ву";
            this.WuCheckBox.UseVisualStyleBackColor = false;
            this.WuCheckBox.CheckedChanged += new System.EventHandler(this.WuCheckBox_CheckedChanged);
            // 
            // BsCheckBox
            // 
            this.BsCheckBox.AutoSize = true;
            this.BsCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.BsCheckBox.Checked = true;
            this.BsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BsCheckBox.Location = new System.Drawing.Point(6, 239);
            this.BsCheckBox.Name = "BsCheckBox";
            this.BsCheckBox.Size = new System.Drawing.Size(391, 40);
            this.BsCheckBox.TabIndex = 3;
            this.BsCheckBox.Text = "Брезенхем сглаженный";
            this.BsCheckBox.UseVisualStyleBackColor = false;
            this.BsCheckBox.CheckedChanged += new System.EventHandler(this.BsCheckBox_CheckedChanged);
            // 
            // BiCheckBox
            // 
            this.BiCheckBox.AutoSize = true;
            this.BiCheckBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BiCheckBox.Checked = true;
            this.BiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BiCheckBox.Location = new System.Drawing.Point(6, 172);
            this.BiCheckBox.Name = "BiCheckBox";
            this.BiCheckBox.Size = new System.Drawing.Size(246, 40);
            this.BiCheckBox.TabIndex = 2;
            this.BiCheckBox.Text = "Брезенхем int";
            this.BiCheckBox.UseVisualStyleBackColor = false;
            this.BiCheckBox.CheckedChanged += new System.EventHandler(this.BiCheckBox_CheckedChanged);
            // 
            // BfCheckBox
            // 
            this.BfCheckBox.AutoSize = true;
            this.BfCheckBox.BackColor = System.Drawing.Color.LightGreen;
            this.BfCheckBox.Checked = true;
            this.BfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BfCheckBox.Location = new System.Drawing.Point(6, 114);
            this.BfCheckBox.Name = "BfCheckBox";
            this.BfCheckBox.Size = new System.Drawing.Size(272, 40);
            this.BfCheckBox.TabIndex = 1;
            this.BfCheckBox.Text = "Брезенхем float";
            this.BfCheckBox.UseVisualStyleBackColor = false;
            this.BfCheckBox.CheckedChanged += new System.EventHandler(this.BfCheckBox_CheckedChanged);
            // 
            // DDACheckBox
            // 
            this.DDACheckBox.AutoSize = true;
            this.DDACheckBox.BackColor = System.Drawing.Color.Tomato;
            this.DDACheckBox.Checked = true;
            this.DDACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DDACheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DDACheckBox.Location = new System.Drawing.Point(6, 57);
            this.DDACheckBox.Name = "DDACheckBox";
            this.DDACheckBox.Size = new System.Drawing.Size(114, 40);
            this.DDACheckBox.TabIndex = 0;
            this.DDACheckBox.Text = "ЦДА";
            this.DDACheckBox.UseVisualStyleBackColor = false;
            this.DDACheckBox.CheckedChanged += new System.EventHandler(this.DDACheckBox_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 1237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox WuCheckBox;
        private System.Windows.Forms.CheckBox BsCheckBox;
        private System.Windows.Forms.CheckBox BiCheckBox;
        private System.Windows.Forms.CheckBox BfCheckBox;
        private System.Windows.Forms.CheckBox DDACheckBox;
    }
}