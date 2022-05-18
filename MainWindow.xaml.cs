using Motosalon.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Motosalon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxlogin.Text.Trim();
            string password = passBox.Password.Trim();
            string password2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxlogin.ToolTip = "Поле введено не коректно";
                textBoxlogin.Background = Brushes.Red;

            }
            else if (password.Length < 5)
            {
                passBox.ToolTip = "Пароль має бути не менше 6 символів!";
                passBox.Background = Brushes.Red;
            }
            else if (password != password2)
            {
                passBox2.ToolTip = "Паролі не співпадають!";
                passBox2.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@"))
            {
                textBoxEmail.ToolTip = "В адресі пропущений символ @ ";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxlogin.ToolTip = "";
                textBoxlogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                User user = new User(login, password, email);
                Database.UserDataAccess.SaveUser(user);
                //List<User> users = Database.UserDataAccess.LoadUsers();
                
                MessageBox.Show("Ви успішно зареєструвались)");

                CustomerWindows window1 = new CustomerWindows();
                window1.Show();
                this.Hide();

            }
        }

        private void Button_Window_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            this.Hide();

        }
    }
}
