using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Patratul_unui_numar_folosind_functii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Decimal patrat(System.Decimal x)
        {
            return x * x;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            System.Decimal n, p;
            n = this.numericUpDown1.Value;
            p = patrat(n);
            this.label3.Text = System.Convert.ToString(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
