using Newtonsoft.Json;
using System;
using System.IO;
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
using System.Windows.Media.Animation;

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для UIPage.xaml
    /// </summary>
    public partial class UIPage : Page
    {
        public UIPage()
        {
            InitializeComponent();
        }

        private bool isMenuOpen = false;
        private void LeaveAccount(object sender, RoutedEventArgs e)
        {
            if (File.Exists(@"C:\Logs\currentUser.json"))
            {
                var loginInfo = new { Login = "", IsLoggedIn = false };
                string loginJson = JsonConvert.SerializeObject(loginInfo);

                using (StreamWriter sw = File.CreateText(@"C:\Logs\currentUser.json"))
                {
                    sw.Write(loginJson);
                }

                NavigationService.Navigate(new AuthPage());
            }
        }

        private void OpenMenu(object sender, RoutedEventArgs e)
        {
            var showAnim = FindResource("ShowMenu") as Storyboard;
            showAnim.Begin(this);
        }
    }
}