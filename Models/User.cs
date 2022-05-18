namespace Motosalon.Models
{
    internal class User
    {
        public int id;
        public string login, password, email;

        public User() { }

        public User(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
