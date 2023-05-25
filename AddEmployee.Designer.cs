namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            nameLabel = new Label();
            empName = new TextBox();
            empUsername = new TextBox();
            usernameLabel = new Label();
            salary = new TextBox();
            hourlyRate = new Label();
            addBtn = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // empName
            // 
            empName.Location = new Point(88, 16);
            empName.Name = "empName";
            empName.Size = new Size(174, 23);
            empName.TabIndex = 1;
            // 
            // empUsername
            // 
            empUsername.Location = new Point(88, 54);
            empUsername.Name = "empUsername";
            empUsername.Size = new Size(174, 23);
            empUsername.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 54);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // salary
            // 
            salary.Location = new Point(88, 96);
            salary.Name = "salary";
            salary.Size = new Size(174, 23);
            salary.TabIndex = 5;
            // 
            // hourlyRate
            // 
            hourlyRate.AutoSize = true;
            hourlyRate.Location = new Point(12, 96);
            hourlyRate.Name = "hourlyRate";
            hourlyRate.Size = new Size(38, 15);
            hourlyRate.TabIndex = 4;
            hourlyRate.Text = "Salary";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 137);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 28);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add Employee";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // AddEmployee
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 179);
            Controls.Add(addBtn);
            Controls.Add(salary);
            Controls.Add(hourlyRate);
            Controls.Add(empUsername);
            Controls.Add(usernameLabel);
            Controls.Add(empName);
            Controls.Add(nameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox empName;
        private TextBox empUsername;
        private Label usernameLabel;
        private TextBox salary;
        private Label hourlyRate;
        private Button addBtn;
    }
}