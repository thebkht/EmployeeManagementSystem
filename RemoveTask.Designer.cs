namespace EmployeeManagementSystem
{
    partial class RemoveTask
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
            tasksBindingSource = new BindingSource(components);
            button1 = new Button();
            tasksList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tasksBindingSource
            // 
            tasksBindingSource.DataSource = typeof(Tasks);
            // 
            // button1
            // 
            button1.Location = new Point(12, 404);
            button1.Name = "button1";
            button1.Size = new Size(275, 34);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tasksList
            // 
            tasksList.DataSource = tasksBindingSource;
            tasksList.FormattingEnabled = true;
            tasksList.ItemHeight = 15;
            tasksList.Location = new Point(12, 12);
            tasksList.Name = "tasksList";
            tasksList.Size = new Size(275, 379);
            tasksList.TabIndex = 2;
            // 
            // RemoveTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(tasksList);
            Controls.Add(button1);
            Name = "RemoveTask";
            Text = "RemoveTask";
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource tasksBindingSource;
        private Button button1;
        private ListBox tasksList;
    }
}