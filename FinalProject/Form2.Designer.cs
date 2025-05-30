namespace FinalProject
{
    partial class Form2
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
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            button1 = new Button();
            txtAge = new TextBox();
            lblBMI = new Label();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.Info;
            txtHeight.Location = new Point(310, 193);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(191, 27);
            txtHeight.TabIndex = 1;
            txtHeight.TextChanged += textBox1_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.Info;
            txtWeight.ForeColor = SystemColors.WindowText;
            txtWeight.Location = new Point(310, 245);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(191, 27);
            txtWeight.TabIndex = 3;
            txtWeight.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(359, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.Info;
            txtAge.Location = new Point(310, 137);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(191, 27);
            txtAge.TabIndex = 8;
            txtAge.TextChanged += textBox4_TextChanged;
            // 
            // lblBMI
            // 
            lblBMI.BackColor = SystemColors.Info;
            lblBMI.Location = new Point(310, 304);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(191, 25);
            lblBMI.TabIndex = 9;
            lblBMI.Click += lblBMI_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = Properties.Resources.Screenshot_2025_05_17_163703;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBMI);
            Controls.Add(txtAge);
            Controls.Add(button1);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button button1;
        private TextBox txtAge;
        private Label lblBMI;
    }
}