namespace EmployeeManagementSystem
{
    using System.Windows.Forms;
    using System.Drawing;

    internal static class Program
    {
        public static MainView mainView;
        public static TaskList tasksList;
        public static UserList userList;
        public static Login login;
        public static List<User> employees = new List<User>().Where(e => e.IsEmployee).ToList();
        public static List<User> users = new List<User>();
        public static List<Tasks> tasks = new List<Tasks>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            mainView = new();
            userList = new(users);
            tasksList = new(tasks);

            Admin admin = new Admin("admin", "admin", "Admin", 0, false);
            userList.AddUser(admin);
            User user = new User("yusupovbg", "1234", "Bakhtiyor", 10.0, true);
            userList.AddUser(user);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!Auth.isLoggedIn)
            {
                Application.Run(new Login());
            }
            else if (Auth.isUserAdmin())
            {
                Application.Run(new AdminForm());
            }
        }
    }
}