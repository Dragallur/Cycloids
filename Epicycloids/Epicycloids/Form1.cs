using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Epicycloids
{
    public partial class Form1 : Form
    {
        Graphics g;
        public static Bitmap bmp;
        public static List<Point> pointsA;
        public static List<Point> pointsB;
        public static List<Point> pointsC;
        public static bool check=false;
        public static Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            

            bmp = new Bitmap(1000, 1000); // This is our canvas that will store drawn lines
            using (Graphics g = Graphics.FromImage(bmp))
                g.Clear(Color.White); // Let's make it white, like paper
            pointsA = new List<Point>();
            pointsB = new List<Point>();
            pointsC = new List<Point>();
        }

        static public int x_coor(int radius, double angle)
        {
            int result = Convert.ToInt32(radius*Math.Cos(Math.PI*angle/180));
            return result;
        }

        static public int y_coor(int radius, double angle)
        {
            int result = Convert.ToInt32(radius * Math.Sin(Math.PI * angle / 180));
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Form2.interval;
            Form2.theta+=Form2.thetaStep;
            pointsA.Add(new Point (x_coor(Form2.radiusA, Form2.theta * Form2.valA) + Form2.x_re, 
                y_coor(Form2.radiusA, Form2.theta * Form2.valA) + Form2.y_re));

            pointsB.Add(new Point(x_coor(Form2.radiusB, Form2.theta * Form2.valB) + Form2.x_re, 
                y_coor(Form2.radiusB, Form2.theta * Form2.valB) + Form2.y_re));

            pointsC.Add(new Point(x_coor(Form2.radiusC, Form2.theta * Form2.valC) + Form2.x_re,
                y_coor(Form2.radiusC, Form2.theta * Form2.valC) + Form2.y_re));

            /*if (theta>360)
            {
                theta = 0;
                x_re += 300;
                valA++;
            }

            if (valA > 10)
            {
                theta = 0;
                x_re = 150;
                y_re += 300;
                valA = 1;
                valB++;
            }*/

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            
            g = e.Graphics;          

            for (int i = 0; i < pointsA.Count(); i++)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    if (Form2.lineABVisible == true) g.DrawLine(Pens.Black, pointsA[i], pointsB[i]);
                    if (Form2.lineBCVisible == true) g.DrawLine(Pens.Black, pointsB[i], pointsC[i]);
                    if (Form2.lineCAVisible == true) g.DrawLine(Pens.Black, pointsC[i], pointsA[i]);

                    if (Form2.pointAVisible == true) g.FillRectangle(Brushes.Red, x_coor(Form2.radiusA, Form2.theta * Form2.valA) + Form2.x_re, y_coor(Form2.radiusA, Form2.theta * Form2.valA) + Form2.y_re, Form2.sizeA, Form2.sizeA);
                    if (Form2.pointBVisible == true) g.FillRectangle(Brushes.Blue, x_coor(Form2.radiusB, Form2.theta * Form2.valB) + Form2.x_re, y_coor(Form2.radiusB, Form2.theta * Form2.valB) + Form2.y_re, Form2.sizeB, Form2.sizeB);
                    if (Form2.pointCVisible == true) g.FillRectangle(Brushes.Green, x_coor(Form2.radiusC, Form2.theta * Form2.valC) + Form2.x_re, y_coor(Form2.radiusC, Form2.theta * Form2.valC) + Form2.y_re, Form2.sizeC, Form2.sizeC);
                }
                    
            }

            if (check==true)
            {
                check = false;
                using (Graphics g = Graphics.FromImage(bmp))
                    g.FillRectangle(Brushes.White, 0,0,3000,3000);
                pointsA.Clear();
                pointsB.Clear();
                pointsC.Clear();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();

        }
    }
}
