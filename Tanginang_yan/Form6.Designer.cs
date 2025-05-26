namespace Tanginang_yan
{
    partial class Form6
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
            cbVegatarian = new CheckBox();
            cbCarnivore = new CheckBox();
            cbPescatarian = new CheckBox();
            cbMix = new CheckBox();
            label1 = new Label();
            clbFood = new CheckedListBox();
            SuspendLayout();
            // 
            // cbVegatarian
            // 
            cbVegatarian.AutoSize = true;
            cbVegatarian.BackColor = Color.Beige;
            cbVegatarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbVegatarian.Location = new Point(219, 105);
            cbVegatarian.Name = "cbVegatarian";
            cbVegatarian.Size = new Size(118, 27);
            cbVegatarian.TabIndex = 9;
            cbVegatarian.Text = "Vegatarian";
            cbVegatarian.UseVisualStyleBackColor = false;
            cbVegatarian.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // cbCarnivore
            // 
            cbCarnivore.AutoSize = true;
            cbCarnivore.BackColor = Color.Beige;
            cbCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCarnivore.Location = new Point(363, 105);
            cbCarnivore.Name = "cbCarnivore";
            cbCarnivore.Size = new Size(109, 27);
            cbCarnivore.TabIndex = 11;
            cbCarnivore.Text = "Carnivore";
            cbCarnivore.UseVisualStyleBackColor = false;
            cbCarnivore.CheckedChanged += cbCarnivore_CheckedChanged;
            // 
            // cbPescatarian
            // 
            cbPescatarian.AutoSize = true;
            cbPescatarian.BackColor = Color.Beige;
            cbPescatarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPescatarian.Location = new Point(487, 105);
            cbPescatarian.Name = "cbPescatarian";
            cbPescatarian.Size = new Size(121, 27);
            cbPescatarian.TabIndex = 12;
            cbPescatarian.Text = "Pescatarian";
            cbPescatarian.UseVisualStyleBackColor = false;
            // 
            // cbMix
            // 
            cbMix.AutoSize = true;
            cbMix.BackColor = Color.Beige;
            cbMix.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMix.Location = new Point(636, 105);
            cbMix.Name = "cbMix";
            cbMix.Size = new Size(62, 27);
            cbMix.TabIndex = 13;
            cbMix.Text = "Mix";
            cbMix.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 361);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 14;
            label1.Text = "Next";
            label1.Click += label1_Click_2;
            // 
            // clbFood
            // 
            clbFood.BackColor = Color.Beige;
            clbFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbFood.FormattingEnabled = true;
            clbFood.Items.AddRange(new object[] { "Vegatarian", "Carnivore", "Pescatarian", "Mix" });
            clbFood.Location = new Point(337, 164);
            clbFood.Name = "clbFood";
            clbFood.Size = new Size(150, 104);
            clbFood.TabIndex = 15;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 54, 70);
            BackgroundImage = Properties.Resources._10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(clbFood);
            Controls.Add(label1);
            Controls.Add(cbMix);
            Controls.Add(cbPescatarian);
            Controls.Add(cbCarnivore);
            Controls.Add(cbVegatarian);
            DoubleBuffered = true;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbVegatarian;
        private CheckBox cbCarnivore;
        private CheckBox cbPescatarian;
        private CheckBox cbMix;
        private Label label1;
        private CheckedListBox clbFood;
    }
}