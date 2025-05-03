namespace Tanginang_yan
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
            label1 = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            lblBMI = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 152);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Height:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(280, 149);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 1;
            txtHeight.TextChanged += textBox1_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(280, 200);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 3;
            txtWeight.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 203);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Weight:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 258);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "BMI:";
            // 
            // button1
            // 
            button1.Location = new Point(352, 314);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 102);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Age: ";
            // 
            // lblBMI
            // 
            lblBMI.BackColor = SystemColors.AppWorkspace;
            lblBMI.Location = new Point(297, 258);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(108, 25);
            lblBMI.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBMI);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtWeight);
            Controls.Add(label2);
            Controls.Add(txtHeight);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private Label lblBMI;
    }
}