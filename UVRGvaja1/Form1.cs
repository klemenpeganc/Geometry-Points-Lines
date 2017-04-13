using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVRGvaja1
{
    public partial class Form1 : Form
    {
        List<Point> tocke = new List<Point>();
        int pointCounter = 0;
        Point tp;
        bool orthogonal;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawPoint(List<Point> list, int x, int y)
        {
            Point point = new Point(x, y);
            list.Add(point);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            SolidBrush brush = new SolidBrush(Color.LimeGreen);
            Rectangle rect = new Rectangle(point, new Size(4, 4));
            g.FillRectangle(brush, rect);
            g.Dispose();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rb1.Checked)
            {
                if (tocke.Count > 2)
                {
                    point3x.Text = "";
                    point3y.Text = "";
                    point4x.Text = "";
                    point4y.Text = "";
                    pointCounter = 2;
                }
                if (pointCounter == 0)
                {
                    if (string.IsNullOrEmpty(point1x.Text) && string.IsNullOrEmpty(point1y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point1x.Text = e.X.ToString();
                        point1y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point1x.Text), int.Parse(point1y.Text));
                    }
                    pointCounter++;
                }
                else if (pointCounter == 1)
                {
                    if (string.IsNullOrEmpty(point2x.Text) && string.IsNullOrEmpty(point2y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point2x.Text = e.X.ToString();
                        point2y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point2x.Text), int.Parse(point2y.Text));
                    }
                    pointCounter++;
                    btnCalculate.Enabled = true;
                    pictureBox1.Invalidate();
                }
                else if (pointCounter == 2)
                {
                    point1x.Text = "";
                    point2x.Text = "";
                    point1y.Text = "";
                    point2y.Text = "";
                    tocke.Clear();
                    pictureBox1.Refresh();
                    pointCounter = 0;
                }
            }
            else if (radioButton2.Checked)
            {
                if (tocke.Count > 3)
                {
                    point4x.Text = "";
                    point4y.Text = "";
                    pointCounter = 3;
                }
                if (pointCounter == 0)
                {
                    if (string.IsNullOrEmpty(point1x.Text) && string.IsNullOrEmpty(point1y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point1x.Text = e.X.ToString();
                        point1y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point1x.Text), int.Parse(point1y.Text));
                    }
                    pointCounter++;
                }
                else if (pointCounter == 1)
                {
                    if (string.IsNullOrEmpty(point2x.Text) && string.IsNullOrEmpty(point2y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point2x.Text = e.X.ToString();
                        point2y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point2x.Text), int.Parse(point2y.Text));
                    }
                    pointCounter++;
                    pictureBox1.Invalidate();
                }
                else if (pointCounter == 2)
                {
                    if (string.IsNullOrEmpty(point3x.Text) && string.IsNullOrEmpty(point3y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point3x.Text = e.X.ToString();
                        point3y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point3x.Text), int.Parse(point3y.Text));
                    }
                    btnCalculate.Enabled = true;
                    pointCounter++;
                }
                else if (pointCounter == 3)
                {
                    point1x.Text = "";
                    point2x.Text = "";
                    point1y.Text = "";
                    point2y.Text = "";
                    point3x.Text = "";
                    point3y.Text = "";
                    tocke.Clear();
                    pictureBox1.Refresh();
                    pointCounter = 0;
                }
            }
            else if (radioButton3.Checked)
            {
                if (pointCounter == 0)
                {
                    if (string.IsNullOrEmpty(point1x.Text) && string.IsNullOrEmpty(point1y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point1x.Text = e.X.ToString();
                        point1y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point1x.Text), int.Parse(point1y.Text));
                    }
                    pointCounter++;
                }
                else if (pointCounter == 1)
                {
                    if (string.IsNullOrEmpty(point2x.Text) && string.IsNullOrEmpty(point2y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point2x.Text = e.X.ToString();
                        point2y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point2x.Text), int.Parse(point2y.Text));
                    }
                    pointCounter++;
                    pictureBox1.Invalidate();
                }
                else if (pointCounter == 2)
                {
                    if (string.IsNullOrEmpty(point3x.Text) && string.IsNullOrEmpty(point3y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point3x.Text = e.X.ToString();
                        point3y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point3x.Text), int.Parse(point3y.Text));
                    }
                    pointCounter++;
                }
                else if (pointCounter == 3)
                {
                    if (string.IsNullOrEmpty(point4x.Text) && string.IsNullOrEmpty(point4y.Text))
                    {
                        drawPoint(tocke, e.X, e.Y);
                        point4x.Text = e.X.ToString();
                        point4y.Text = e.Y.ToString();
                    }
                    else
                    {
                        drawPoint(tocke, int.Parse(point4x.Text), int.Parse(point4y.Text));
                    }
                    btnCalculate.Enabled = true;
                    pictureBox1.Invalidate();
                    pointCounter++;
                }
                else if (pointCounter == 4)
                {
                    point1x.Text = "";
                    point2x.Text = "";
                    point1y.Text = "";
                    point2y.Text = "";
                    point3x.Text = "";
                    point3y.Text = "";
                    point4x.Text = "";
                    point4y.Text = "";
                    tocke.Clear();
                    pictureBox1.Refresh();
                    pointCounter = 0;
                }
            }

        }

        private double calculateDistance(Point A, Point B)
        {
            double distance = 0;
            distance = (A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y);
            distance = Math.Sqrt(Math.Abs(distance));
            return distance;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tocke.Count == 2)
                MessageBox.Show("The distance is: " + calculateDistance(tocke[0], tocke[1]).ToString().Substring(0, 7));
            else if (tocke.Count == 3)
            {
                tp = orthagonalPoint(tocke[0], tocke[1], tocke[2]);
                if (orthogonal)
                {
                    Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                    SolidBrush brush = new SolidBrush(Color.Red);
                    Rectangle rect = new Rectangle(tp, new Size(3, 3));
                    g.FillRectangle(brush, rect);
                    g.Dispose();
                    pictureBox1.Invalidate();
                    MessageBox.Show("Point Tp: " +tp+ "\nDistance is: " + calculateDistance(tocke[2], tp).ToString().Substring(0, 7));
                }
                else
                {
                    pictureBox1.Invalidate();
                    if (calculateDistance(tocke[2], tocke[0]) > calculateDistance(tocke[2], tocke[1]))
                        MessageBox.Show("Orthogonal projection doesn't exist.\nDistance to the closest point: " + calculateDistance(tocke[2], tocke[1]).ToString());
                    else
                        MessageBox.Show("Orthogonal projection doesn't exist.\nDistance to the closest point: " + calculateDistance(tocke[2], tocke[0]).ToString().Substring(0, 7));
                }
            }
            else if (tocke.Count == 4)
            {
                presecisceAliDrugo(tocke[0], tocke[1], tocke[2], tocke[3]);
            }
        }
        private Point orthagonalPoint(Point lineA, Point lineB, Point point)
        {
            Point r = new Point();
            double pro = ((point.Y - lineA.Y) * (lineB.Y - lineA.Y)) + ((point.X - lineA.X) * (lineB.X - lineA.X));
            double l = (lineB.Y - lineA.Y) * (lineB.Y - lineA.Y) + (lineB.X - lineA.X) * (lineB.X - lineA.X);
            pro = pro / l;

            r.Y = (int)((lineA.Y + (pro * (lineB.Y - lineA.Y))));
            r.X = (int)(lineA.X + (pro * (lineB.X - lineA.X)));
            double minx = Math.Min(lineA.Y, lineB.Y);
            double maxx = Math.Max(lineA.Y, lineB.Y);

            double miny = Math.Min(lineA.X, lineB.X);
            double maxy = Math.Max(lineA.X, lineB.X);

            orthogonal = (r.Y >= minx && r.Y <= maxx) && (r.X >= miny && r.X <= maxy);
            return r;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);
            if (tocke.Count > 1)
            {
                e.Graphics.DrawLine(pen, tocke[0], tocke[1]);
            }
            if (tocke.Count == 3)
            {
                if (orthogonal == true)
                    e.Graphics.DrawLine(new Pen(Color.Red, 2), tocke[2], tp);
                else
                {
                    if (calculateDistance(tocke[2], tocke[0]) > calculateDistance(tocke[2], tocke[1]))
                        e.Graphics.DrawLine(new Pen(Color.Red, 2), tocke[1], tocke[2]);
                    else
                        e.Graphics.DrawLine(new Pen(Color.Red, 2), tocke[0], tocke[2]);
                }
            }
            if (tocke.Count > 3)
            {
                e.Graphics.DrawLine(pen, tocke[2], tocke[3]);
            }
        }
        private void presecisceAliDrugo(Point first, Point second, Point third, Point fourth)
        {
            double D = (second.X - first.X) * (fourth.Y - third.Y) - (fourth.X - third.X) * (second.Y - first.Y);
            double A = (fourth.X - third.X) * (first.Y - third.Y) - (first.X - third.X) * (fourth.Y - third.Y);
            double B = (second.X - first.X) * (first.Y - third.Y) - (first.X - third.X) * (second.Y - first.Y);
            if (Math.Abs(D) < 0.0001 && Math.Abs(A) < 0.0001 && Math.Abs(B) < 0.0001)
            {
                if (first == third && second == fourth || first == fourth && second == third)
                {
                    MessageBox.Show("Lines completely overlap!");
                }
                else {
                    List<Point> urejene = new List<Point>();
                    urejene=tocke.OrderByDescending(p => p.X).ToList();
                    Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                    g.DrawLine(new Pen(Color.Red, 6), urejene[2], urejene[1]);
                    MessageBox.Show("Lines overlap between: " + urejene[2] + " and " + urejene[1]);
                }
            }
            else
            {
                if (Math.Abs(D) < 0.0001)
                {
                    MessageBox.Show("Lines are parallel!");
                }
                else
                {
                    double Ua = A / D;
                    double Ub = B / D;
                    if (Ua >= 0 && Ua <= 1 && Ub >= 0 && Ub <= 1)
                    {
                        if (Ua == 0)
                        {
                            MessageBox.Show("Point 1: " + tocke[0] + " is the intersection");
                            tp = tocke[0];
                        }
                        else if (Ua == 1)
                        {
                            MessageBox.Show("Point 2: " + tocke[1] + " is the intersection");
                            tp = tocke[1];
                        }
                        else if (Ub == 0)
                        {
                            MessageBox.Show("Point 3: " + tocke[2] + " is the intersection");
                            tp = tocke[2];
                        }
                        else if (Ub == 1)
                        {
                            MessageBox.Show("Point 4: " + tocke[3] + " is the intersection");
                            tp = tocke[3];
                        }
                        else
                        {
                            double tpX = first.X + Ua * (second.X - first.X);
                            double tpY = first.Y + Ua * (second.Y - first.Y);
                            tp.X = (int)tpX;
                            tp.Y = (int)tpY;
                            MessageBox.Show("Lines cross!\nPoint Tp: " + tp);
                        }
                        Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                        SolidBrush brush = new SolidBrush(Color.Red);
                        Rectangle rect = new Rectangle(tp, new Size(3, 3));
                        g.FillRectangle(brush, rect);
                        g.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Lines do not cross!");
                    }
                }
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                point1x.Enabled = true;
                point1y.Enabled = true;
                point2x.Enabled = true;
                point2y.Enabled = true;
                point3x.Enabled = false;
                point3y.Enabled = false;
                point4x.Enabled = false;
                point4y.Enabled = false;
                point3x.Text = "";
                point3y.Text = "";
                point4x.Text = "";
                point4y.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                point3x.Enabled = true;
                point3y.Enabled = true;
                point4x.Enabled = false;
                point4y.Enabled = false;
                point4x.Text = "";
                point4y.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            point3x.Enabled = true;
            point3y.Enabled = true;
            point4x.Enabled = true;
            point4y.Enabled = true;
        }
    }
}
