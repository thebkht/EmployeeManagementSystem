namespace EmployeeManagementSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            adminPanel = new Panel();
            update = new Button();
            tasks = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCompletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AssignedTo = new DataGridViewComboBoxColumn();
            userBindingSource = new BindingSource(components);
            tasksBindingSource = new BindingSource(components);
            adminMenu = new MenuStrip();
            addEmployeeMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem1 = new ToolStripMenuItem();
            removeEmployeeToolStripMenuItem = new ToolStripMenuItem();
            viewEmployeesToolStripMenuItem = new ToolStripMenuItem();
            manageTasksMenuItem = new ToolStripMenuItem();
            addTaskToolStripMenuItem = new ToolStripMenuItem();
            removeTaskToolStripMenuItem = new ToolStripMenuItem();
            logoutMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).BeginInit();
            adminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // loginGroup
            // 
            loginGroup.Location = new Point(330, 176);
            loginGroup.Visible = false;
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(label1);
            adminPanel.Controls.Add(update);
            adminPanel.Controls.Add(tasks);
            adminPanel.Controls.Add(adminMenu);
            adminPanel.Dock = DockStyle.Fill;
            adminPanel.Location = new Point(0, 0);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(798, 510);
            adminPanel.TabIndex = 0;
            // 
            // update
            // 
            update.Location = new Point(692, 26);
            update.Name = "update";
            update.Size = new Size(103, 34);
            update.TabIndex = 3;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // tasks
            // 
            tasks.AllowUserToOrderColumns = true;
            tasks.AutoGenerateColumns = false;
            tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasks.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, isCompletedDataGridViewCheckBoxColumn, dueDateDataGridViewTextBoxColumn, AssignedTo });
            tasks.DataSource = tasksBindingSource;
            tasks.Location = new Point(0, 66);
            tasks.Name = "tasks";
            tasks.Size = new Size(798, 444);
            tasks.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "#";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 30;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 310;
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "isCompleted";
            isCompletedDataGridViewCheckBoxColumn.HeaderText = "Status";
            isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            isCompletedDataGridViewCheckBoxColumn.Width = 115;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // AssignedTo
            // 
            AssignedTo.DataPropertyName = "AssignedTo";
            AssignedTo.DataSource = userBindingSource;
            AssignedTo.HeaderText = "Assigned To";
            AssignedTo.Name = "AssignedTo";
            AssignedTo.Width = 150;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // tasksBindingSource
            // 
            tasksBindingSource.DataSource = typeof(Tasks);
            // 
            // adminMenu
            // 
            adminMenu.Items.AddRange(new ToolStripItem[] { addEmployeeMenuItem, manageTasksMenuItem, logoutMenuItem });
            adminMenu.Location = new Point(0, 0);
            adminMenu.Name = "adminMenu";
            adminMenu.RenderMode = ToolStripRenderMode.Professional;
            adminMenu.Size = new Size(798, 24);
            adminMenu.TabIndex = 1;
            adminMenu.Text = "menuStrip";
            // 
            // addEmployeeMenuItem
            // 
            addEmployeeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem1, removeEmployeeToolStripMenuItem, viewEmployeesToolStripMenuItem });
            addEmployeeMenuItem.Name = "addEmployeeMenuItem";
            addEmployeeMenuItem.Size = new Size(117, 20);
            addEmployeeMenuItem.Text = "Manage Employee";
            // 
            // addEmployeeToolStripMenuItem1
            // 
            addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            addEmployeeToolStripMenuItem1.Size = new Size(172, 22);
            addEmployeeToolStripMenuItem1.Text = "Add Employee";
            addEmployeeToolStripMenuItem1.Click += addEmployeeToolStripMenuItem1_Click;
            // 
            // removeEmployeeToolStripMenuItem
            // 
            removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            removeEmployeeToolStripMenuItem.Size = new Size(172, 22);
            removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            removeEmployeeToolStripMenuItem.Click += removeEmployeeToolStripMenuItem_Click;
            // 
            // viewEmployeesToolStripMenuItem
            // 
            viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            viewEmployeesToolStripMenuItem.Size = new Size(172, 22);
            viewEmployeesToolStripMenuItem.Text = "View Employees";
            viewEmployeesToolStripMenuItem.Click += viewEmployeesToolStripMenuItem_Click;
            // 
            // manageTasksMenuItem
            // 
            manageTasksMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTaskToolStripMenuItem, removeTaskToolStripMenuItem });
            manageTasksMenuItem.Name = "manageTasksMenuItem";
            manageTasksMenuItem.Size = new Size(92, 20);
            manageTasksMenuItem.Text = "Manage Tasks";
            // 
            // addTaskToolStripMenuItem
            // 
            addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            addTaskToolStripMenuItem.Size = new Size(180, 22);
            addTaskToolStripMenuItem.Text = "Add Task";
            addTaskToolStripMenuItem.Click += addTaskToolStripMenuItem_Click;
            // 
            // removeTaskToolStripMenuItem
            // 
            removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            removeTaskToolStripMenuItem.Size = new Size(180, 22);
            removeTaskToolStripMenuItem.Text = "Remove Task";
            removeTaskToolStripMenuItem.Click += removeTaskToolStripMenuItem_Click;
            // 
            // logoutMenuItem
            // 
            logoutMenuItem.Name = "logoutMenuItem";
            logoutMenuItem.Size = new Size(57, 20);
            logoutMenuItem.Text = "Logout";
            logoutMenuItem.Click += logoutMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 4;
            label1.Text = "All Tasks";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 510);
            Controls.Add(adminPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "AdminForm";
            Controls.SetChildIndex(adminPanel, 0);
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).EndInit();
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel adminPanel;
        private MenuStrip adminMenu;
        private ToolStripMenuItem addEmployeeMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem1;
        private ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private ToolStripMenuItem manageTasksMenuItem;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem removeTaskToolStripMenuItem;
        private ToolStripMenuItem logoutMenuItem;
        public DataGridView tasks;
        private BindingSource tasksBindingSource;
        private Button update;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn AssignedTo;
        private Label label1;
    }
}