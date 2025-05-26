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
            foreach(var sick in clbIllness.CheckedItems)
            {
                illness.Add(sick.ToString()!);
            }
            Form6 form6 = new Form6();
            form6.ShowDialog();
            this.Hide(); return;
            /*if (cbHypertension.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }

            if (cbheartCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbHypertension.Checked && cbheartCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbDiabetes.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbJointProblems.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbPreviousInjuries.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbHypertension.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide();
                return;
            }
            if (cbheartCondition.Checked && cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbDiabetes.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbJointProblems.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbPreviousInjuries.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbheartCondition.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbDiabetes.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbJointProblems.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPreviousInjuries.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbDiabetes.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbJointProblems.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbChronicFatigueSyndrome.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbPreviousInjuries.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbDiabetes.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbChronicFatigueSyndrome.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbChronicFatigueSyndrome.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbChronicFatigueSyndrome.Checked && cbPostSurgeryRecovery.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbChronicFatigueSyndrome.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPostSurgeryRecovery.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPostSurgeryRecovery.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbPostSurgeryRecovery.Checked && cbLungCondition.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbLungCondition.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbLungCondition.Checked && cbGout.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }
            if (cbGout.Checked && cbScoliosis.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Hide(); return;
            }*/
        }

        public bool cbheartCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbheartCondition.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void clbIllness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

