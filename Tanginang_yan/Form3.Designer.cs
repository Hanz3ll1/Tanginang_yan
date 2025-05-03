namespace Tanginang_yan
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbMilk = new CheckBox();
            cbEggs = new CheckBox();
            cbFish = new CheckBox();
            cbCrustaceanShellfish = new CheckBox();
            cbTreeNuts = new CheckBox();
            CbPeaNuts = new CheckBox();
            cbWheat = new CheckBox();
            cbSoy = new CheckBox();
            cbSesame = new CheckBox();
            cbChicken = new CheckBox();
            btnNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbMilk
            // 
            cbMilk.AutoSize = true;
            cbMilk.Location = new Point(190, 120);
            cbMilk.Name = "cbMilk";
            cbMilk.Size = new Size(59, 24);
            cbMilk.TabIndex = 0;
            cbMilk.Text = "Milk";
            cbMilk.UseVisualStyleBackColor = true;
            // 
            // cbEggs
            // 
            cbEggs.AutoSize = true;
            cbEggs.Location = new Point(190, 159);
            cbEggs.Name = "cbEggs";
            cbEggs.Size = new Size(63, 24);
            cbEggs.TabIndex = 1;
            cbEggs.Text = "Eggs";
            cbEggs.UseVisualStyleBackColor = true;
            // 
            // cbFish
            // 
            cbFish.AutoSize = true;
            cbFish.Location = new Point(190, 197);
            cbFish.Name = "cbFish";
            cbFish.Size = new Size(56, 24);
            cbFish.TabIndex = 2;
            cbFish.Text = "Fish";
            cbFish.UseVisualStyleBackColor = true;
            // 
            // cbCrustaceanShellfish
            // 
            cbCrustaceanShellfish.AutoSize = true;
            cbCrustaceanShellfish.Location = new Point(190, 238);
            cbCrustaceanShellfish.Name = "cbCrustaceanShellfish";
            cbCrustaceanShellfish.Size = new Size(162, 24);
            cbCrustaceanShellfish.TabIndex = 3;
            cbCrustaceanShellfish.Text = "Crustacean Shellfish";
            cbCrustaceanShellfish.UseVisualStyleBackColor = true;
            // 
            // cbTreeNuts
            // 
            cbTreeNuts.AutoSize = true;
            cbTreeNuts.Location = new Point(189, 278);
            cbTreeNuts.Name = "cbTreeNuts";
            cbTreeNuts.Size = new Size(90, 24);
            cbTreeNuts.TabIndex = 4;
            cbTreeNuts.Text = "Tree nuts";
            cbTreeNuts.UseVisualStyleBackColor = true;
            // 
            // CbPeaNuts
            // 
            CbPeaNuts.AutoSize = true;
            CbPeaNuts.Location = new Point(508, 120);
            CbPeaNuts.Name = "CbPeaNuts";
            CbPeaNuts.Size = new Size(87, 24);
            CbPeaNuts.TabIndex = 5;
            CbPeaNuts.Text = "Pea-nuts";
            CbPeaNuts.UseVisualStyleBackColor = true;
            // 
            // cbWheat
            // 
            cbWheat.AutoSize = true;
            cbWheat.Location = new Point(508, 159);
            cbWheat.Name = "cbWheat";
            cbWheat.Size = new Size(74, 24);
            cbWheat.TabIndex = 6;
            cbWheat.Text = "Wheat";
            cbWheat.UseVisualStyleBackColor = true;
            // 
            // cbSoy
            // 
            cbSoy.AutoSize = true;
            cbSoy.Location = new Point(508, 197);
            cbSoy.Name = "cbSoy";
            cbSoy.Size = new Size(55, 24);
            cbSoy.TabIndex = 7;
            cbSoy.Text = "Soy";
            cbSoy.UseVisualStyleBackColor = true;
            // 
            // cbSesame
            // 
            cbSesame.AutoSize = true;
            cbSesame.Location = new Point(508, 238);
            cbSesame.Name = "cbSesame";
            cbSesame.Size = new Size(82, 24);
            cbSesame.TabIndex = 8;
            cbSesame.Text = "Sesame";
            cbSesame.UseVisualStyleBackColor = true;
            cbSesame.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // cbChicken
            // 
            cbChicken.AutoSize = true;
            cbChicken.Location = new Point(508, 278);
            cbChicken.Name = "cbChicken";
            cbChicken.Size = new Size(82, 24);
            cbChicken.TabIndex = 9;
            cbChicken.Text = "Chicken";
            cbChicken.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(347, 365);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 52);
            label1.Name = "label1";
            label1.Size = new Size(273, 29);
            label1.TabIndex = 11;
            label1.Text = "Do you have any allergies?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(cbChicken);
            Controls.Add(cbSesame);
            Controls.Add(cbSoy);
            Controls.Add(cbWheat);
            Controls.Add(CbPeaNuts);
            Controls.Add(cbTreeNuts);
            Controls.Add(cbCrustaceanShellfish);
            Controls.Add(cbFish);
            Controls.Add(cbEggs);
            Controls.Add(cbMilk);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbMilk;
        private CheckBox cbEggs;
        private CheckBox cbFish;
        private CheckBox cbCrustaceanShellfish;
        private CheckBox cbTreeNuts;
        private CheckBox CbPeaNuts;
        private CheckBox cbWheat;
        private CheckBox cbSoy;
        private CheckBox cbSesame;
        private CheckBox cbChicken;
        private Button btnNext;
        private Label label1;
    }
}