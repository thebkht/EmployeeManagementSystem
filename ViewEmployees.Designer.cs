namespace EmployeeManagementSystem
{
    partial class ViewEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployees));
            employees = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completedTasksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uncompletedTasksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)employees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // employees
            // 
            employees.AutoGenerateColumns = false;
            employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employees.Columns.AddRange(new DataGridViewColumn[] { Id, usernameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, hourlyRateDataGridViewTextBoxColumn, completedTasksDataGridViewTextBoxColumn, uncompletedTasksDataGridViewTextBoxColumn });
            employees.DataSource = userBindingSource1;
            employees.Dock = DockStyle.Fill;
            employees.Location = new Point(0, 0);
            employees.Name = "employees";
            employees.Size = new Size(833, 449);
            employees.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Width = 39;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyRate";
            hourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate";
            hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            // 
            // completedTasksDataGridViewTextBoxColumn
            // 
            completedTasksDataGridViewTextBoxColumn.DataPropertyName = "CompletedTasks";
            completedTasksDataGridViewTextBoxColumn.HeaderText = "Completed Tasks";
            completedTasksDataGridViewTextBoxColumn.Name = "completedTasksDataGridViewTextBoxColumn";
            completedTasksDataGridViewTextBoxColumn.ReadOnly = true;
            completedTasksDataGridViewTextBoxColumn.Width = 150;
            // 
            // uncompletedTasksDataGridViewTextBoxColumn
            // 
            uncompletedTasksDataGridViewTextBoxColumn.DataPropertyName = "UncompletedTasks";
            uncompletedTasksDataGridViewTextBoxColumn.HeaderText = "Uncompleted Tasks";
            uncompletedTasksDataGridViewTextBoxColumn.Name = "uncompletedTasksDataGridViewTextBoxColumn";
            uncompletedTasksDataGridViewTextBoxColumn.ReadOnly = true;
            uncompletedTasksDataGridViewTextBoxColumn.Width = 150;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(User);
            // 
            // ViewEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 449);
            Controls.Add(employees);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewEmployees";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)employees).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employees;
        private BindingSource userBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completedTasksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uncompletedTasksDataGridViewTextBoxColumn;
    }
}