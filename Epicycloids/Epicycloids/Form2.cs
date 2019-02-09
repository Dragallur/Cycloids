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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        public static double theta = 0;
        public static double thetaStep = 1;
        public static int interval = 1;
        public static int radiusA = 100;
        public static int radiusB = 100;
        public static int radiusC = 100;
        public static int x_re = 50;
        public static int y_re = 50;
        public static int valA = 1;
        public static int valB = 1;
        public static int valC = 1;
        public static int sizeA = 1;
        public static int sizeB = 1;
        public static int sizeC = 1;
        public static bool pointAVisible = false;
        public static bool pointBVisible = false;
        public static bool pointCVisible = false;
        public static bool lineABVisible = false;
        public static bool lineBCVisible = false;
        public static bool lineCAVisible = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.bmp.Save("pic1.png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            valA = Convert.ToInt16(valACycle.Text);
        }

        private void valBCycle_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            valB = Convert.ToInt16(valBCycle.Text);
        }

        private void valCCycle_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            valC = Convert.ToInt16(valCCycle.Text);
        }

        private void pointACheck_CheckedChanged(object sender, EventArgs e)
        {
            pointAVisible = !pointAVisible;
        }

        private void pointBCheck_CheckedChanged(object sender, EventArgs e)
        {
            pointBVisible = !pointBVisible;
        }

        private void pointCCheck_CheckedChanged(object sender, EventArgs e)
        {
            pointCVisible = !pointCVisible;
        }

        private void ABVisibleCheck_CheckedChanged(object sender, EventArgs e)
        {
            lineABVisible = !lineABVisible;
        }

        private void BCVisibleCheck_CheckedChanged(object sender, EventArgs e)
        {
            lineBCVisible = !lineBCVisible;
        }

        private void CAVisibleCheck_CheckedChanged(object sender, EventArgs e)
        {
            lineCAVisible = !lineCAVisible;
        }

        private void ARadius_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            radiusA = Convert.ToInt16(ARadius.Text);
        }

        private void BRadius_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            radiusB = Convert.ToInt16(BRadius.Text);
        }

        private void CRadius_TextChanged(object sender, EventArgs e)
        {
            Form1.check = false;
            radiusC = Convert.ToInt16(CRadius.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(Form1.bmp))
                g.FillRectangle(Brushes.White, 0, 0, 3000, 3000);
            Form1.pointsA.Clear();
            Form1.pointsB.Clear();
            Form1.pointsC.Clear();
        }

        private void thetaText_TextChanged(object sender, EventArgs e)
        {
            thetaStep = Convert.ToDouble(thetaText.Text);
        }

        private void intervalText_TextChanged(object sender, EventArgs e)
        {
            interval = Convert.ToInt16(intervalText.Text);
        }

        private void xPos_TextChanged(object sender, EventArgs e)
        {
            x_re = Convert.ToInt16(xPos.Text);
        }

        private void yPos_TextChanged(object sender, EventArgs e)
        {
            y_re = Convert.ToInt16(yPos.Text);
        }

        private void sizeAText_TextChanged(object sender, EventArgs e)
        {
            sizeA = Convert.ToInt16(sizeAText.Text);
        }

        private void sizeBText_TextChanged(object sender, EventArgs e)
        {
            sizeB = Convert.ToInt16(sizeBText.Text);
        }

        private void sizeCText_TextChanged(object sender, EventArgs e)
        {
            sizeC = Convert.ToInt16(sizeCText.Text);
        }
    }
}
