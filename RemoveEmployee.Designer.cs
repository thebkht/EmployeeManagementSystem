namespace EmployeeManagementSystem
{
    partial class RemoveEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveEmployee));
            empList = new ListBox();
            userBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // empList
            // 
            empList.DataSource = userBindingSource;
            empList.FormattingEnabled = true;
            empList.ItemHeight = 15;
            empList.Location = new Point(12, 12);
            empList.Name = "empList";
            empList.Size = new Size(275, 379);
            empList.TabIndex = 4;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // button1
            // 
            button1.Location = new Point(12, 404);
            button1.Name = "button1";
            button1.Size = new Size(275, 34);
            button1.TabIndex = 3;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RemoveEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(empList);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RemoveEmployee";
            Text = "RemoveEmployee";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox empList;
        private BindingSource userBindingSource;
        private Button button1;
    }
}