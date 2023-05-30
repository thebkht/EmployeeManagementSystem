using System.Data;
namespace EmployeeManagementSystem
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            var employeeList = Program.userList.GetAllEmployees().Select(e => e.Username);
            InitializeComponent();
            taskAssignedEmployee.DataSource = employeeList.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string desc = taskDesc.Text;
            DateTime date = taskDueDate.Value;
            string assignedEmp = taskAssignedEmployee.SelectedItem.ToString();
            User emp = Program.userList.GetByUsername(assignedEmp);

            MessageBox.Show($"{desc} {date} {assignedEmp}");

            Tasks tsk = new(desc, date, emp.Name);

            Program.tasksList.AddTask(tsk);
            emp.AssignedTasks.Add(tsk);
            emp.UncompletedTasks++;
            AdminForm admin = new();
            admin.tasks.DataSource = Program.tasksList.GetAllTasks();
            this.Hide();
            admin.Show();
        }
    }
}
