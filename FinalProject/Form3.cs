using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.Form3;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public static List<string> alergies = [];
        public Form3()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        public void cbMilk_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbMilk.Checked)
            //{
            //    alergies.Add(cbMilk.Text);
            //}
        }




        public void label2_Click(object sender, EventArgs e)
        {
            foreach (var alergy in clbAllergies.CheckedItems)
            {
                alergies.Add(alergy.ToString()!);
            }

            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Hide();
            return;

            //if (cbChicken.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbCrustaceanShellfish.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbEggs.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbFish.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbMilk.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbSesame.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbSoy.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbTreeNuts.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbWheat.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (CbPeaNuts.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}

            //if (cbNone.Checked)
            //{
            //    Form4 form4 = new Form4();
            //    form4.ShowDialog();
            //    this.Hide();
            //    return;
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTreeNuts_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTreeNuts.Checked)
            {
                alergies.Add(cbTreeNuts.Text);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void clbAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbPeaNuts_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
