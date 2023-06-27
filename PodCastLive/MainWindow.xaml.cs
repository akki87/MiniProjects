using PodCastLive.Windows;
using System.Windows;

namespace PodCastLive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            Login adminLogin = new Login("AdminLogin");
            adminLogin.Show();
        }

        private void UserLogin_Click(object sender, RoutedEventArgs e)
        {
            Login adminLogin = new Login("UserLogin");
            adminLogin.Show();
        }

        private void AgentLogin_Click(object sender, RoutedEventArgs e)
        {
            Login adminLogin = new Login("AgentLogin");
            adminLogin.Show();
        }
    }
}
