using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            if (Form3.alergies.Contains("Chicken") && Form5.illness.Contains("Heart Condition") && Form6.dish.Contains("Vegetarian") && Form7.gulay.Contains("Flexitarian") && FitCheck.exercise.Contains("Strength Training"))
            {
                
                            
                label1.Text = "AVOID: Chiken meat, Chicken broth,\nprocessed foods" +
                    "\nHeart Condition: fried foods and\nprocessed meats";
                label4.Text = "Recommendations: Plant-based proteins:\ntofu, lentils, beans and tempeh,quinoa" +
                    "\nHeart condition: High-fiber, low sodium diets: \nfruits, vegies, and whole grains";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\Downloads\plant-based-news-vegan-food-highest-protein.jpg");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"""C:\Users\aehan\Downloads\Your paragraph text (3).png""");
                label6.Text = "•\tStanding Knee Raises – 10 reps per side\r\n\t•\tChair Squats – 2 sets of 8 reps\r\n\t•\tCalf Raises – 2 sets of 12 reps\r\n\t•\tAnkle Circles – 10 reps each direction";
                            

                        
            }

            if (Form3.alergies.Contains("Shellfish") && Form5.illness.Contains("Diabetes") && Form6.dish.Contains("Vegetarian") && Form7.gulay.Contains("Lacto-ovo vegetarian") && FitCheck.exercise.Contains("Cardio"))
            {
                
                            
                label1.Text = "AVOID: shrimp, crab, lobster, clams, and oyster \nDiabetes: Sugary drinks, pastries, sweetened cereals.";
                label4.Text = "Recommendation: Safe protein alternatives:\ntofu, beans, lentils, quinoa, tempeh \nDiabetes: at foods with low glycemic index:\noats, legumes, whole grains";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\Downloads\1703002489621.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Exercising-with-diabetes.jpg");
                label6.Text = "•\tDo the full 10-minute workout\r\n\t•\tModify to 2 sets of 5 minutes each if needed with 1-min break";
                            
                        
            }
            if (Form3.alergies.Contains("Soy") && Form5.illness.Contains("Hypertension") && Form6.dish.Contains("Pescatarian") && FitCheck.exercise.Contains("Balance Exercise"))
            {
                
                
                label1.Text = "AVOID: bread, baked goods, sauces, and chocolate \nHypertension: Processed foods (frozen meals)\npack a sodium punch ";
                label4.Text = "Recommendation: Choose naturally \nsoy-free proteins like eggs, lentils, peas, and fish.\nHypertension: Eat potassium-rich foods:\nspinach, avocados, bananas, and beans. ";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\Downloads\gettyimages-1165675132.jpg");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Your paragraph text (4).png");
                label6.Text = "•\tHeel-to-Toe Walk – 2 sets of 10 steps\r\n\t•\tSingle-Leg Stand – 30 seconds per leg × 2\r\n\t•\tSide Leg Raise – 10 reps per leg × 2 sets\r\n\t•\tDeep Breathing Cool-down – 2 minutes";
                        
                    
                
            }
            if (Form3.alergies.Contains("Wheat") && (Form5.illness.Contains("Joint problems") && Form6.dish.Contains("Pescatarian") && FitCheck.exercise.Contains("Balance Exercise")))
            {
                
                label1.Text = "AVOID: Bread, pasta, cereals, crackers, soy sauce,\n and baked goods\nJoint Problems: sugar, red meat, trans fats,\nand highly processed food  ";
                label4.Text = "Recommendation: gluten-free grains like rice,\nquinoa, millet, salmon, tuna, sardines, shrimp,.\nJoint Problems: Go anti-inflammatory:\nsalmon, berries, leafy greens, olive oil, and turmeric.";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\OneDrive\Pictures\Screenshots\Screenshot 2025-05-31 184712.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Untitled design (1).png");
                label6.Text = "•\tStanding Knee Raises – 10 reps per side\r\n\t•\tChair Squats – 2 sets of 8 reps\r\n\t•\tCalf Raises – 2 sets of 12 reps\r\n\t•\tAnkle Circles – 10 reps each direction";
                        
            }
            if (Form3.alergies.Contains("Egg") && Form5.illness.Contains("Chronic Fatigue Syndrome") && Form6.dish.Contains("Vegetarian") && Form7.gulay.Contains("Vegan") && FitCheck.exercise.Contains("Flexibility"))
            {
                
                label1.Text = "AVOID: scrambled eggs, omelets, mayonnaise,\negg noodles, baked goods with eggs.\nChronic Fatigue: High-sugar, low-nutrient snacks—they\nspike energy then cause a crash.";
                label4.Text = "Recommendation: dark leafy greens, beans,\nlentils, whole grains, nuts, and seeds.\nChronic Fatigue: Eat small, focused on whole grains,\nvegetables, lean proteins, and anti-inflammatory foods.";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\OneDrive\Pictures\Screenshots\Screenshot 2025-05-31 185044.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\13030_2019_171_Fig1_HTML.png");
                label6.Text = "•\tPerform each stretch for 20–30 seconds\r\n\t•\tTotal session: 10–15 minutes\r\n\t•\tFocus on slow breathing and gentle movements";
                            
            }
            if (Form3.alergies.Contains("Fish") && Form5.illness.Contains("Post Surgery Recovery") && Form6.dish.Contains("Vegetarian") && Form7.gulay.Contains("Flexitarian") && FitCheck.exercise.Contains("Balance Exercise"))
            {
                
                label1.Text = "AVOID: All forms of fish (tuna, salmon, cod, etc.),\nfish sauces, and broths\nPost Surgery Recovery: Excess sugar, alcohol,\nprocessed foods, and fried items ";
                label4.Text = "Recommendation: Stick to plant-based proteins and\nchicken, and eggs\nPost Surgery Recovery: vitamin C-rich fruits\n(like oranges, berries), dark leafy greens, and whole grains.";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\OneDrive\Pictures\Screenshots\Screenshot 2025-05-31 185706.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Your paragraph text (5).png");
                label6.Text = "•\tSingle-Leg Balance – 30 seconds per leg × 3\r\n\t•\tStep-Ups – 10 reps per leg\r\n\t•\tHeel-to-Toe Walk – 10 steps × 2 sets\r\n\t•\tUse a chair for support if needed\r\n";
                            
            }
            if (Form3.alergies.Contains("Peanuts") && Form5.illness.Contains("Lung Condition") && Form6.dish.Contains("Pescatarian") && FitCheck.exercise.Contains("Balance Exercise"))
            {
                
                label1.Text = "AVOID: All tree nuts (walnuts, almonds,\ncashews, pistachios, pecans, etc.)\nLung Condition: salty foods, fried foods,\nprocessed meats, carbonated beverages, and\ndairy products ";
                label4.Text = "Recommendation: Use safe protein sources like seeds\n(pumpkin, sunflower), legumes and dairy (if tolerated)\nLung Condition: tomatoes and tomato product,\nlentils, beans, fruits, vegatables, and fish";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\Downloads\intro-1611754960.jpg");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Your paragraph text (6).png");
                label6.Text = "•\tMarching in Place – 1 minute\r\n\t•\tHeel Raises – 2 sets of 10 reps\r\n\t•\tSide Step Touch – 10 reps per side\r\n\t•\tRest and deep breaths after each set";
                        
            }
            if (Form3.alergies.Contains("Sesame") && Form5.illness.Contains("Previous injuries") && Form6.dish.Contains("Vegetarian") && Form7.gulay.Contains("Vegan") && FitCheck.exercise.Contains("Balance Exercise"))
            {
                
                label1.Text = "AVOID: Baked goods, crackers, chips hummus, tahini\nPrevious Injuries: pastries, candy, soda, ice cream,\nbutter, full-fat dairy, and fried foods";
                label4.Text = "Recommendation: Fruits, vegetable, grains, and poultry\nPrevious Injuries: Tofu, seitan, nuts,\nsweet potatoes, corn, and fruits.";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\OneDrive\Pictures\Screenshots\Screenshot 2025-06-01 095504.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Your paragraph text (7).png");
                label6.Text = "\t•\tBOSU Balance – 30 seconds x 2\r\n\t•\tForward Lunge Hold – 20 seconds per leg\r\n\t•\tLateral Step – 10 reps per side\r\n\t•\tRepeat circuit once";
                            
            }
            if (Form3.alergies.Contains("Treenuts") && Form5.illness.Contains("Gout") && Form6.dish.Contains("Vegatarian") && Form7.gulay.Contains("Lacto-ovo vegetarian") && FitCheck.exercise.Contains("Balance Exercise"))
            {
                
                label1.Text = "AVOID: Almonds, Beechnuts, Brazil Nuts, Butternuts,\nalmond butter, almond milk and almond oil\nGout: Red meat, organ meat, Certain seafood\n(shrimp, lobster, mussels, as well as\nfish like anchovies, sardines, and tuna.";
                label4.Text = "Recommendation: fruits, vegetables,\nand enriched grains\nGout:milk, yogurt, cottage cheese,\nvegetables, fruits,tofu and tempeh";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\Downloads\9122438.jpg");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\Your paragraph text (8).png");
                label6.Text = "\t•\tToe Taps – 10 reps per foot\r\n\t•\tStanding Clock Reach – 5 reps per direction\r\n\t•\tHip Openers – 10 reps per leg\r\n\t•\tTry 2 rounds if tolerated";
                            
            }
            if (Form3.alergies.Contains("Milk") && Form5.illness.Contains("Scoliosis") && Form6.dish.Contains("Vegatarian") && Form7.gulay.Contains("Flexitarian") && FitCheck.exercise.Contains("Flexibility"))
            {
               
                label1.Text = "AVOID: Milk (all types), butter, cheese (all types),\nyogurt, ice cream, sour cream, and buttermilk\nScoliosis: Processed food, sugary drinks,\nalcohol, fast food, caffeine";
                label4.Text = "Recommendation: Fruits, vegetables, grains,\nlegumes, eggs, vegetable oil, meat fat,\nlard and bacon";
                pictureBox1.Size = new Size(296, 162);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(@"C:\Users\aehan\OneDrive\Pictures\Screenshots\Screenshot 2025-06-01 104651.png");
                pictureBox2.Size = new Size(296, 162);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(@"C:\Users\aehan\Downloads\1711487501419.jpg");
                label6.Text = "\t•\tHold each stretch for 20–30 seconds\r\n\t•\tRepeat stretches 2 times\r\n\t•\tFocus on side stretches and spinal elongation";
                            
            }





        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.cbheartCondition_CheckedChanged(sender, e);
            Form6 form6 = new Form6();
            form6.checkBox1_CheckedChanged_1(sender, e);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
