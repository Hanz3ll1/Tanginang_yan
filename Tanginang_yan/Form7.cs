using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanginang_yan
{
    public partial class Form7 : Form
    {
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
            if (cbFexitarian.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbLactoOvoVegetarian.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbLactoVegetarian.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbOvoVegetarian.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbRawVegan.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbVegan.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }
        }
    }
}
