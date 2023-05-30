using System.Data;

namespace EmployeeManagementSystem
{
    public partial class AdminForm : Login
    {
        public AdminForm()
        {
            InitializeComponent();
            AssignedTo.DataSource = Program.userList.GetAllEmployees().Select(e => e.Name).ToList();
            tasks.DataSource = Program.tasksList.GetAllTasks();
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployees view = new();
            view.Show();
        }

        private void addEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee add = new();
            add.Show();

            //string empName = ShowDialog("Enter Employee Name");
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new();
            login.Show();
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEmployee remove = new();
            remove.Show();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTask addTask = new();
            addTask.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            tasks.DataSource = Program.tasksList.GetAllTasks();
        }

        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTask removeTask = new();
            this.Hide();
            removeTask.Show();
        }
    }
}
