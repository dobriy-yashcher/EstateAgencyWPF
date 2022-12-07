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

namespace EstateAgencyWPF.PagesApp
{
    /// <summary>
    /// Interaction logic for RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        private Request _currentRequest = new Request();

        public RequestPage()
        {
            InitializeComponent();
            DataContext = _currentRequest;
            cbFlatType.ItemsSource = App.Connection.FlatType.ToList();
        }

        private void BtnSendRequest_Clic(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();
            
            //if (cbFlatType.SelectedItem == null)
            //    errors.Append("Выберите тип объявления");
            if (string.IsNullOrWhiteSpace(_currentRequest.City) || string.IsNullOrWhiteSpace(_currentRequest.Region) ||
                string.IsNullOrWhiteSpace(_currentRequest.Address) || string.IsNullOrWhiteSpace(_currentRequest.Space) ||
                string.IsNullOrWhiteSpace(_currentRequest.Name) || string.IsNullOrWhiteSpace(_currentRequest.Phone) ||
                string.IsNullOrWhiteSpace(_currentRequest.Email))
                errors.Append("Заполните поля");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentRequest.IdRequest == 0)
                ++_currentRequest.FlatType;
                App.Connection.Request.Add(_currentRequest);

            try
            {
                App.Connection.SaveChanges();

                MessageBox.Show("Информация сохранена!");

                _currentRequest = new Request();
                DataContext = _currentRequest;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
