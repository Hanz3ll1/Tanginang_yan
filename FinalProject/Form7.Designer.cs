namespace FinalProject
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
            clbVegitarian = new CheckedListBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // clbVegitarian
            // 
            clbVegitarian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbVegitarian.BackColor = Color.Black;
            clbVegitarian.BorderStyle = BorderStyle.None;
            clbVegitarian.CheckOnClick = true;
            clbVegitarian.ColumnWidth = 200;
            clbVegitarian.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clbVegitarian.ForeColor = Color.White;
            clbVegitarian.FormattingEnabled = true;
            clbVegitarian.Items.AddRange(new object[] { "Flexitarian", "Lacto-ovo vegetarian", "Lacto-vegetarian", "Vegan" });
            clbVegitarian.Location = new Point(299, 200);
            clbVegitarian.MultiColumn = true;
            clbVegitarian.Name = "clbVegitarian";
            clbVegitarian.Size = new Size(206, 100);
            clbVegitarian.TabIndex = 13;
            clbVegitarian.ThreeDCheckBoxes = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(217, 83);
            label2.Name = "label2";
            label2.Size = new Size(377, 70);
            label2.TabIndex = 14;
            label2.Text = "PICK YOUR PREFER \r\nVEGATARIAN LIFESTYLE";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Felix Titling", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(328, 330);
            button1.Name = "button1";
            button1.Size = new Size(148, 42);
            button1.TabIndex = 15;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(clbVegitarian);
            DoubleBuffered = true;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbVegitarian;
        private Label label2;
        private Button button1;
    }
}