namespace FinalProject
{
    partial class Form9
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
            cbStrengthTraining = new CheckBox();
            cbCardio = new CheckBox();
            cbFlexibility = new CheckBox();
            cbBalanceExcercise = new CheckBox();
            label1 = new Label();
            clbWorkout = new CheckedListBox();
            SuspendLayout();
            // 
            // cbStrengthTraining
            // 
            cbStrengthTraining.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbStrengthTraining.AutoSize = true;
            cbStrengthTraining.BackColor = Color.Beige;
            cbStrengthTraining.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbStrengthTraining.Location = new Point(145, 96);
            cbStrengthTraining.Name = "cbStrengthTraining";
            cbStrengthTraining.Size = new Size(174, 27);
            cbStrengthTraining.TabIndex = 0;
            cbStrengthTraining.Text = "Strength Training";
            cbStrengthTraining.UseVisualStyleBackColor = false;
            // 
            // cbCardio
            // 
            cbCardio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbCardio.AutoSize = true;
            cbCardio.BackColor = Color.Beige;
            cbCardio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCardio.Location = new Point(344, 85);
            cbCardio.Name = "cbCardio";
            cbCardio.Size = new Size(85, 27);
            cbCardio.TabIndex = 1;
            cbCardio.Text = "Cardio";
            cbCardio.UseVisualStyleBackColor = false;
            // 
            // cbFlexibility
            // 
            cbFlexibility.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbFlexibility.AutoSize = true;
            cbFlexibility.BackColor = Color.Beige;
            cbFlexibility.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFlexibility.Location = new Point(467, 96);
            cbFlexibility.Name = "cbFlexibility";
            cbFlexibility.Size = new Size(111, 27);
            cbFlexibility.TabIndex = 2;
            cbFlexibility.Text = "Flexibility";
            cbFlexibility.UseVisualStyleBackColor = false;
            // 
            // cbBalanceExcercise
            // 
            cbBalanceExcercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbBalanceExcercise.AutoSize = true;
            cbBalanceExcercise.BackColor = Color.Beige;
            cbBalanceExcercise.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbBalanceExcercise.Location = new Point(584, 85);
            cbBalanceExcercise.Name = "cbBalanceExcercise";
            cbBalanceExcercise.Size = new Size(161, 27);
            cbBalanceExcercise.TabIndex = 3;
            cbBalanceExcercise.Text = "Balance Exercise";
            cbBalanceExcercise.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 362);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 4;
            label1.Text = "Next";
            label1.Click += label1_Click;
            // 
            // clbWorkout
            // 
            clbWorkout.FormattingEnabled = true;
            clbWorkout.Items.AddRange(new object[] { "Strength Training", "Cardio", "Flexibility", "Balance Exercise" });
            clbWorkout.Location = new Point(344, 160);
            clbWorkout.Name = "clbWorkout";
            clbWorkout.Size = new Size(150, 114);
            clbWorkout.TabIndex = 5;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._13;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(clbWorkout);
            Controls.Add(label1);
            Controls.Add(cbBalanceExcercise);
            Controls.Add(cbFlexibility);
            Controls.Add(cbCardio);
            Controls.Add(cbStrengthTraining);
            DoubleBuffered = true;
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbStrengthTraining;
        private CheckBox cbCardio;
        private CheckBox cbFlexibility;
        private CheckBox cbBalanceExcercise;
        private Label label1;
        private CheckedListBox clbWorkout;
    }
}