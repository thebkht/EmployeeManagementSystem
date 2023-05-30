namespace EmployeeManagementSystem
{
    public partial class EditEmpProfile : Form
    {
        User emp = Auth.currentUser;

        public EditEmpProfile()
        {
            InitializeComponent();
            tbName.Text = emp.Name;
            tbUsername.Text = emp.Username;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string username = tbUsername.Text;
            string password = emp.Password;
            if (oldPassword.Text != null || newPassword.Text != null || comfirmPassword.Text != null)
            {
                if (oldPassword.Text != emp.Password)
                {
                    MessageBox.Show("Old password is incorrect");
                }
                else if (newPassword.Text != emp.Password)
                {
                    MessageBox.Show("New password does not match with old password");
                }
                else if (comfirmPassword.Text != newPassword.Text)
                {
                    MessageBox.Show("New password does not match");
                }
                else
                {
                    password = newPassword.Text;
                }
            }

            foreach (User u in Program.userList.GetAllEmployees())
            {
                if (u == Auth.currentUser)
                {
                    u.Name = name;
                    u.Username = username;
                    u.Password = password;
                    MessageBox.Show("Profile updated");
                    break;
                }
            }
            apply.Enabled = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = true;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = true;
        }

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = true;
        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = true;
        }

        private void comfirmPassword_TextChanged(object sender, EventArgs e)
        {
            apply.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
