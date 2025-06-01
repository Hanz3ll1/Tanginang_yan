namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            clbAllergies = new CheckedListBox();
            label1 = new Label();
            btnNEXT = new Button();
            SuspendLayout();
            // 
            // clbAllergies
            // 
            clbAllergies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbAllergies.BackColor = Color.Black;
            clbAllergies.BorderStyle = BorderStyle.None;
            clbAllergies.CheckOnClick = true;
            clbAllergies.ColumnWidth = 200;
            clbAllergies.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clbAllergies.ForeColor = Color.White;
            clbAllergies.FormattingEnabled = true;
            clbAllergies.Items.AddRange(new object[] { "Chicken", "Egg", "Fish", "Milk", "Peanuts", "Sesame", "Shellfish", "Soy", "Treenuts", "Wheat" });
            clbAllergies.Location = new Point(226, 158);
            clbAllergies.MultiColumn = true;
            clbAllergies.Name = "clbAllergies";
            clbAllergies.Size = new Size(350, 174);
            clbAllergies.Sorted = true;
            clbAllergies.TabIndex = 14;
            clbAllergies.ThreeDCheckBoxes = true;
            clbAllergies.SelectedIndexChanged += clbAllergies_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(153, 105);
            label1.Name = "label1";
            label1.Size = new Size(497, 35);
            label1.TabIndex = 15;
            label1.Text = "DO YOU HAVE ANY ALLERGIES?";
            // 
            // btnNEXT
            // 
            btnNEXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNEXT.BackColor = Color.White;
            btnNEXT.Font = new Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNEXT.Location = new Point(327, 354);
            btnNEXT.Name = "btnNEXT";
            btnNEXT.Size = new Size(148, 42);
            btnNEXT.TabIndex = 16;
            btnNEXT.Text = "NEXT";
            btnNEXT.UseVisualStyleBackColor = false;
            btnNEXT.Click += btnNEXT_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNEXT);
            Controls.Add(label1);
            Controls.Add(clbAllergies);
            DoubleBuffered = true;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbAllergies;
        private Label label1;
        private Button btnNEXT;
    }
}