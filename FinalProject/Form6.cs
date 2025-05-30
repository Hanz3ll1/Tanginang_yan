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
            if (cbVegatarian.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
                return;
            }
        }

        public void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

            foreach (var food in clbFood.CheckedItems)
            {
                dish.Add(food.ToString()!);

                if (clbFood.CheckedItems.Contains("Vegatarian"))
                {
                    Form7 form7 = new Form7();
                    form7.ShowDialog();
                    this.Hide();
                    return;
                }
                else if (clbFood.CheckedItems.Contains("Mix"))
                {
                    Form9 form9 = new Form9();
                    form9.ShowDialog();
                    this.Hide(); return;
                }

                else if (clbFood.CheckedItems.Contains("Carnivore"))
                {
                    Form9 form9 = new Form9();
                    form9.ShowDialog();
                    this.Hide(); return;
                }

               else if (clbFood.CheckedItems.Contains("Pescatarian") )
                {
                    Form9 form9 = new Form9();
                    form9.ShowDialog();
                    this.Hide(); return;
                }
                
            }
            

            

            
            /* if (cbVegatarian.Checked)
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();
                return;
            }

            if (cbCarnivore.Checked)
            {
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide(); return;
            }

            if (cbPescatarian.Checked || cbMix.Checked)
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
                return;
            }*/


        }

        private void cbCarnivore_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
