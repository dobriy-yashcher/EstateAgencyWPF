using EstateAgencyWPF.PagesApp;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EstateAgencyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button SelectedButton;

        public MainWindow()
        {
            InitializeComponent();
            SelectedButton = StartPosition;
            MainFrame.NavigationService.Navigate(new BuyFlatPage());
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Max_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void Mini_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            EditSelectedButton(sender);
            MainFrame.NavigationService.Navigate(new AuthorizationPage());
        }

        private void BuyFlatPage_Clic(object sender, RoutedEventArgs e)
        {
            EditSelectedButton(sender);
            MainFrame.NavigationService.Navigate(new BuyFlatPage());
        }

        private void RentFlatPage_Clic(object sender, RoutedEventArgs e)
        {
            EditSelectedButton(sender);
            MainFrame.NavigationService.Navigate(new RentFlatPage());
        }

        private void RequestPage_Clic(object sender, RoutedEventArgs e)
        {
            EditSelectedButton(sender);
            MainFrame.NavigationService.Navigate(new RequestPage());
        }

        private void EditSelectedButton(object sender)
        {
            SelectedButton.Style = (Style)Application.Current.Resources["menuButton"];
            SelectedButton = sender as Button;
            SelectedButton.Style = (Style)Application.Current.Resources["menuButton2"];
        }
    }
}
