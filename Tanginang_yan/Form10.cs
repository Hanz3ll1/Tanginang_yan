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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

        }

        public void Form10_Load(object sender, EventArgs e)
        {
                label1.Text = string.Join(", ", Form3.alergies);
            if (Form3.alergies.Contains("Chicken"))
            {

            }
            

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.cbheartCondition_CheckedChanged(sender, e);
            Form6 form6 = new Form6();
            form6.checkBox1_CheckedChanged_1(sender, e);

            if (form5.cbheartCondition_CheckedChanged(sender, e))
            {
                
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
