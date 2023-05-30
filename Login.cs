namespace EmployeeManagementSystem
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usr = username.Text;
            string pwd = password.Text;
            bool isValid = false;

            foreach (User i in Program.userList.GetAllUsers())
            {
                if (i.Username == usr && i.Password == pwd)
                {
                    isValid = true;
                    Auth.currentUser = i;
                    break;

                }
            }

            if (isValid)
            {
                Auth.isLoggedIn = true;
                if (usr == "admin" && pwd == "admin")
                {
                    var adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    this.Hide(); 
                    var empForm = new EmployeeForm();
                    empForm.Show();
                }
                username.Clear();
                password.Clear();


                // proceed to the next page
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Clear();
                password.Clear();
            }
        }
    }
}