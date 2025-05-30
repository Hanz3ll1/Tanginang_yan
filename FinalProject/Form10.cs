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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

        }

        public void Form10_Load(object sender, EventArgs e)
        {
            //alergies part
            if (Form3.alergies.Contains("Chicken"))
            {
                if(Form5.illness.Contains("Heart Condition"))
                {
                    if(Form6.dish.Contains("Vegatarian"))
                    {
                        if(Form7.gulay.Contains("Fexitarian"))
                        {
                            if(Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz at si ivan lang ang nag buuhat dito ";
                            }
                        }
                    }
                }
            }

            if (Form3.alergies.Contains("Shellfish"))
            {
                if (Form5.illness.Contains("Diabetes"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Lacto-ovo vegetarian"))
                        {
                            if (Form9.exercise.Contains("Cardio"))
                            {
                                label1.Text = "Aehanz lang magaling";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Soy"))
            {
                if (Form5.illness.Contains("Hypertension"))
                {
                    if (Form6.dish.Contains("Pescatarian"))
                    {
                        if (Form9.exercise.Contains("Balance Exercise"))
                        {
                            label1.Text = "Aehanz namujane";
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Wheat"))
            {
                if (Form5.illness.Contains("Joint Problems"))
                {
                    if (Form6.dish.Contains("Pescatarian"))
                    {
                        if (Form9.exercise.Contains("Balance Exercise"))
                        {
                            label1.Text = "Aehanz Kyle";
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Egg"))
            {
                if (Form5.illness.Contains("Chronic Fatigue"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Vegan"))
                        {
                            if (Form9.exercise.Contains("Flexibility"))
                            {
                                label1.Text = "Aehanz Versosa";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Fish"))
            {
                if (Form5.illness.Contains("Post Surgery Recovery"))
                {
                    if (Form6.dish.Contains("Mix"))
                    {
                        if (Form9.exercise.Contains("Balance"))
                        {
                            label1.Text = "Aehanz Gray";
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Pea-nuts"))
            {
                if (Form5.illness.Contains("Lung Condition"))
                {
                    if (Form6.dish.Contains("Pescatarian"))
                    {
                        if (Form9.exercise.Contains("Balance Exercise"))
                        {
                            label1.Text = "Aehanz Gesmundo";
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Sesame"))
            {
                if (Form5.illness.Contains("Previous Injuries"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Vegan"))
                        {
                            if (Form9.exercise.Contains("Balance Exercise"))
                            {
                                label1.Text = "Aehanz Almadin";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Tree-nuts"))
            {
                if (Form5.illness.Contains("Gout"))
                {
                    if (Form6.dish.Contains("Mix"))
                    {
                        if (Form9.exercise.Contains("Balance Excercise"))
                        {
                            label1.Text = "Aehanz strata";
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Milk"))
            {
                if (Form5.illness.Contains("Scoliosis"))
                {
                    if (Form6.dish.Contains("Mix"))
                    {
                        if (Form9.exercise.Contains("Flexibility"))
                            {
                                label1.Text = "Aehanz kurba";
                            }
                    }
                }
            }
           
            // dish part
            if (Form3.alergies.Contains("Shellfish"))
            {
                if (Form5.illness.Contains("Previous injuries"))
                {
                    if (Form6.dish.Contains("Carnivore"))
                    {
                        if (Form8.raw.Contains("Hardcore Carnivore"))
                        {
                            if (Form9.exercise.Contains("Cardio"))
                            {
                                label1.Text = "Aehanz takutt akoooo";
                            }
                        }
                    }
                }
            }

            if (Form3.alergies.Contains("Soy"))
            {
                if (Form5.illness.Contains("Diabetes"))
                {
                    if (Form6.dish.Contains("Pescatarian"))
                    {
                        if (Form9.exercise.Contains("Cardio"))
                        {
                            label1.Text = "Aehanz Pogi";
                        }
                    }
                }
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
