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
using System.Windows.Threading;

namespace WpfProject_School.Levels.RussianLevels.LettersLevels
{
    /// <summary>
    /// Логика взаимодействия для SecondLettersLevelPage.xaml
    /// </summary>
    public partial class SecondLettersLevelPage : Page
    {
        public SecondLettersLevelPage()
        {
            InitializeComponent();
            ProgressTextBox.Focus();
        }

        private DispatcherTimer timer;

        private bool isStarted = false;

        private int currentIndex = 0;
        private int currentLevel = 0;
        private int errosCount = 0;

        private int secondsElapsed;
        private int minutesElapsed;

        private string[] letters = { "фффддд ффдфд дффдд фдфдф ддфдф вода два фдффд дфдфд", 
                                     "вдова вода два два вдова ыыыддд ыыдыд дыыдд ыды два",
                                     "вывод два ыдыыд дыдыд вывод вода два вдова вывод вдв",
                                     "жжыжы ыжжыы жыжыж ыыжыж лыжа дважды жыжжы ыжы вывод",
                                     "жажда лыжа дважды жажда фффжж ффжфж жфж фжфжф жжфжф",
                                     "жажда ффжф фжффж жфжфж дважды лыжа дважды жажда лыжа",
                                     "фффыыы ыыфыф фыыфф лыжа ыфыфы ффыфы дважды вывод",
                                     "лыжа вывод дважды ддджжж ждджж вдова лыжа джджд",
                                     "жжджд вывод жажда вода дважды два ыдыфж дфжжы дыджф",
                                     "фдыыж фжфыд жыддф жфжды ыжффд вывод вдова вода дважды" };

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

            string key = EnglishToRussianLetters.ContainsKey(e.Key) ? EnglishToRussianLetters[e.Key] : null;

            if (!isStarted)
            {
                if (key == " ")
                {
                    isStarted = true;

                    secondsElapsed = 0;
                    minutesElapsed = 0;

                    StartTimer();

                    errosCount = 0;
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
                            WindowSettings();
                            NavigationService.GoBack();
                            break;
                        case MessageBoxResult.No:
                            break;
                    }

                }
            }
            else
            {
                if (key == " ")
                {
                    if (currentIndex == letters[currentLevel].Length - 1)
                    {
                        currentIndex = 0;
                        currentLevel++;
                        ProgressTextBox.Text = letters[currentLevel];
                    }

                    if (currentLevel == letters.Length - 1)
                    {
                        isStarted = false;

                        timer.Stop();

                        currentLevel = 0;
                        ProgressTextBox.Text = "Уровень пройден! (Пробел - Перепройти/ESC - Список уровней)";
                        progressBar.Value = progressBar.Maximum;

                        MessageBox.Show($"Кол - во ошибок: {errosCount} \nЗатраченное время: {timeBlock.Text.Substring(7, 5)}", "Результаты тренировки");
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

                else if (isStarted && key == "esc")
                {
                    timer.Stop();

                    MessageBoxResult result = MessageBox.Show("Продолжить?", "Пауза", MessageBoxButton.YesNo);

                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            timer.Start();
                            break;
                        case MessageBoxResult.No:
                            WindowSettings();
                            NavigationService.GoBack();
                            break;
                    }
                }

                else
                {
                    errosCount++;
                }
            }
        }

        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void WindowSettings()
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;

            mainWindow.WindowState = WindowState.Normal;
            mainWindow.MinimizeButton.Visibility = Visibility.Visible;
            mainWindow.MaximizeButton.Visibility = Visibility.Visible;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            if (secondsElapsed == 60)
            {
                secondsElapsed = 0;
                minutesElapsed++;
            }

            timeBlock.Text = string.Format("Время: {1:00}:{0:00}", secondsElapsed, minutesElapsed);
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.OriginalSource is TextBox))
            {
                ProgressTextBox.Focus();
            }
        }
        private void ProgressTextBox_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            e.Handled = true;
        }
    }
}