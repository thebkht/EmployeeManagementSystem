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
    public partial class ViewEmpProfile : Form
    {
        public ViewEmpProfile()
        {
            InitializeComponent();
            User emp = Auth.currentUser;
            name.Text = $"Name: {emp.Name}";
            username.Text = $"Username: {emp.Username}";
            hourlyRate.Text = $"Hourly Rate: {emp.HourlyRate}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
