using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sfera_cu_raze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_rosu;
        System.Drawing.Pen Creion_albastru;
        System.Drawing.SolidBrush Radiera;
        int i, x0, y0, w, alfa, xc, yc, x, y, alfa_i;
        double  alfar, alfa_o;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Desen = this.CreateGraphics();
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.BlueViolet);
            Radiera = new System.Drawing.SolidBrush(this.BackColor);
            x0 = 100;//coordonata x a cercului
            y0 = 100;//coordonata y a cercului
            w = 200;//Diametrul cercului
            //alfa_i=90;
            //alfa = 0;
            xc=x0+w/2;//Deplasarea 
            yc = y0 + w / 2;
            Desen.DrawEllipse(Creion_rosu, x0, y0, w, w);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int secunde, ora;
            ora = System.DateTime.Now.Minute;
            secunde = System.DateTime.Now.Second;
            this.label1.Text = Convert.ToString(ora)+ ":" + Convert.ToString(secunde);
                Desen.FillEllipse(Radiera, x0 + 1, y0 + 1, w - 2, w - 2);
                alfar = System.Math.PI / 2 - System.Math.PI / 30 * secunde;
        
                x = xc + System.Convert.ToInt16(w / 2 * (Math.Cos(alfar)));
                y = yc - System.Convert.ToInt16(w / 2 * (Math.Sin(alfar)));
                Desen.DrawLine(Creion_rosu, xc, yc, x, y);

                alfa_o = System.Math.PI / 2 - System.Math.PI / 12 * ora;
                x = xc + System.Convert.ToInt16(w / 2 * (Math.Cos(alfa_o)));
                y = yc - System.Convert.ToInt16(w / 2 * (Math.Sin(alfa_o)));
                Desen.DrawLine(Creion_rosu, xc, yc, x, y);
        }
    }
}


