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
using WpfProject_School.Levels.EnglishLevels.LettersLevels;
using WpfProject_School.Levels.EnglishLevels.NumbersAndSymbolsLevels;
using WpfProject_School.Levels.EnglishLevels.PunctuationMarksLevels;
using WpfProject_School.Levels.EnglishLevels.WordsLevels;

namespace WpfProject_School.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для EnglishLevelsView.xaml
    /// </summary>
    public partial class EnglishLevelsView : UserControl
    {
        public EnglishLevelsView()
        {
            InitializeComponent();
        }

        private void WindowSettings()
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;

            mainWindow.WindowState = WindowState.Maximized;
            mainWindow.MinimizeButton.Visibility = Visibility.Hidden;
            mainWindow.MaximizeButton.Visibility = Visibility.Hidden;
        }

        private void FirstLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstLettersPage());
        }

        private void SecondLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondLettersPage());
        }

        private void ThirdLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdLettersPage());
        }

        private void FourthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthLettersPage());
        }

        private void FifthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FifthLettersPage());
        }

        private void SixthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SixthLettersPage());
        }

        private void SeventhLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SeventhLettersPage());
        }

        private void EighthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new EighthLettersPage());
        }


        //Event Args word levels buttons


        private void FirstWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstWordsPage());
        }

        private void SecondWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondWordsPage());
        }

        private void ThirdWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdWordsPage());
        }

        private void FourthWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthWordsPage());
        }


        //Event Args symbols levels buttons


        private void FirstNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstNumbersPage());
        }

        private void SecondNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondNumbersPage());
        }

        private void ThirdNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdNumbersPage());
        }

        private void FourthNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthNumbersPage());
        }

        //Event Args punctuation levels buttons


        private void FirstPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstPunctuationPage());
        }

        private void SecondPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondPunctuationPage());
        }

        private void ThirdPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdPunctuationPage());
        }

        private void FourthPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthPunctuationPage());
        }
    }
}
