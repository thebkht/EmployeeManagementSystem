namespace EmployeeManagementSystem
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
            loginPanel = new Panel();
            loginGroup = new GroupBox();
            loginBtn = new Button();
            password = new TextBox();
            passwordLabel = new Label();
            username = new TextBox();
            usernameLabel = new Label();
            loginPanel.SuspendLayout();
            loginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginGroup);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(234, 262);
            loginPanel.TabIndex = 5;
            // 
            // loginGroup
            // 
            loginGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginGroup.AutoSize = true;
            loginGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginGroup.BackgroundImageLayout = ImageLayout.Center;
            loginGroup.Controls.Add(loginBtn);
            loginGroup.Controls.Add(password);
            loginGroup.Controls.Add(passwordLabel);
            loginGroup.Controls.Add(username);
            loginGroup.Controls.Add(usernameLabel);
            loginGroup.Location = new Point(30, 27);
            loginGroup.Name = "loginGroup";
            loginGroup.Size = new Size(171, 202);
            loginGroup.TabIndex = 0;
            loginGroup.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(6, 152);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(159, 26);
            loginBtn.TabIndex = 10;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // password
            // 
            password.ImeMode = ImeMode.NoControl;
            password.Location = new Point(6, 103);
            password.Name = "password";
            password.Size = new Size(159, 25);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            password.WordWrap = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(6, 83);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(67, 19);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // username
            // 
            username.ImeMode = ImeMode.NoControl;
            username.Location = new Point(6, 41);
            username.Name = "username";
            username.Size = new Size(159, 25);
            username.TabIndex = 7;
            username.WordWrap = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(6, 20);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(71, 19);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username";
            // 
            // Login
            // 
            AccessibleRole = AccessibleRole.Window;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 262);
            Controls.Add(loginPanel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Employee Management System";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        public GroupBox loginGroup;
        private Button loginBtn;
        private TextBox password;
        private Label passwordLabel;
        private TextBox username;
        private Label usernameLabel;

        /*public void Show()
        {
            Application.Run(new Login());
        }*/
    }
}