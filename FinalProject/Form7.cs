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
    public partial class Form7 : Form
    {
        public static List<string> gulay = [];
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form8().ShowDialog();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var vegitarian in clbVegitarian.CheckedItems)
            {
                gulay.Add(vegitarian.ToString()!);
            }

            FitCheck form9 = new FitCheck();
            form9.ShowDialog();
            this.Hide();
            return;
        }
    }
}
