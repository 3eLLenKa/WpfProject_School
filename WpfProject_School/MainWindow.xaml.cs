using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfProject_School;
using WpfProject_School.MVVM.View;
using WpfProject_School.Levels.RussianLevels.LettersLevels;

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow window;

        private static FirstLettersLevelPage lettersPage = new FirstLettersLevelPage();

        public MainWindow()
        {
            window = this;

            try
            {
                InitializeComponent();
                MainFrame.Content = new AuthPage();
                LoadLoginInfo();
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void MovingWindow(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainWindow.window.DragMove();
            }
        }

        private void LoadLoginInfo()
        {
            if (File.Exists(@"C:\Logs\currentUser.json"))
            {
                string loginJson = File.ReadAllText(@"C:\Logs\currentUser.json");
                dynamic loginInfo = JsonConvert.DeserializeObject(loginJson);

                if ((bool)loginInfo.IsLoggedIn)
                {
                    MainFrame.Content = new UIPage();
                }
                //else throw new Exception("Error Ocured: Account is not autorized.");
            }
        }

        private void CloseClient(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizeClient(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else WindowState = WindowState.Maximized;
        }
        private void MinimizeClient(object sender, EventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}