namespace lab_04
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BresenhamCheckBox = new System.Windows.Forms.CheckBox();
            this.ParametricCheckBox = new System.Windows.Forms.CheckBox();
            this.CanonicCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-39, -3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Канонический";
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Параметрический";
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Брезенхем";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1930, 1235);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BresenhamCheckBox);
            this.groupBox1.Controls.Add(this.ParametricCheckBox);
            this.groupBox1.Controls.Add(this.CanonicCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1544, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы";
            // 
            // BresenhamCheckBox
            // 
            this.BresenhamCheckBox.AutoSize = true;
            this.BresenhamCheckBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BresenhamCheckBox.Checked = true;
            this.BresenhamCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BresenhamCheckBox.Location = new System.Drawing.Point(6, 172);
            this.BresenhamCheckBox.Name = "BresenhamCheckBox";
            this.BresenhamCheckBox.Size = new System.Drawing.Size(203, 40);
            this.BresenhamCheckBox.TabIndex = 2;
            this.BresenhamCheckBox.Text = "Брезенхем";
            this.BresenhamCheckBox.UseVisualStyleBackColor = false;
            this.BresenhamCheckBox.CheckedChanged += new System.EventHandler(this.BiCheckBox_CheckedChanged);
            // 
            // ParametricCheckBox
            // 
            this.ParametricCheckBox.AutoSize = true;
            this.ParametricCheckBox.BackColor = System.Drawing.Color.LightGreen;
            this.ParametricCheckBox.Checked = true;
            this.ParametricCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParametricCheckBox.Location = new System.Drawing.Point(6, 114);
            this.ParametricCheckBox.Name = "ParametricCheckBox";
            this.ParametricCheckBox.Size = new System.Drawing.Size(309, 40);
            this.ParametricCheckBox.TabIndex = 1;
            this.ParametricCheckBox.Text = "Параметрический";
            this.ParametricCheckBox.UseVisualStyleBackColor = false;
            this.ParametricCheckBox.CheckedChanged += new System.EventHandler(this.BfCheckBox_CheckedChanged);
            // 
            // CanonicCheckBox
            // 
            this.CanonicCheckBox.AutoSize = true;
            this.CanonicCheckBox.BackColor = System.Drawing.Color.Tomato;
            this.CanonicCheckBox.Checked = true;
            this.CanonicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CanonicCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CanonicCheckBox.Location = new System.Drawing.Point(6, 57);
            this.CanonicCheckBox.Name = "CanonicCheckBox";
            this.CanonicCheckBox.Size = new System.Drawing.Size(254, 40);
            this.CanonicCheckBox.TabIndex = 0;
            this.CanonicCheckBox.Text = "Канонический";
            this.CanonicCheckBox.UseVisualStyleBackColor = false;
            this.CanonicCheckBox.CheckedChanged += new System.EventHandler(this.DDACheckBox_CheckedChanged);
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
        private System.Windows.Forms.CheckBox BresenhamCheckBox;
        private System.Windows.Forms.CheckBox ParametricCheckBox;
        private System.Windows.Forms.CheckBox CanonicCheckBox;
    }
}