using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraC_
{
    public partial class Form1 : Form
    {
        private double val1;
        private double val2;
        private double resultado;
        private int ope;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text+"0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            val2 = Convert.ToDouble(txt1.Text);
            switch (ope)
            {
                case 1:
                    resultado = val1 + val2;
                    break;
                case 2:
                    resultado = val1 - val2;
                    break;
                case 3:
                    resultado = val1 * val2;
                    break;
                case 4:
                    resultado = val1 / val2;
                    break;

            }
            txt1.Text = resultado.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            ope = 1;
            val1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ope = 2;
            val1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            ope = 3;
            val1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ope = 4;
            val1 = Convert.ToDouble(txt1.Text);
            txt1.Text = "";
        }
    }
}
