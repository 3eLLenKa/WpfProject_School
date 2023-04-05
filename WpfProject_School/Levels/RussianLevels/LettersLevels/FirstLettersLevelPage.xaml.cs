using System;
using System.Collections.Generic;
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

        private bool isPaused = false;

        private int currentIndex = 0;
        private int currentLevel = 0;

        private string[] letters = { "ввово вовов овово вовоо оовов во ов вовво овово вово",
                                 "вов ово во овов аааооо ааоао оааоо аоаоа ооаоа ва оо",
                                 "аоаао оаоао вао ава вова авао оао лллааа ллала аллаа",
                                 "лалал аалал вал ла лалла алала вол лов алла вал аваа",
                                 "вввллл ввлвл лввлл влвлв ллвлв вова лов влввл лвлвлл",
                                 "алло олав вола лола лова вввааа аавав ваавв ава вава",
                                 "авава ввава вава алл ава в оао лала оооллл оолол лол",
                                 "олово лол ололо ллоло лава ово лово лол во овал аоав",
                                 "воаал влвао лаоов лвлоа алвво вово лава овал алла ол"};

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
        {Key.Escape, "esc" },
        };

        private void ProgressTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            string key = EnglishToRussianLetters[e.Key];

            if (!isStarted && progressBar.Value == progressBar.Maximum)
            {
                e.Handled = true;

                if (key == " ") isStarted = false;
                if (key == "esc") NavigationService.GoBack();
            }

            if (!isStarted)
            {
                if (key == " ")
                {
                    isStarted = true;

                    ProgressTextBox.Foreground = Brushes.Gray;
                    ProgressTextBox.Text = letters[0];
                    ProgressTextBox.TextAlignment = TextAlignment.Center;

                    progressBar.Value = 0;
                }

                else if (key == "esc")
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите вернуться?", "Подтверждение", MessageBoxButton.YesNo);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            NavigationService.GoBack();
                            break;
                        case MessageBoxResult.No:
                            break;
                    }

                }
            }
            else
            {
                if (key == ProgressTextBox.Text[currentIndex].ToString())
                {
                    if (currentIndex == letters[currentLevel].Length-1)
                    {
                        currentIndex = 0;
                        currentLevel++;
                        ProgressTextBox.Text = letters[currentLevel];
                    }

                    if (currentLevel == letters.Length-1)
                    {
                        currentLevel = 0;
                        ProgressTextBox.Text = "Уровень пройден! (Пробел - Перепройти/ESC - Список уровней)";
                        progressBar.Value = progressBar.Maximum;
                        MessageBox.Show("Кол - во ошибок: \nЗатраченное время:", "Результаты тренировки");

                        isStarted = false;
                    }

                    else
                    {

                        ProgressTextBox.SelectionStart = currentIndex;
                        ProgressTextBox.SelectionLength = 1;
                        ProgressTextBox.SelectionBrush = Brushes.Black;

                        currentIndex++;
                        progressBar.Value++;
                    }
                }

                else if (key == "esc")
                {
                    MessageBoxResult result = MessageBox.Show("Продолжить?", "Пауза", MessageBoxButton.YesNo);

                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            break;
                        case MessageBoxResult.No:
                            NavigationService.GoBack();
                            break;
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