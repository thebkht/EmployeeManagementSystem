namespace EmployeeManagementSystem
{
    internal class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Admin(string username, string password, string name, double rate, bool isEmployee) : base(username, password, name, rate, isEmployee)
        {
            Username = username;
            Password = password;
            IsAdmin = true;
        }
    }
}
