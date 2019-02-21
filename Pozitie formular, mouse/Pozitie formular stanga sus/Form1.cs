using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pozitie_formular_stanga_sus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.label1.Text = System.Convert.ToString(this.Location.X);
            this.label2.Text = System.Convert.ToString(this.Location.Y);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label6.Text = System.Convert.ToString(MousePosition.X);
            this.label8.Text = System.Convert.ToString(MousePosition.Y);
            if ((Control.MousePosition.X >= this.Location.X) && (Control.MousePosition.X - this.Location.X <= this.Width)
                && (Control.MousePosition.Y >= this.Location.Y) && (Control.MousePosition.Y - this.Location.Y <= this.Height))
            {
                this.label11.Text = System.Convert.ToString(MousePosition.X);
                this.label12.Text = System.Convert.ToString(MousePosition.Y);
            }
            else
            {
                this.label11.Text = "Mouse-ul nu este pe form.";
                this.label12.Text = "Mouse-ul nu este pe form.";
            }

        }
    }
}
