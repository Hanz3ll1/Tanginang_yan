namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            clbFood = new CheckedListBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // clbFood
            // 
            clbFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbFood.BackColor = Color.Black;
            clbFood.BorderStyle = BorderStyle.None;
            clbFood.CheckOnClick = true;
            clbFood.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbFood.ForeColor = Color.White;
            clbFood.FormattingEnabled = true;
            clbFood.Items.AddRange(new object[] { "Vegetarian", "Carnivore", "Pescatarian", "Mix" });
            clbFood.Location = new Point(347, 190);
            clbFood.Name = "clbFood";
            clbFood.Size = new Size(206, 132);
            clbFood.TabIndex = 15;
            clbFood.ThreeDCheckBoxes = true;
            clbFood.SelectedIndexChanged += clbFood_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(240, 104);
            label2.Name = "label2";
            label2.Size = new Size(371, 43);
            label2.TabIndex = 16;
            label2.Text = "PREFERRED FOOD";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(347, 349);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 17;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 54, 70);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(clbFood);
            DoubleBuffered = true;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbFood;
        private Label label2;
        private Button button1;
    }
}