using Motosalon.Models;
using System.Collections.Generic;
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

            Moped moped = new Moped() { Brand = "Jawa", FuelType = "diesle", Model = "175c", Color = "blue" };

            Database.MotoDataAccess.SaveMoto(moped);
            List<MotorcycleBaseClass> motorcycleBaseClasses = Database.MotoDataAccess.LoadMoto();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
