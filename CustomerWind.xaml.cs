using System.Windows;
using System.Windows.Controls;

namespace Motosalon
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class CustomerWindows : Window
    {
        public CustomerWindows()
        {
            InitializeComponent();
        }

        private void Mark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Замовити_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ви успішно замовили мотоцикл");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
