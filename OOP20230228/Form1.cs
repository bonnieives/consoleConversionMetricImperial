using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Code by Bonnie Ives de Castro Nunes
// LaSalle College - 2023=02=28

// This program reads a measure in metric units then convert it to imperial units

namespace OOP20230228
{
    public partial class frmAreaConvert : Form
    {
        public frmAreaConvert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App.? ",
                "Exit", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                MessageBox.Show("You decided to quit.");
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConvertArea number = new ConvertArea();
            try
            {
                number.Number1 = Convert.ToDouble(textBox1.Text);
                textBox5.Text = number.ToSquareInches().ToString();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Focus();
                textBox1.Text = "0";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConvertArea number = new ConvertArea();
            try
            {
                number.Number1 = Convert.ToDouble(textBox2.Text);
                textBox6.Text = number.ToSquareYards().ToString();
                textBox2.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Focus();
                textBox2.Text = "0";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConvertArea number = new ConvertArea();
            try
            {
                number.Number1 = Convert.ToDouble(textBox3.Text);
                textBox7.Text = number.ToAcre().ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox3.Focus();
                textBox3.Text = "0";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConvertArea number = new ConvertArea();            
            try
            {
                number.Number1 = Convert.ToDouble(textBox4.Text);
                textBox8.Text = number.ToSquareMiles().ToString();
                textBox4.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox4.Focus();
                textBox4.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "0";
            textBox1.ReadOnly = false;
            textBox2.Text = "0";
            textBox2.ReadOnly = false;
            textBox3.Text = "0";
            textBox3.ReadOnly = false;
            textBox4.Text = "0";
            textBox4.ReadOnly = false;
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
        }

        private void x(object sender, EventArgs e)
        {

        }
    }
}
