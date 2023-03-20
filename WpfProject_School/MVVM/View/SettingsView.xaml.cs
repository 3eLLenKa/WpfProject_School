using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfProject_School.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
        }

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

                var mainFrame = (Window.GetWindow(this)?.FindName("MainFrame") as Frame);
                mainFrame?.Navigate(new AuthPage());
            }
        }
    }
}