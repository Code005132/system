namespace Membership
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginButon = new Button();
            Username = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // LoginButon
            // 
            LoginButon.Cursor = Cursors.Hand;
            LoginButon.FlatAppearance.BorderColor = Color.Black;
            LoginButon.FlatAppearance.BorderSize = 2;
            LoginButon.FlatStyle = FlatStyle.Popup;
            LoginButon.Location = new Point(563, 631);
            LoginButon.Name = "LoginButon";
            LoginButon.Size = new Size(177, 49);
            LoginButon.TabIndex = 0;
            LoginButon.Text = "Login";
            LoginButon.UseVisualStyleBackColor = true;
            LoginButon.Click += button1_Click;
            // 
            // Username
            // 
            Username.BackColor = Color.White;
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(512, 391);
            Username.Name = "Username";
            Username.Size = new Size(379, 64);
            Username.TabIndex = 1;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(512, 505);
            Password.Name = "Password";
            Password.Size = new Size(379, 64);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 800);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LoginButon);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButon;
        private TextBox Username;
        private TextBox Password;
    }
}