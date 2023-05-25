namespace EmployeeManagementSystem
{
    partial class AddTask
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            addBtn = new Button();
            assign = new Label();
            usernameLabel = new Label();
            taskDesc = new TextBox();
            nameLabel = new Label();
            taskDueDate = new DateTimePicker();
            taskAssignedEmployee = new ComboBox();
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(18, 168);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(379, 28);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add Task";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // assign
            // 
            assign.AutoSize = true;
            assign.Location = new Point(18, 127);
            assign.Name = "assign";
            assign.Size = new Size(97, 15);
            assign.TabIndex = 11;
            assign.Text = "Assign Employee";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(18, 85);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(55, 15);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Due Date";
            // 
            // taskDesc
            // 
            taskDesc.Location = new Point(125, 15);
            taskDesc.Multiline = true;
            taskDesc.Name = "taskDesc";
            taskDesc.Size = new Size(272, 51);
            taskDesc.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(18, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Description";
            // 
            // taskDueDate
            // 
            taskDueDate.Format = DateTimePickerFormat.Custom;
            taskDueDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            taskDueDate.Location = new Point(124, 79);
            taskDueDate.Name = "taskDueDate";
            taskDueDate.Size = new Size(273, 23);
            taskDueDate.TabIndex = 14;
            taskDueDate.Value = new DateTime(2023, 5, 25, 23, 59, 59, 0);
            // 
            // taskAssignedEmployee
            // 
            taskAssignedEmployee.DataSource = userBindingSource;
            taskAssignedEmployee.FormattingEnabled = true;
            taskAssignedEmployee.Location = new Point(125, 124);
            taskAssignedEmployee.Name = "taskAssignedEmployee";
            taskAssignedEmployee.Size = new Size(272, 23);
            taskAssignedEmployee.TabIndex = 15;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 215);
            Controls.Add(taskAssignedEmployee);
            Controls.Add(taskDueDate);
            Controls.Add(addBtn);
            Controls.Add(assign);
            Controls.Add(usernameLabel);
            Controls.Add(taskDesc);
            Controls.Add(nameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTask";
            Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox salary;
        private Label assign;
        private TextBox empUsername;
        private Label usernameLabel;
        private TextBox taskDesc;
        private Label nameLabel;
        private DateTimePicker taskDueDate;
        private ComboBox taskAssignedEmployee;
        private BindingSource userBindingSource;
    }
}