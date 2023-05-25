namespace EmployeeManagementSystem
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            menuStrip1 = new MenuStrip();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            vIewProfileToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            update = new Button();
            tasks = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCompletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completionTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tasksBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vIewProfileToolStripMenuItem, updateProfileToolStripMenuItem });
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(53, 20);
            changePasswordToolStripMenuItem.Text = "Profile";
            // 
            // vIewProfileToolStripMenuItem
            // 
            vIewProfileToolStripMenuItem.Name = "vIewProfileToolStripMenuItem";
            vIewProfileToolStripMenuItem.Size = new Size(180, 22);
            vIewProfileToolStripMenuItem.Text = "View Profile";
            vIewProfileToolStripMenuItem.Click += vIewProfileToolStripMenuItem_Click;
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(180, 22);
            updateProfileToolStripMenuItem.Text = "Update Profile";
            updateProfileToolStripMenuItem.Click += updateProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "All Tasks";
            // 
            // update
            // 
            update.Location = new Point(683, 31);
            update.Name = "update";
            update.Size = new Size(103, 34);
            update.TabIndex = 6;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // tasks
            // 
            tasks.AllowUserToOrderColumns = true;
            tasks.AutoGenerateColumns = false;
            tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasks.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, isCompletedDataGridViewCheckBoxColumn, dueDateDataGridViewTextBoxColumn, completionTimeDataGridViewTextBoxColumn });
            tasks.DataSource = tasksBindingSource;
            tasks.Location = new Point(0, 71);
            tasks.Name = "tasks";
            tasks.Size = new Size(798, 444);
            tasks.TabIndex = 5;
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
            // completionTimeDataGridViewTextBoxColumn
            // 
            completionTimeDataGridViewTextBoxColumn.DataPropertyName = "CompletionTime";
            completionTimeDataGridViewTextBoxColumn.HeaderText = "Completion Time";
            completionTimeDataGridViewTextBoxColumn.Name = "completionTimeDataGridViewTextBoxColumn";
            completionTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tasksBindingSource
            // 
            tasksBindingSource.DataSource = typeof(Tasks);
            // 
            // EmployeeFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 483);
            Controls.Add(label1);
            Controls.Add(update);
            Controls.Add(tasks);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "EmployeeFrom";
            Text = "EmployeeFrom";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem vIewProfileToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private Label label1;
        private Button update;
        public DataGridView tasks;
        private BindingSource tasksBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completionTimeDataGridViewTextBoxColumn;
    }
}