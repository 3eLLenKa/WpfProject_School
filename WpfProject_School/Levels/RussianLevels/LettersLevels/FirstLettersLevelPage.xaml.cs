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

        private bool isStarted = false;
        private int currentLength = 0;

        private Dictionary<Key, string> EnglishToRussianLetters = new Dictionary<Key, string>
        {
        { Key.A, "ф" },
        { Key.B, "и" },
        { Key.C, "с" },
        { Key.D, "в" },
        { Key.E, "у" },
        { Key.F, "а" },
        { Key.G, "п" },
        { Key.H, "р" },
        { Key.I, "ш" },
        { Key.J, "о" },
        { Key.K, "л" },
        { Key.L, "д" },
        { Key.M, "ь" },
        { Key.N, "т" },
        { Key.O, "щ" },
        { Key.P, "з" },
        { Key.Q, "й" },
        { Key.R, "к" },
        { Key.S, "ы" },
        { Key.T, "е" },
        { Key.U, "г" },
        { Key.V, "м" },
        { Key.W, "ц" },
        { Key.X, "ч" },
        { Key.Y, "н" },
        { Key.Z, "я" },
        {Key.Space, " " },
        {Key.Enter, "enter" }
        };

        private async void ProgressTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            string key = EnglishToRussianLetters[e.Key];
            int progressLength = ProgressTextBox.Text.Length;

            //MessageBox.Show(key);

            if (!isStarted)
            {
                if (key == " ")
                {
                    ProgressTextBox.Foreground = Brushes.Gray;
                    ProgressTextBox.Text = "ввово вовов овово вовоо оовов во ов вовво овово вово вов ово во овов аааооо ааоао оааоо аоаоа ооаоа ва оо аоаао оаоао вао ава вова авао оао лллааа ллала аллаа лалал аалал вал ла лалла алала вол лов алла вал ава вввллл ввлвл лввлл влвлв ллвлв вова лов влввл лвлвл алло олав вола лола лова вввааа аавав ваавв ава вава авава ввава вава алл ава в оао лала оооллл оолол лоолл олово лол ололо ллоло лава ово лово лол во овал аоавл воаал влвао лаоов лвлоа алвво вово лава овал алла олав олово вал алло";
                    isStarted = true;
                }
            }
            else
            {
                while (currentLength < progressLength)
                {
                    if (key == ProgressTextBox.Text[currentLength].ToString())
                    {
                        // Окрашивание текущей буквы в черный цвет
                        ProgressTextBox.SelectionStart = currentLength;
                        ProgressTextBox.SelectionLength = 1;
                        ProgressTextBox.SelectionTextBrush = Brushes.AliceBlue;

                        currentLength++;
                    }

                    // Ожидание нажатия клавиши
                    while (true)
                    {
                        await Task.Delay(50);
                        if (Keyboard.IsKeyDown(e.Key))
                        {
                            key = EnglishToRussianLetters[e.Key];
                            break;
                        }
                    }
                }
            }
        }
        private void ProgressTextBox_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            e.Handled = true;
        }
    }
}