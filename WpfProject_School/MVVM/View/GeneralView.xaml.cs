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
using WpfProject_School.InfoPages;

namespace WpfProject_School.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для GeneralView.xaml
    /// </summary>
    public partial class GeneralView : UserControl
    {
        public GeneralView()
        {
            InitializeComponent();
        }

        private void LevelsPageClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new LevelsPage());
        }

        private void GoToFirstInfoPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new FirstInfoPage());
        }

        private void GoToSecondInfoPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new SecondInfoPages());
        }

        private void GoToThirdInfoPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new ThirdInfoPage());
        }

        private void GoToFourthInfoPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new FourthInfoPage());
        }
    }
}
