using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void R2_TextChanged(object sender, EventArgs e)
        {

        }

        private void R4_TextChanged(object sender, EventArgs e)
        {

        }

        private void R5_TextChanged(object sender, EventArgs e)
        {

        }

        private void R6_TextChanged(object sender, EventArgs e)
        {

        }

        private void R1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            double r4, r5, r6;
            double r1 = double.Parse(R1.Text);
            double r2 = double.Parse(R2.Text);
            double r3 = double.Parse(R3.Text);

            r4 = (r1 * r2) / (r1 + r2 + r3);
            r5 = (r3 * r2) / (r1 + r2 + r3);
            r6 = (r3 * r1) / (r1 + r2 + r3);

            R4.Text = Convert.ToString(r4);
            R5.Text = Convert.ToString(r5);
            R6.Text = Convert.ToString(r6);


        }

        private void LIMPAR_Click(object sender, EventArgs e)
        {

            R1.Text = "";
            R2.Text = "";
            R3.Text = "";
            R4.Text = "";
            R5.Text = "";
            R6.Text = "";
        }
    }
}
