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
            foreach (var meat in clbCarnivore.CheckedItems)
            {
                raw.Add(meat.ToString()!);
            }

            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Hide();
            return;
            /* if (cbHardCoreCarnivore.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbKetoCarnivore.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbLionDiet.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbModifiedCarnivore.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }

            if (cbStandardCarnivore.Checked)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Hide();
                return;
            }*/
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
