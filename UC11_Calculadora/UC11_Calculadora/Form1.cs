using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Calculadora
{
    public partial class Form1 : Form
    {
        int contarVIRGULAS = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "1";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "1";
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            labelDISPLAY.Text = "0";
            contarVIRGULAS = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "2";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "3";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "4";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "5";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "6";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "7";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "8";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text == "0")
            {
                labelDISPLAY.Text = "9";
            }
            else
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (labelDISPLAY.Text != "0")
            {
                labelDISPLAY.Text = labelDISPLAY.Text + "0";
            }
        }

        private void buttonVIRGULA_Click(object sender, EventArgs e)
        {
            if (contarVIRGULAS < 1)
            {
                labelDISPLAY.Text = labelDISPLAY.Text + ",";
                contarVIRGULAS++;
            }

        }

        private void buttonMULT_Click(object sender, EventArgs e)
        {

        }

        private void buttonIGUAL_Click(object sender, EventArgs e)
        {

        }

        private void buttonSOMA_Click(object sender, EventArgs e)
        {
            n1 = 
        }
    }
}
