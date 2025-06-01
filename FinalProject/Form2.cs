using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            string height, weight;
            height = txtHeight.Text.ToString();
            weight = txtWeight.Text.ToString();


            try
            {
                if (txtHeight != null && txtWeight != null)
                {

                    double heightnum = Convert.ToDouble(txtHeight.Text);
                    double weightnum = Convert.ToDouble(txtWeight.Text);


                    double bmi = (weightnum / (heightnum * heightnum));

                    lblBMI.Text = $"{bmi:F2}";
                }
            }
            catch (Exception) { }
        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
