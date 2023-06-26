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

namespace PodCastLive.Pages
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Page
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        public AdminLogin(string value)
        {
            InitializeComponent();
            dataBinding(value);
        }
         public void dataBinding(string idValue)
        {
            if(idValue != null)
            {
                switch(idValue)
                {
                    case "AdminLogin":
                        this.UserID.Text = "40*******";
                        break;
                    case "UserLogin":
                        this.UserID.Text = "14503*********";
                        break;
                    case "AgentLogin":
                        this.UserID.Text = "00000000";
                        break;
                    default:
                        break;
                }
            }
        }

        private void UserID_GotFocus(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
