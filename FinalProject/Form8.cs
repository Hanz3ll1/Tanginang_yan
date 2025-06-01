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
    public partial class Form8 : Form
    {
        public static List<string> raw = [];
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (var meat in clbCarnivore.CheckedItems)
            {
                raw.Add(meat.ToString()!);
            }

            FitCheck form9 = new FitCheck();
            form9.ShowDialog();
            this.Hide();
            return;
        }
    }
}
