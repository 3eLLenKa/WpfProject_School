using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfProject_School.Levels.RussianLevels.LettersLevels;
using WpfProject_School.Levels.RussianLevels.WordsLevels;
using WpfProject_School.Levels.RussianLevels.NumbersAndSymbolsLevels;
using WpfProject_School.Levels.RussianLevels.PunctuationMarksLevels;

namespace WpfProject_School.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для RussianLevelsView.xaml
    /// </summary>
    public partial class RussianLevelsView : UserControl
    {
        public RussianLevelsView()
        {
            InitializeComponent();
        }

        //EventArgs letters levels buttons

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
            NavigationService.GetNavigationService(this).Navigate(new FirstLettersLevelPage());
        }

        private void SecondLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondLettersLevelPage());
        }

        private void ThirdLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdLettersLevelPage());
        }

        private void FourthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthLettersLevelPage());
        }

        private void FifthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FifthLettersLevelPage());
        }

        private void SixthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SixthLettersLevelPage());
        }

        private void SeventhLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SeventhLettersLevelPage());
        }

        private void EighthLettersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new EighthLettersLevelPage());
        }


        //Event Args word levels buttons


        private void FirstWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstWordsLevelPage());
        }

        private void SecondWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondWordsLevelPage());
        }

        private void ThirdWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdWordsLevelPage());
        }

        private void FourthWordsPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthWordsLevelPage());
        }


        //Event Args numbers and symbols levels buttons


        private void FirstNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstNumbersLevelPage());
        }

        private void SecondNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondNumbersLevelPage());
        }

        private void ThirdNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdNumbersLevelPage());
        }

        private void FourthNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthNumbersLevelPage());
        }

        private void FifthNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FifthNumbersLevelPage());
        }

        private void SixthNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SixthNumbersLevelPage());
        }

        private void SeventhNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SeventhNumbersLevelPage());
        }

        private void EighthNumbersPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new EighthNumbersLevelPage());
        }


        //Event Args punctuation levels buttons


        private void FirstPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FirstPunctuationLevelPage());
        }

        private void SecondPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new SecondPunctuationLevelPage());
        }

        private void ThirdPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new ThirdPunctuationLevelPage());
        }

        private void FourthPunctuationPageNavigation(object sender, RoutedEventArgs e)
        {
            WindowSettings();
            NavigationService.GetNavigationService(this).Navigate(new FourthPunctuationLevelPage());
        }
    }
}
