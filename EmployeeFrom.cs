﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class EmployeeFrom : Form
    {
        User currentEmployee = Auth.currentUser;

        public EmployeeFrom()
        {
            InitializeComponent();
        }

        private void EmployeeFrom_Load(object sender, EventArgs e)
        {

            tasks.DataSource = Program.tasksList.GetAllTasks().Where(t => t.AssignedTo == currentEmployee.Name).ToList();

            label1.Text = $"{Program.mainView.Greet()}, {currentEmployee.Name} You have {currentEmployee.CompletedTasks}/{currentEmployee.UncompletedTasks}";
        }

        private void update_Click(object sender, EventArgs e)
        {
            tasks.DataSource = Program.tasksList.GetAllTasks().Where(t => t.AssignedTo == currentEmployee.Name).ToList();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new();
            login.Show();
        }

        private void vIewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmpProfile view = new();
            view.Show();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmpProfile edit = new();
            edit.Show();
        }
    }
}
