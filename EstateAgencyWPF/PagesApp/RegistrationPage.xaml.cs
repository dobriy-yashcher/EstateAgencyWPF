using EstateAgencyWPF.ADOApp;
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
using System.Xml.Linq;

namespace EstateAgencyWPF.PagesApp
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if ((tbName.Text != "") && (tbLogin.Text != "") && (tbPassword.Password != "") && (tbRepeatPassword.Password != "") && (cbRole.SelectedItem != null))
            {
                if (App.Connection.Authorization.Where(z => z.Login == tbLogin.Text).FirstOrDefault() == null)
                {
                    if (tbPassword.Password == tbRepeatPassword.Password)
                    {
                        User curentUser = new User();
                        Authorization curentAuthorization = new Authorization()
                        {
                            Login = tbLogin.Text,
                            Password = tbPassword.Password
                        };

                        curentUser.Authorization.Add(curentAuthorization);
                        curentUser.Name = tbName.Text;
                        curentUser.Role = cbRole.SelectedIndex + 1;

                        App.Connection.User.Add(curentUser);
                        App.Connection.SaveChanges();

                        NavigationService.GoBack();
                        MessageBox.Show("Успешно!");
                    }
                    else MessageBox.Show("Пароли не совпали!");
                }
                else MessageBox.Show("Такой логин уже занят!");
            }
            else MessageBox.Show("Заполните поля!");
        }
    }
}
