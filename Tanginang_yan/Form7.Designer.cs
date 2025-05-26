namespace Tanginang_yan
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            cbFexitarian = new CheckBox();
            cbLactoOvoVegetarian = new CheckBox();
            cbLactoVegetarian = new CheckBox();
            cbOvoVegetarian = new CheckBox();
            cbVegan = new CheckBox();
            cbRawVegan = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbFexitarian
            // 
            cbFexitarian.AutoSize = true;
            cbFexitarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFexitarian.Location = new Point(184, 144);
            cbFexitarian.Name = "cbFexitarian";
            cbFexitarian.Size = new Size(111, 27);
            cbFexitarian.TabIndex = 6;
            cbFexitarian.Text = "Fexitarian";
            cbFexitarian.UseVisualStyleBackColor = true;
            // 
            // cbLactoOvoVegetarian
            // 
            cbLactoOvoVegetarian.AutoSize = true;
            cbLactoOvoVegetarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbLactoOvoVegetarian.Location = new Point(184, 197);
            cbLactoOvoVegetarian.Name = "cbLactoOvoVegetarian";
            cbLactoOvoVegetarian.Size = new Size(201, 27);
            cbLactoOvoVegetarian.TabIndex = 7;
            cbLactoOvoVegetarian.Text = "Lacto-ovo vegetarian";
            cbLactoOvoVegetarian.UseVisualStyleBackColor = true;
            // 
            // cbLactoVegetarian
            // 
            cbLactoVegetarian.AutoSize = true;
            cbLactoVegetarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbLactoVegetarian.Location = new Point(184, 251);
            cbLactoVegetarian.Name = "cbLactoVegetarian";
            cbLactoVegetarian.Size = new Size(167, 27);
            cbLactoVegetarian.TabIndex = 8;
            cbLactoVegetarian.Text = "Lacto-vegetarian";
            cbLactoVegetarian.UseVisualStyleBackColor = true;
            // 
            // cbOvoVegetarian
            // 
            cbOvoVegetarian.AutoSize = true;
            cbOvoVegetarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbOvoVegetarian.Location = new Point(449, 144);
            cbOvoVegetarian.Name = "cbOvoVegetarian";
            cbOvoVegetarian.Size = new Size(156, 27);
            cbOvoVegetarian.TabIndex = 9;
            cbOvoVegetarian.Text = "Ovo-vegetarian";
            cbOvoVegetarian.UseVisualStyleBackColor = true;
            // 
            // cbVegan
            // 
            cbVegan.AutoSize = true;
            cbVegan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbVegan.Location = new Point(449, 197);
            cbVegan.Name = "cbVegan";
            cbVegan.Size = new Size(81, 27);
            cbVegan.TabIndex = 10;
            cbVegan.Text = "Vegan";
            cbVegan.UseVisualStyleBackColor = true;
            // 
            // cbRawVegan
            // 
            cbRawVegan.AutoSize = true;
            cbRawVegan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbRawVegan.Location = new Point(449, 251);
            cbRawVegan.Name = "cbRawVegan";
            cbRawVegan.Size = new Size(122, 27);
            cbRawVegan.TabIndex = 11;
            cbRawVegan.Text = "Raw-Vegan";
            cbRawVegan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 362);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 12;
            label1.Text = "Next";
            label1.Click += label1_Click_1;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cbRawVegan);
            Controls.Add(cbVegan);
            Controls.Add(cbOvoVegetarian);
            Controls.Add(cbLactoVegetarian);
            Controls.Add(cbLactoOvoVegetarian);
            Controls.Add(cbFexitarian);
            DoubleBuffered = true;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbFexitarian;
        private CheckBox cbLactoOvoVegetarian;
        private CheckBox cbLactoVegetarian;
        private CheckBox cbOvoVegetarian;
        private CheckBox cbVegan;
        private CheckBox cbRawVegan;
        private Label label1;
    }
}