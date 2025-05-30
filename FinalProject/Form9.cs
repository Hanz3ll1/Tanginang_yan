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
    public partial class Form9 : Form
    {
        public static List<string> exercise = [];
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach (var vegitarian in clbWorkout.CheckedItems)
            {
                exercise.Add(vegitarian.ToString()!);
            }

            Form10 form10 = new Form10();
            form10.ShowDialog();
            this.Hide();
            return;
            /* if (cbBalanceExcercise.Checked)
             {
                 Form10 form10 = new Form10();
                 form10.ShowDialog();
                 this.Hide(); return;
             }
             if (cbCardio.Checked)
             {
                 Form10 form10 = new Form10();
                 form10.ShowDialog(); 
                 this.Hide(); return;
             }
             if (cbFlexibility.Checked)
             {
                 Form10 form10= new Form10();
                 form10.ShowDialog();
                 this.Hide(); return;
             }
             if (cbStrengthTraining.Checked)
             {
                 Form10 form10 = new Form10();
                 form10.ShowDialog();
                 this.Hide(); return;
             }*/
        }
    }
}
