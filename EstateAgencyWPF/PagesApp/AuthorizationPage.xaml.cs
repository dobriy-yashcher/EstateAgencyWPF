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

namespace EstateAgencyWPF.PagesApp
{
    /// <summary>
    /// Interaction logic for AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            if(tbLogin.Text != "" && tbPassword.Password != "")
            {

                var data = App.Connection.Authorization.Where(z => z.Login == tbLogin.Text && z.Password == tbPassword.Password).FirstOrDefault();

                if (data != null)
                {
                    //if (App.Connection.User.Where(z => z.IdUser == data.User).FirstOrDefault().Role == 1)
                    //    NavigationService.Navigate(new AdminPage(DataLogin));

                    //else NavigationService.Navigate(new UserPage());
                    NavigationService.Navigate(new AdminPage());
                }
                else MessageBox.Show("Неправильный логин или пароль");
            }
            else MessageBox.Show("Заполните поля!");
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
