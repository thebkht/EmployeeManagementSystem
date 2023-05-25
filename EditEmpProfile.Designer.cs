namespace EmployeeManagementSystem
{
    partial class EditEmpProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmpProfile));
            button1 = new Button();
            username = new Label();
            name = new Label();
            tbName = new TextBox();
            tbUsername = new TextBox();
            oldPassword = new TextBox();
            label1 = new Label();
            newPassword = new TextBox();
            label2 = new Label();
            comfirmPassword = new TextBox();
            label3 = new Label();
            apply = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 204);
            button1.Name = "button1";
            button1.Size = new Size(148, 30);
            button1.TabIndex = 7;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(12, 43);
            username.Name = "username";
            username.Size = new Size(66, 15);
            username.TabIndex = 5;
            username.Text = "Username: ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(45, 15);
            name.TabIndex = 4;
            name.Text = "Name: ";
            // 
            // tbName
            // 
            tbName.Location = new Point(126, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(199, 23);
            tbName.TabIndex = 8;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(126, 40);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(199, 23);
            tbUsername.TabIndex = 9;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // oldPassword
            // 
            oldPassword.Location = new Point(126, 89);
            oldPassword.Name = "oldPassword";
            oldPassword.Size = new Size(199, 23);
            oldPassword.TabIndex = 11;
            oldPassword.UseSystemPasswordChar = true;
            oldPassword.TextChanged += oldPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 10;
            label1.Text = "Old Password: ";
            // 
            // newPassword
            // 
            newPassword.Location = new Point(126, 122);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(199, 23);
            newPassword.TabIndex = 13;
            newPassword.UseSystemPasswordChar = true;
            newPassword.TextChanged += newPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 12;
            label2.Text = "New Password: ";
            // 
            // comfirmPassword
            // 
            comfirmPassword.Location = new Point(126, 156);
            comfirmPassword.Name = "comfirmPassword";
            comfirmPassword.Size = new Size(199, 23);
            comfirmPassword.TabIndex = 15;
            comfirmPassword.UseSystemPasswordChar = true;
            comfirmPassword.TextChanged += comfirmPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 14;
            label3.Text = "Comfirm Password: ";
            // 
            // apply
            // 
            apply.Enabled = false;
            apply.Location = new Point(177, 204);
            apply.Name = "apply";
            apply.Size = new Size(148, 30);
            apply.TabIndex = 16;
            apply.Text = "Apply";
            apply.UseVisualStyleBackColor = true;
            apply.Click += apply_Click;
            // 
            // EditEmpProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 246);
            Controls.Add(apply);
            Controls.Add(comfirmPassword);
            Controls.Add(label3);
            Controls.Add(newPassword);
            Controls.Add(label2);
            Controls.Add(oldPassword);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Controls.Add(tbName);
            Controls.Add(button1);
            Controls.Add(username);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditEmpProfile";
            Text = "EditEmpProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label username;
        private Label name;
        private TextBox tbName;
        private TextBox tbUsername;
        private TextBox oldPassword;
        private Label label1;
        private TextBox newPassword;
        private Label label2;
        private TextBox comfirmPassword;
        private Label label3;
        private Button apply;
    }
}