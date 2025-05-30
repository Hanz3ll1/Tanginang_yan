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
                                label1.Text = "Aehanz ganda";
                            }
                        }
                    }
                }
            }
            
            if (Form3.alergies.Contains("Shellfish"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz chararat";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Wheat"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Egg"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Fish"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Pea-nuts"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Sesane"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Tree-nuts"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz namujane";
                            }
                        }
                    }
                }
            }
            if (Form3.alergies.Contains("Milk"))
            {
                if (Form5.illness.Contains("Heart Condition"))
                {
                                label1.Text = "Aehanz pogi";
                    if (Form6.dish.Contains("Vegatarian"))
                    {
                        if (Form7.gulay.Contains("Fexitarian"))
                        {
                            if (Form9.exercise.Contains("Strength Training"))
                            {
                                label1.Text = "Aehanz pogi";
                            }
                        }
                    }
                }
            }
                                label1.Text = "Aehanz pogi";
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
                                label1.Text = "Aehanz Sarap";
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
