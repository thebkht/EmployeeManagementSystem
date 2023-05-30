namespace EmployeeManagementSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string empPassword = PasswordGenerator.RandomPassword();
            double empSalary = Convert.ToDouble(salary.Text);
            User emp = new(empUsername.Text, empPassword, empName.Text, empSalary, true);
            Program.userList.AddUser(emp);
            MessageBox.Show($"Employee added successfully! \n Temporary Password of new Employee: {empPassword}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            empName.Clear();
            empUsername.Clear();
            salary.Clear();
        }
    }
}
