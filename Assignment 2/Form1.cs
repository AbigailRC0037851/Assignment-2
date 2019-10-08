using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double PR1, PR2;

            try
            {
                PR1 = double.Parse(textBox22.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR1 = 0.0;
            }
            try
            {
                PR2 = double.Parse(textBox23.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR2 = 0.0;
            }
            double resistance = 1 / 1 / PR1 + 1 / PR2;
            label16.Text = "" + resistance;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double SR1, SR2;

            try
            {
                 SR1 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR1 = 0.0;
            }
            try
            {
                SR2 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR2 = 0.0;
            }
            double resistance = SR1 + SR2;
            label8.Text = "" + resistance;




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double SR3, SR4, SR5;

            try
            {
                SR3 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR3 = 0.0;
            }
            try
            {
                SR4 = double.Parse(textBox11.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR4 = 0.0;
            }
            try
            {
                SR5 = double.Parse(textBox12.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                SR5 = 0.0;
            }
            double resistance = SR3 + SR4 + SR5;
            label9.Text = "" + resistance;
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double PR3, PR4, PR5;

            try
            {
                PR3 = double.Parse(textBox24.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR3 = 0.0;
            }
            try
            {
                PR4 = double.Parse(textBox25.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR4 = 0.0;
            }
            try
            {
                PR5 = double.Parse(textBox26.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                PR5 = 0.0;
            }
            double resistance = 1.0 / (1.0 / PR3 + 1.0 / PR4 + 1.0 / PR5);
            label15.Text = "" + resistance;
        }
    }
    

    
    
}
