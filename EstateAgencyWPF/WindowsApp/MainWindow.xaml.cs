using EstateAgencyWPF.PagesApp;
using System.Windows;

namespace EstateAgencyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
