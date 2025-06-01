namespace FinalProject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            clbIllness = new CheckedListBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // clbIllness
            // 
            clbIllness.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbIllness.BackColor = Color.Black;
            clbIllness.BorderStyle = BorderStyle.None;
            clbIllness.CheckOnClick = true;
            clbIllness.ColumnWidth = 250;
            clbIllness.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbIllness.ForeColor = SystemColors.ButtonHighlight;
            clbIllness.FormattingEnabled = true;
            clbIllness.Items.AddRange(new object[] { "Heart Condition", "Previous injuries", "Diabetes", "Hypertension", "Joint problems", "Chronic Fatigue Syndrome", "Post Surgery Recovery", "Lung Condition", "Gout", "Scoliosis" });
            clbIllness.Location = new Point(152, 192);
            clbIllness.Margin = new Padding(4);
            clbIllness.MultiColumn = true;
            clbIllness.Name = "clbIllness";
            clbIllness.Size = new Size(493, 150);
            clbIllness.TabIndex = 13;
            clbIllness.SelectedIndexChanged += clbIllness_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(129, 115);
            label2.Name = "label2";
            label2.Size = new Size(533, 35);
            label2.TabIndex = 14;
            label2.Text = "PLEASE PICK FROM THIS CHOICES";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(323, 362);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 15;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(clbIllness);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbIllness;
        private Label label2;
        private Button button1;
    }
}