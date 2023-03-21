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

namespace WpfProject_School.Levels.RussianLevels.LettersLevels
{
    /// <summary>
    /// Логика взаимодействия для FirstLettersLevelPage.xaml
    /// </summary>
    public partial class FirstLettersLevelPage : Page
    {
        public FirstLettersLevelPage()
        {
            InitializeComponent();
            ProgressTextBox.Focus();
        }

        private void ProgressTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            
            if (e.Key == Key.Space)
            {
                ProgressTextBox.Foreground = Brushes.Gray;
                ProgressTextBox.Text = "вввооо ввово оввоо вовов оовов во ов вовво овово вово вов ово во овов аааооо ааоао оааоо аоаоа ооаоа ва оо аоаао оаоао вао ава вова авао оао лллааа ллала аллаа лалал аалал вал ла лалла алала вол лов алла вал ава вввллл ввлвл лввлл влвлв ллвлв вова лов влввл лвлвл алло олав вола лола лова вввааа аавав ваавв ава вава авава ввава вава алл ава в оао лала оооллл оолол лоолл олово лол ололо ллоло лава ово лово лол во овал аоавл воаал влвао лаоов лвлоа алвво вово лава овал алла олав олово вал алло";

                string text = ProgressTextBox.Text;

                if (e.Key == Key.Enter)
                {
                    ProgressTextBox.Foreground = Brushes.Black;
                }
            } 
        }

        private void ProgressTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //e.Handled = true;
        }
    }
}
