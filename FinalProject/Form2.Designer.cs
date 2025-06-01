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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            button1 = new Button();
            txtAge = new TextBox();
            lblBMI = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeight.BackColor = Color.White;
            txtHeight.Location = new Point(310, 193);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(191, 27);
            txtHeight.TabIndex = 1;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            txtHeight.TextChanged += textBox1_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtWeight.BackColor = Color.Black;
            txtWeight.ForeColor = Color.White;
            txtWeight.Location = new Point(310, 245);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(191, 27);
            txtWeight.TabIndex = 3;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            txtWeight.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 354);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.BackColor = Color.White;
            txtAge.Location = new Point(310, 137);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(191, 27);
            txtAge.TabIndex = 8;
            txtAge.TextAlign = HorizontalAlignment.Center;
            txtAge.TextChanged += textBox4_TextChanged;
            // 
            // lblBMI
            // 
            lblBMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBMI.BackColor = Color.Black;
            lblBMI.BorderStyle = BorderStyle.Fixed3D;
            lblBMI.FlatStyle = FlatStyle.Popup;
            lblBMI.ForeColor = Color.White;
            lblBMI.Location = new Point(310, 304);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(191, 25);
            lblBMI.TabIndex = 9;
            lblBMI.TextAlign = ContentAlignment.TopCenter;
            lblBMI.Click += lblBMI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Felix Titling", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(218, 55);
            label1.Name = "label1";
            label1.Size = new Size(383, 43);
            label1.TabIndex = 10;
            label1.Text = "Self-Measurement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(259, 140);
            label2.Name = "label2";
            label2.Size = new Size(40, 18);
            label2.TabIndex = 11;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Felix Titling", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(195, 198);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 12;
            label3.Text = "Height (M)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Felix Titling", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(181, 245);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 13;
            label4.Text = "Weight (Kg.)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Felix Titling", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(259, 304);
            label5.Name = "label5";
            label5.Size = new Size(37, 18);
            label5.TabIndex = 14;
            label5.Text = "BMI";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}