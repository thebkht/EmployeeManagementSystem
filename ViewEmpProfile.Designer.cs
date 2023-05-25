namespace EmployeeManagementSystem
{
    partial class ViewEmpProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmpProfile));
            name = new Label();
            username = new Label();
            hourlyRate = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 9);
            name.Name = "name";
            name.Size = new Size(45, 15);
            name.TabIndex = 0;
            name.Text = "Name: ";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(12, 37);
            username.Name = "username";
            username.Size = new Size(66, 15);
            username.TabIndex = 1;
            username.Text = "Username: ";
            // 
            // hourlyRate
            // 
            hourlyRate.AutoSize = true;
            hourlyRate.Location = new Point(12, 65);
            hourlyRate.Name = "hourlyRate";
            hourlyRate.Size = new Size(75, 15);
            hourlyRate.TabIndex = 2;
            hourlyRate.Text = "Hourly Rate: ";
            // 
            // button1
            // 
            button1.Location = new Point(12, 122);
            button1.Name = "button1";
            button1.Size = new Size(313, 30);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewEmpProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 164);
            Controls.Add(button1);
            Controls.Add(hourlyRate);
            Controls.Add(username);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewEmpProfile";
            Text = "ViewEmpProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label username;
        private Label hourlyRate;
        private Button button1;
    }
}