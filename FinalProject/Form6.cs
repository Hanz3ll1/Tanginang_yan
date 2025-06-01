using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject
{
    public partial class Form6 : Form
    {
        public static List<string> dish = [];
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {



        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cbCarnivore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            foreach (var food in clbFood.CheckedItems)
            {
                dish.Add(food.ToString()!);

                if (clbFood.CheckedItems.Contains("Vegetarian"))
                {
                    Form7 form7 = new Form7();
                    form7.ShowDialog();
                    this.Hide();
                    return;
                }
                else if (clbFood.CheckedItems.Contains("Mix"))
                {
                    FitCheck form9 = new FitCheck();
                    form9.ShowDialog();
                    this.Hide(); return;
                }

                else if (clbFood.CheckedItems.Contains("Carnivore"))
                {
                    Form form8 = new Form8();
                    form8.ShowDialog();
                    this.Hide(); return;
                }

                else if (clbFood.CheckedItems.Contains("Pescatarian"))
                {
                    FitCheck form9 = new FitCheck();
                    form9.ShowDialog();
                    this.Hide(); return;
                }

            }
        }
    }
}
