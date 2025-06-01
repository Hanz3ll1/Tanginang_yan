namespace FinalProject
{
    partial class FitCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitCheck));
            clbWorkout = new CheckedListBox();
            label2 = new Label();
            btnNext = new Button();
            SuspendLayout();
            // 
            // clbWorkout
            // 
            clbWorkout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbWorkout.BackColor = Color.Black;
            clbWorkout.BorderStyle = BorderStyle.None;
            clbWorkout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbWorkout.ForeColor = SystemColors.ButtonHighlight;
            clbWorkout.FormattingEnabled = true;
            clbWorkout.Items.AddRange(new object[] { "Strength Training", "Cardio", "Flexibility", "Balance Exercise" });
            clbWorkout.Location = new Point(306, 154);
            clbWorkout.Name = "clbWorkout";
            clbWorkout.Size = new Size(197, 116);
            clbWorkout.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 94);
            label2.Name = "label2";
            label2.Size = new Size(627, 35);
            label2.TabIndex = 6;
            label2.Text = "CHOOSE YOUR PREFERRED WORKOUT";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(330, 309);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(148, 42);
            btnNext.TabIndex = 7;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FitCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(label2);
            Controls.Add(clbWorkout);
            DoubleBuffered = true;
            Name = "FitCheck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbWorkout;
        private Label label2;
        private Button btnNext;
    }
}