using System;
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
    public partial class RemoveTask : Form
    {
        public RemoveTask()
        {
            InitializeComponent();
            tasksList.DataSource = Program.tasksList.GetAllTasks().Select(t => t.Description).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = tasksList.SelectedItem.ToString();

            foreach (Tasks t in Program.tasksList.GetAllTasks())
            {
                if (t.Description == task)
                {
                    Program.tasksList.RemoveTask(t.Id);
                    break;
                }
            }

            this.Hide();
            AdminForm admin = new();
            admin.tasks.DataSource = Program.tasksList.GetAllTasks();
            admin.Show();
        }
    }
}
