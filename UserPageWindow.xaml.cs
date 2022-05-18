using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Motosalon
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            string brand = textBoxBrand.Text.Trim();
            string model =textBoxModel.Text.Trim();
            string color = textBoxColor.Text.Trim();
            string fuel = textBoxFuel.Text.Trim();
            string power = textBoxPower.Text.Trim();

            if(brand.Length <2)
            {
                textBoxBrand.ToolTip = "Incorrect!";
                textBoxBrand.Background = Brushes.Red;
            }
            else
            {
                textBoxBrand.ToolTip = "";
                textBoxBrand.Background = Brushes.Transparent;
                textBoxModel.ToolTip = "";
                textBoxModel.Background = Brushes.Transparent;
                textBoxColor.ToolTip = "";
                textBoxColor.Background = Brushes.Transparent;
                textBoxFuel.ToolTip = "";
                textBoxFuel.Background = Brushes.Transparent;
                textBoxPower.ToolTip = "";
                textBoxPower.Background = Brushes.Transparent;

                MessageBox.Show("Дані додано успішно)");
            }
          
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
