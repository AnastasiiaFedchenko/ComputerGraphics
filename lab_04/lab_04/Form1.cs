using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_04
{
    public partial class Form1 : Form
    {
        Circle circle = null;
        Ellipse ellipse = null;
        List<Circle> circle_spectrum = null;
        List<Ellipse> ellipse_spectrum = null;
        int k = 1;
        public Form1()
        {
            InitializeComponent();
            BuildWhatComboBox.SelectedIndex = 0;
            RLabel.Visible = true;
            RxLabel.Visible = false;
            RyLabel.Visible = false;
            RTextBox.Visible = true;
            RTextBox.Enabled = true;
            RxTextBox.Visible = false;
            RxTextBox.Enabled = false;
            RyTextBox.Visible = false;
            RyTextBox.Enabled = false;

            StepLabel.Visible = false;
            StepTextBox.Visible = false;
            StepTextBox.Enabled = false;
            AmountOfFiguresLabel.Visible = false;
            AmountOfFiguresTextBox.Visible = false;
            AmountOfFiguresTextBox.Enabled = false;

        }

        private void Create_Click(object sender, EventArgs e)
        {
            int ox, oy;
            Method method = Method.Canonic;
            if (int.TryParse(OxTextBox.Text, out ox) == false)
            {
                MessageBox.Show("Problem");
                return;
            }
            if (int.TryParse(OyTextBox.Text, out oy) == false)
            {
                MessageBox.Show("Problem");
                return;
            }
            if (CanonicRadioButton.Checked == true)
                method = Method.Canonic;
            else if (ParametricRadioButton.Checked == true)
                method = Method.Parametric;
            else if (BresenhamRadioButton.Checked == true)
                method = Method.Bresenham;
            else if (LibraryRadioButton.Checked == true)
                method = Method.Lib;
            if (BuildWhatComboBox.SelectedIndex == 0) // circle
            {
                int r;
                if (int.TryParse(RTextBox.Text, out r) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                circle = new Circle(ox, oy, r, LineColorButton.BackColor, BackgroundColorButton.BackColor);
                circle.controller(method, false);
            }
            if (BuildWhatComboBox.SelectedIndex == 1) // ellipse
            {
                int rx, ry;
                if (int.TryParse(RxTextBox.Text, out rx) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(RyTextBox.Text, out ry) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                ellipse = new Ellipse(ox, oy, rx, ry, LineColorButton.BackColor, BackgroundColorButton.BackColor);
                ellipse.controller(method, false);
            }
            if (BuildWhatComboBox.SelectedIndex == 2) // spectrum of circles
            {
                int r, step, amount_of_figures;
                if (int.TryParse(RTextBox.Text, out r) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(StepTextBox.Text, out step) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(AmountOfFiguresTextBox.Text, out amount_of_figures) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                circle_spectrum = new List<Circle>();
                for (int i = 0;  i < amount_of_figures && r > 0; i++) 
                {
                    circle_spectrum.Add(new Circle(ox, oy, r, LineColorButton.BackColor, BackgroundColorButton.BackColor));
                    circle_spectrum[circle_spectrum.Count - 1].controller(method, false);
                    r -= step;
                }
            }
            if (BuildWhatComboBox.SelectedIndex == 3) // spectrum of ellipses
            {
                int rx, ry, step, amount_of_figures;
                if (int.TryParse(RxTextBox.Text, out rx) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(RyTextBox.Text, out ry) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(StepTextBox.Text, out step) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                if (int.TryParse(AmountOfFiguresTextBox.Text, out amount_of_figures) == false)
                {
                    MessageBox.Show("Problem");
                    return;
                }
                ellipse_spectrum = new List<Ellipse>();
                for (int i = 0; i < amount_of_figures && rx > 0 && ry > 0; i++)
                {
                    ellipse_spectrum.Add(new Ellipse(ox, oy, rx, ry, LineColorButton.BackColor, BackgroundColorButton.BackColor));
                    ellipse_spectrum[ellipse_spectrum.Count - 1].controller(method, false);
                    rx -= step;
                    ry -= step;
                } 
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int offset_x = (this.ClientSize.Width - groupBox1.Width) / 2 + groupBox1.Width;
            int offset_y = this.ClientSize.Height / 2;
            g.FillEllipse(new SolidBrush(Color.Red), offset_x - 2, offset_y - 2, 4, 4);
            if (BuildWhatComboBox.SelectedIndex == 0 && circle != null)
            {
                if (LibraryRadioButton.Checked == true)
                    circle.draw_ordinary(g, offset_x, offset_y, k);
                else
                    circle.draw(g, offset_x, offset_y, k);
            }
            if (BuildWhatComboBox.SelectedIndex == 1 && ellipse != null)
            {
                if (LibraryRadioButton.Checked == true)
                    ellipse.draw_ordinary(g, offset_x, offset_y, k);
                else
                    ellipse.draw(g, offset_x, offset_y, k);
            }
            if (BuildWhatComboBox.SelectedIndex == 2 && circle_spectrum != null) 
            {
                for (int i = 0; i < circle_spectrum.Count; i++)
                {
                    if (LibraryRadioButton.Checked == true)
                        circle_spectrum[i].draw_ordinary(g, offset_x, offset_y, k);
                    else
                        circle_spectrum[i].draw(g, offset_x, offset_y, k);
                }
            }
            if (BuildWhatComboBox.SelectedIndex == 3 && ellipse_spectrum != null)
            {
                for (int i = 0; i < ellipse_spectrum.Count; i++)
                {
                    if (LibraryRadioButton.Checked == true)
                        ellipse_spectrum[i].draw_ordinary(g, offset_x, offset_y, k);
                    else
                        ellipse_spectrum[i].draw(g, offset_x, offset_y, k);
                }
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
            circle = null;
            ellipse = null;
            circle_spectrum = null;
            ellipse_spectrum = null;
            
            this.Invalidate();
        }

        private void CompareTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void CompareGradationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void BuildWhatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuildWhatComboBox.SelectedIndex == 0) // Build circle
            {
                RLabel.Visible = true;
                RxLabel.Visible = false;
                RyLabel.Visible = false;
                RTextBox.Visible = true;
                RTextBox.Enabled = true;
                RxTextBox.Visible = false;
                RxTextBox.Enabled = false;
                RyTextBox.Visible = false;
                RyTextBox.Enabled = false;
                
                StepLabel.Visible = false;
                StepTextBox.Visible = false;
                StepTextBox.Enabled = false;
                AmountOfFiguresLabel.Visible = false;
                AmountOfFiguresTextBox.Visible = false;
                AmountOfFiguresTextBox.Enabled = false;
            }
            else if (BuildWhatComboBox.SelectedIndex == 1) // Build ellipse
            {
                RLabel.Visible = false;
                RxLabel.Visible = true;
                RyLabel.Visible = true;
                RTextBox.Visible = false;
                RTextBox.Enabled = false;
                RxTextBox.Visible = true;
                RxTextBox.Enabled = true;
                RyTextBox.Visible = true;
                RyTextBox.Enabled = true;

                StepLabel.Visible = false;
                StepTextBox.Visible = false;
                StepTextBox.Enabled = false;
                AmountOfFiguresLabel.Visible = false;
                AmountOfFiguresTextBox.Visible = false;
                AmountOfFiguresTextBox.Enabled = false;
            }
            else if (BuildWhatComboBox.SelectedIndex == 2) // Build spectrum of circles
            {
                RLabel.Visible = true;
                RxLabel.Visible = false;
                RyLabel.Visible = false;
                RTextBox.Visible = true;
                RTextBox.Enabled = true;
                RxTextBox.Visible = false;
                RxTextBox.Enabled = false;
                RyTextBox.Visible = false;
                RyTextBox.Enabled = false;

                StepLabel.Visible = true;
                StepTextBox.Visible = true;
                StepTextBox.Enabled = true;
                AmountOfFiguresLabel.Visible = true;
                AmountOfFiguresTextBox.Visible = true;
                AmountOfFiguresTextBox.Enabled = true;
            }
            else if (BuildWhatComboBox.SelectedIndex == 3) // Build spectrum of ellipses
            {
                RLabel.Visible = false;
                RxLabel.Visible = true;
                RyLabel.Visible = true;
                RTextBox.Visible = false;
                RTextBox.Enabled = false;
                RxTextBox.Visible = true;
                RxTextBox.Enabled = true;
                RyTextBox.Visible = true;
                RyTextBox.Enabled = true;

                StepLabel.Visible = true;
                StepTextBox.Visible = true;
                StepTextBox.Enabled = true;
                AmountOfFiguresLabel.Visible = true;
                AmountOfFiguresTextBox.Visible = true;
                AmountOfFiguresTextBox.Enabled = true;
            }
        }
    }
}
