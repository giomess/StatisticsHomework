using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework_8
{
    public partial class Form1 : Form
    {

        Bitmap b1, b2;
        Graphics g1, g2;
        Rectangle r1, r2;

        Pen PenTrajectory;

        int pointnumber = 1000;

        double minX = -50d;
        double maxX = 50d;
        double minY = -50d;
        double maxY = 50d;
        Random value = new Random();
        Random angle = new Random();

        int radius = 50;

        List<Coords> points;

        Dictionary<Interval, int> PointsOnX;
        Dictionary<Interval, int> PointsOnY;

        public Form1()
        {
            InitializeComponent();
            b1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g1 = Graphics.FromImage(b1);
            r1 = new Rectangle(0, 0, b1.Width, b1.Height);

            b2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            g2 = Graphics.FromImage(b2);
            r2 = new Rectangle(10, 10, b2.Width/2, b2.Height/2);
            PenTrajectory = new Pen(Color.Green, 1);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            points = new List<Coords>();

            for (int i = 0; i < pointnumber; i++)
            {
                (double X, double Y) = CoordsGen();
                Coords punto = new Coords(X, Y);
                points.Add(punto);
            }

            compute_PointsOnX();
            compute_PointsOnY();

            timer1.Start();

        }

        public (double, double) CoordsGen()
        {
            double r = value.NextDouble();
            r = value.NextDouble() * radius;
            double a = angle.NextDouble() * 2 * Math.PI;
            double x = r * Math.Cos(a);
            double y = r * Math.Sin(a);

            return (x, y);
        }

        private void trowDarts()
        
            {List<Point> punti = new List<Point>();
            g1.FillRectangle(Brushes.Gray, r1);
           
           foreach (Coords p in points)
            {
                int x = linearTransformX(p.X, minX, maxX, r1.Left, r1.Width);
                int y = linearTransformY(p.Y, minY, maxY, r1.Top, r1.Height);

                Point lancio = new Point(x, y);
                punti.Add(lancio);
            }

            foreach (Point dp in punti)
            {
                Rectangle r = new Rectangle(dp.X - 1, dp.Y - 1, 2, 2);
                g1.FillEllipse(Brushes.Green, r);
            }
        }

        private void compute_PointsOnX()
        {

            PointsOnX = new Dictionary<Interval, int>();

            int current = (int)Math.Floor(minY);
            int max = (int)Math.Ceiling(maxY);

            int size = 10;

            while (current < max)
            {
                Interval i = new Interval(current, current + size);
                current = current + size;

                PointsOnX[i] = 0;
            }

            foreach (Coords p in points)
            {
                int i = 0;
                List<Interval> keys = PointsOnX.Keys.ToList();
                bool counted = false;
                foreach (Interval k in keys)
                {
                    if (p.X >= k.down && p.X <= k.up && !counted)
                    {
                        counted = true;
                        PointsOnX[k]++;
                    }
                   
                }
                
            }
        }

        private void compute_PointsOnY()
        {

            PointsOnY = new Dictionary<Interval, int>();

            int current = (int)Math.Floor(minY);
            int max = (int)Math.Ceiling(maxY);

            int size = 10;

            while (current < max)
            {
                Interval i = new Interval(current, current + size);
                current = current + size;

                PointsOnY[i] = 0;
            }

            foreach (Coords p in points)
            {
                List<Interval> keys = PointsOnY.Keys.ToList();
                bool counted = false;
                foreach (Interval k in keys)
                {
                    if (p.Y >= k.down && p.Y <= k.up && !counted)
                    {
                        counted = true;
                        PointsOnY[k]++;
                    }
                }
            }
        }

        private void Y_dist()
        {
            int maxvalue = PointsOnY.Values.Max();
            int space_height = (r2.Right - r2.Left) / 2;

            foreach (KeyValuePair<Interval, int> kv in PointsOnY)
            {

                Interval i = kv.Key;

                int rect_height = (int)(((double)kv.Value / (double)maxvalue) * ((double)space_height));

                int down_mod = linearTransformY(i.down, minY, maxY, r2.Top, r2.Height);
                int up_mod = linearTransformY(i.up, minY, maxY, r2.Top, r2.Height);

                int size = Math.Abs(down_mod - up_mod);

                Rectangle histrect = new Rectangle(r1.Right, up_mod, rect_height, size);
                g2.FillRectangle(Brushes.Green, histrect);
                g2.DrawRectangle(Pens.Gray, histrect);
            }
        }

        private void X_dist()
        {
            int maxvalue = PointsOnX.Values.Max();
            int space_height = (r2.Bottom - r2.Top) / 2;

            foreach (KeyValuePair<Interval, int> kv in PointsOnX)
            {

                Interval i = kv.Key;

                int rect_height = (int)(((double)kv.Value / (double)maxvalue) * ((double)space_height));

                int down_mod = linearTransformX(i.down, minY, maxY, r2.Left, r2.Width);
                int up_mod = linearTransformX(i.up, minY, maxY, r2.Left, r2.Width);

                int size = Math.Abs(down_mod - up_mod);

                Rectangle histrect = new Rectangle(down_mod, r2.Bottom - rect_height, size, rect_height);
                g2.FillRectangle(Brushes.Green, histrect);
                g2.DrawRectangle(Pens.Gray, histrect);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        { 
            label1.Text = trackBar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g1.Clear(pictureBox1.BackColor);
            g2.Clear(pictureBox1.BackColor);
            trowDarts();
            X_dist();
            Y_dist();
            pictureBox1.Image = b1;
            pictureBox2.Image = b2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public int linearTransformX(double X, double minX, double maxX, int Left, int W)
        {
            return Left + (int)(W * ((X - minX) / (maxX - minX)));
        }

        public int linearTransformY(double Y, double minY, double maxY, int Top, int H)
        {
            return Top + (int)(H - H * ((Y - minY) / (maxY - minY)));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
