using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
            empList.DataSource = Program.userList.GetAllEmployees().Select(e => e.Username).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emp = empList.SelectedItem.ToString();
            foreach (User u in Program.userList.GetAllEmployees())
            {
                if (u.Username == emp)
                {
                    Program.userList.RemoveUser(u.Id);
                    break;
                }
            }
            this.Hide();
        }
    }
}
