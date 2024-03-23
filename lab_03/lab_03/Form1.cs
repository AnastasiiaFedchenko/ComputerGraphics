using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_03
{
    public partial class Form1 : Form
    {
        Line line = null;
        List<Line> spectrum = null;
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void LineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LineRadioButton.Checked) 
            {
                XsTextBox.Enabled = true;
                YsTextBox.Enabled = true;
                XfTextBox.Enabled = true;
                YfTextBox.Enabled = true;  
                XsLabel.Visible = true;
                YsLabel.Visible = true;
                XfLabel.Visible = true;
                YfLabel.Visible = true;
                XsTextBox.Visible = true;
                YsTextBox.Visible = true;
                XfTextBox.Visible = true;
                YfTextBox.Visible = true;
                LineLengthLabel.Visible = false;
                LineLengthTextBox.Visible = false;
                LineLengthTextBox.Enabled = false;
                DegreeLabel.Visible = false;
                DegreeTextBox.Visible = false;
                DegreeTextBox.Enabled = false;
            }
        }

        private void SpectrumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SpectrumRadioButton.Checked) 
            {
                XsTextBox.Enabled = false;
                YsTextBox.Enabled = false;
                XfTextBox.Enabled = false;
                YfTextBox.Enabled = false;
                XsLabel.Visible = false;
                YsLabel.Visible = false;
                XfLabel.Visible = false;
                YfLabel.Visible = false;
                XsTextBox.Visible = false;
                YsTextBox.Visible = false;
                XfTextBox.Visible = false;
                YfTextBox.Visible = false;
                LineLengthLabel.Visible = true;
                LineLengthTextBox.Visible = true;
                LineLengthTextBox.Enabled = true;
                DegreeLabel.Visible = true;
                DegreeTextBox.Visible = true;
                DegreeTextBox.Enabled = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (LineRadioButton.Checked)
            {
                int xs, ys;
                int xf, yf;
                if (int.TryParse(XsTextBox.Text, out xs) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(YsTextBox.Text, out ys) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(XfTextBox.Text, out xf) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(YfTextBox.Text, out yf) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                Line new_line = new Line(xs, ys, xf, yf, LineColorButton.BackColor, BackgroundColorButton.BackColor);
                Method method;
                if (DDARadioButton.Checked)
                    method = Method.DDA;
                else if (BfRadioButton.Checked)
                    method = Method.B_float;
                else if (BiRadioButton.Checked)
                    method = Method.B_int;
                else if (BsRadioButton.Checked)
                    method = Method.B_smooth;
                else if (WuRadioButton.Checked)
                    method = Method.Wu;
                else
                    method = Method.Lib;
                new_line.controller(method, false);
                line = new_line;
            }
            if (SpectrumRadioButton.Checked)
            {
                double degree;
                int length;
                if (double.TryParse(DegreeTextBox.Text, out degree) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(LineLengthTextBox.Text, out length) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                int x, y;
                spectrum = new List<Line>();
                Line l;
                for (double d = 0; d < 360; d += degree) 
                {
                    x = (int)(Math.Sin((Math.PI / 180) * d) * length);
                    y = (int)(Math.Cos((Math.PI / 180) * d) * length);
                    l = new Line(0, 0, x, y, LineColorButton.BackColor, BackgroundColorButton.BackColor);
                    Method method;
                    if (DDARadioButton.Checked)
                        method = Method.DDA;
                    else if (BfRadioButton.Checked)
                        method = Method.B_float;
                    else if (BiRadioButton.Checked)
                        method = Method.B_int;
                    else if (BsRadioButton.Checked)
                        method = Method.B_smooth;
                    else if (WuRadioButton.Checked)
                        method = Method.Wu;
                    else
                        method = Method.Lib;
                    l.controller(method, false);
                    spectrum.Add(l);
                }
            }
            
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (LineRadioButton.Checked && line != null)
            {
                Graphics g = e.Graphics;
                int offset_x = (this.ClientSize.Width - groupBox1.Width) / 2 + groupBox1.Width;
                int offset_y = this.ClientSize.Height / 2;
                g.FillEllipse(new SolidBrush(Color.Black), offset_x - 5, offset_y - 5, 5, 5);
                this.BackColor = line.Background_color;
                if (LibraryRadioButton.Checked)
                    line.draw_ordinary(g, offset_x, offset_y, k);
                else
                    line.draw(g, offset_x, offset_y, k);
            }
            else if (SpectrumRadioButton.Checked && spectrum != null) 
            {
                Graphics g = e.Graphics;
                int offset_x = (this.ClientSize.Width - groupBox1.Width) / 2 + groupBox1.Width;
                int offset_y = this.ClientSize.Height / 2;
                this.BackColor = spectrum[0].Background_color;
                for (int i = 0; i < spectrum.Count; i++)
                    if (LibraryRadioButton.Checked)
                        spectrum[i].draw_ordinary(g, offset_x, offset_y, k);
                    else
                        spectrum[i].draw(g, offset_x, offset_y, k);
            }
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = BackgroundColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                BackgroundColorButton.BackColor = MyDialog.Color;
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = LineColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                LineColorButton.BackColor = MyDialog.Color;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            k++;
            this.Invalidate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (k > 1) k--;
            this.Invalidate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            line = null;
            spectrum = null;
            XsTextBox.Text = string.Empty;
            YsTextBox.Text = string.Empty;
            XfTextBox.Text = string.Empty;
            YfTextBox.Text = string.Empty;
            DegreeTextBox.Text = "1";
            LineLengthTextBox.Text = "100";
            this.Invalidate();
        }

        private void CompareTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CompareGradationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
