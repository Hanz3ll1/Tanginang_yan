using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FitCheck : Form
    {
        public static List<string> exercise = [];
        public FitCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void clbWorkout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (var vegitarian in clbWorkout.CheckedItems)
            {
                exercise.Add(vegitarian.ToString()!);
                Form10 form10 = new Form10();
                form10.ShowDialog();
                this.Hide();
                return;
            }

            

            
        }
    }
}
