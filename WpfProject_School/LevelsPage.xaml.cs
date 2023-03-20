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

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для LevelsPage.xaml
    /// </summary>
    public partial class LevelsPage : Page
    {
        public LevelsPage()
        {
            InitializeComponent();
        }

        public void MainMenuClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).GoBack();
        }
    }
}
