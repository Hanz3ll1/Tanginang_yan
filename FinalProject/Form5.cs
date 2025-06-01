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
    public partial class Form5 : Form
    {
        public static List<string> illness = [];
        public Form5()
        {
            InitializeComponent();
        }

        public void checkBox10_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnNext1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {
            foreach (var sick in clbIllness.CheckedItems)
            {
                illness.Add(sick.ToString()!);
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            

        }

        public void cbheartCondition_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void clbIllness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

