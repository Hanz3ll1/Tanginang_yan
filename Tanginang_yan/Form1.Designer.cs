namespace Tanginang_yan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            lblLogIn = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Info;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(434, 149);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 20);
            txtUserName.TabIndex = 2;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = SystemColors.Info;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassWord.Location = new Point(434, 226);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(210, 20);
            txtPassWord.TabIndex = 4;
            txtPassWord.UseSystemPasswordChar = true;
            txtPassWord.TextChanged += textBox2_TextChanged;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogIn.Location = new Point(497, 322);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(55, 23);
            lblLogIn.TabIndex = 11;
            lblLogIn.Text = "Login";
            lblLogIn.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImage = Properties.Resources.clicks;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(782, 437);
            Controls.Add(lblLogIn);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Label lblLogIn;
    }
}
