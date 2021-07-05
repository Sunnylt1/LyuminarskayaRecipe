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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LyuminarskayaRecipe.Properties;

namespace LyuminarskayaRecipe
{
    /// <summary>
    /// Логика взаимодействия для AutorizePage.xaml
    /// </summary>
    public partial class AutorizePage : Page
    {
        public AutorizePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new RegistrationPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new Articles());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var userObj = BDClass.modelEnt.User.FirstOrDefault(
                x => x.Login == txbAccount.Text && x.Password == passBox.Password);
            if (userObj != null)
            {
                MessageBox.Show("Добро пожаловать!");
            }
            else
            {
                MessageBox.Show("Такого пользователя нет :(", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }
    }
}
