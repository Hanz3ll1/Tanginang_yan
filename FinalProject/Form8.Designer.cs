namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            clbCarnivore = new CheckedListBox();
            label2 = new Label();
            btnNext = new Button();
            SuspendLayout();
            // 
            // clbCarnivore
            // 
            clbCarnivore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbCarnivore.BackColor = Color.Black;
            clbCarnivore.BorderStyle = BorderStyle.None;
            clbCarnivore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbCarnivore.ForeColor = SystemColors.ButtonHighlight;
            clbCarnivore.FormattingEnabled = true;
            clbCarnivore.Items.AddRange(new object[] { "Hardcore Carnivore", "Standard Carnivore", "Keto-Carnivore", "Lion Diet", "Modified Carnivore" });
            clbCarnivore.Location = new Point(327, 194);
            clbCarnivore.Name = "clbCarnivore";
            clbCarnivore.Size = new Size(188, 125);
            clbCarnivore.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(218, 89);
            label2.Name = "label2";
            label2.Size = new Size(408, 80);
            label2.TabIndex = 7;
            label2.Text = "PICK YOUR PREFER\r\nCARNIVORE LIFESTYLE";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(349, 345);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(148, 42);
            btnNext.TabIndex = 8;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(label2);
            Controls.Add(clbCarnivore);
            DoubleBuffered = true;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbCarnivore;
        private Label label2;
        private Button btnNext;
    }
}