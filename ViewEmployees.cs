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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();

            var employeeSet = Program.userList.GetAllUsers().Where(x => x.IsEmployee == true).ToList();

            employees.DataSource = employeeSet;

        }
    }
}
