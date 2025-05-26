namespace Tanginang_yan
{
    partial class Form8
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
            cbHardCoreCarnivore = new CheckBox();
            cbStandardCarnivore = new CheckBox();
            cbKetoCarnivore = new CheckBox();
            cbLionDiet = new CheckBox();
            cbModifiedCarnivore = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbHardCoreCarnivore
            // 
            cbHardCoreCarnivore.AutoSize = true;
            cbHardCoreCarnivore.BackColor = Color.Beige;
            cbHardCoreCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbHardCoreCarnivore.Location = new Point(173, 142);
            cbHardCoreCarnivore.Name = "cbHardCoreCarnivore";
            cbHardCoreCarnivore.Size = new Size(188, 27);
            cbHardCoreCarnivore.TabIndex = 0;
            cbHardCoreCarnivore.Text = "Hardcore Carnivore";
            cbHardCoreCarnivore.UseVisualStyleBackColor = false;
            // 
            // cbStandardCarnivore
            // 
            cbStandardCarnivore.AutoSize = true;
            cbStandardCarnivore.BackColor = Color.Beige;
            cbStandardCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbStandardCarnivore.Location = new Point(173, 205);
            cbStandardCarnivore.Name = "cbStandardCarnivore";
            cbStandardCarnivore.Size = new Size(188, 27);
            cbStandardCarnivore.TabIndex = 1;
            cbStandardCarnivore.Text = "Standard Carnivore";
            cbStandardCarnivore.UseVisualStyleBackColor = false;
            // 
            // cbKetoCarnivore
            // 
            cbKetoCarnivore.AutoSize = true;
            cbKetoCarnivore.BackColor = Color.Beige;
            cbKetoCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbKetoCarnivore.Location = new Point(454, 145);
            cbKetoCarnivore.Name = "cbKetoCarnivore";
            cbKetoCarnivore.Size = new Size(153, 27);
            cbKetoCarnivore.TabIndex = 2;
            cbKetoCarnivore.Text = "Keto-Carnivore";
            cbKetoCarnivore.UseVisualStyleBackColor = false;
            // 
            // cbLionDiet
            // 
            cbLionDiet.AutoSize = true;
            cbLionDiet.BackColor = Color.Beige;
            cbLionDiet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbLionDiet.Location = new Point(454, 205);
            cbLionDiet.Name = "cbLionDiet";
            cbLionDiet.Size = new Size(105, 27);
            cbLionDiet.TabIndex = 3;
            cbLionDiet.Text = "Lion Diet";
            cbLionDiet.UseVisualStyleBackColor = false;
            // 
            // cbModifiedCarnivore
            // 
            cbModifiedCarnivore.AutoSize = true;
            cbModifiedCarnivore.BackColor = Color.Beige;
            cbModifiedCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbModifiedCarnivore.Location = new Point(307, 258);
            cbModifiedCarnivore.Name = "cbModifiedCarnivore";
            cbModifiedCarnivore.Size = new Size(188, 27);
            cbModifiedCarnivore.TabIndex = 4;
            cbModifiedCarnivore.Text = "Modified Carnivore";
            cbModifiedCarnivore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 362);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 5;
            label1.Text = "Next";
            label1.Click += label1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._12;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cbModifiedCarnivore);
            Controls.Add(cbLionDiet);
            Controls.Add(cbKetoCarnivore);
            Controls.Add(cbStandardCarnivore);
            Controls.Add(cbHardCoreCarnivore);
            DoubleBuffered = true;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbHardCoreCarnivore;
        private CheckBox cbStandardCarnivore;
        private CheckBox cbKetoCarnivore;
        private CheckBox cbLionDiet;
        private CheckBox cbModifiedCarnivore;
        private Label label1;
    }
}