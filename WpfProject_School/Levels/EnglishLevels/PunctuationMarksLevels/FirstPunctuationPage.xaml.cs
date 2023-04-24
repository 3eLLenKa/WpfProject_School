﻿using System;
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

namespace WpfProject_School.Levels.EnglishLevels.PunctuationMarksLevels
{
    /// <summary>
    /// Логика взаимодействия для FirstPunctuationPage.xaml
    /// </summary>
    public partial class FirstPunctuationPage : Page
    {
        public FirstPunctuationPage()
        {
            InitializeComponent();
            ProgressTextBox.Focus();
        }

        private DispatcherTimer timer;

        private bool isStarted = false;

        private int currentIndex = 1;
        private int currentLevel = 0;
        private int errosCount = 0;

        private double correctCount = 0;
        private double clicksCount = 0;

        private int secondsElapsed;
        private int minutesElapsed;

        private string[] letters = { " ,,,;;; ,,;,; ;,,;; ,;,;, ;;,;, advise, sort;",
                                     " ,;,,; ;,;,; Harsh, formal, chef; recall,",
                                     " track; ...;;; ..;.; ;..;; .;.;. ;;.;. moral;",
                                     " senior. .;..; ;.;.; Begin; staff. Sector. Fit;",
                                     " six. :::... ::.:. .::.. :.:.: ..:.: dog: dump.",
                                     " :.::. .:.:. Senate. Organ: flu. Math: proper.",
                                     " ,,,::: ,,:,: :,,:: ,:,:, ::,:, ground: hot,",
                                     " ,:,,: :,:,: Admire: finger, yours, dad: great",
                                     " ,,,... ..,., ,..,, global, still. .,.,. ,,.,.",
                                     " Sea, twenty, energy. wear, pop. ;;;::: ;;:;:",
                                     " :;;:: game: shake; ;:;:; ::;:; Seek: noon;",
                                     " broad: below; agenda; .;.,: ;,::. ;.;:, ,;..:",
                                     " ,:,.; :.;;, :,:;. .:,,; Cat: poor, wide;",
                                     " lawyer, proud. Urge: notion, area; expand, hand." };


        private Dictionary<Key, string> PunctuationMarks = new Dictionary<Key, string>
        {
            {Key.D1, "!" },
            {Key.D2, "@"},
            {Key.D3, "#"},
            {Key.D4, "$"},
            {Key.D5, "%"},
            {Key.D6, "^"},
            {Key.D7, "&"},
            {Key.D8, "*"},
            {Key.D9, "("},
            {Key.D0, ")"},
            {Key.OemMinus, "-" },
            {Key.OemPlus, "="},
            {Key.OemQuotes, "'"},
            {Key.Oem1, ";"},
            {Key.OemComma, ","},
            {Key.OemPeriod, "."},
            {Key.OemQuestion, "/"},
            {Key.Oem5, "\\" }
        };


        private Dictionary<Key, string> KeyboardButtons = new Dictionary<Key, string>
        {
        {Key.D1, "D1"},
        {Key.D2, "D2"},
        {Key.D3, "D3"},
        {Key.D4, "D4"},
        {Key.D5, "D5"},
        {Key.D6, "D6"},
        {Key.D7, "D7"},
        {Key.D8, "D8"},
        {Key.D9, "D9"},
        {Key.D0, "D0"},
        {Key.OemMinus, "OemMinus" },
        {Key.OemTilde, "OemTilde" },
        {Key.OemPlus, "OemPlus" },
        {Key.Back, "Back" },
        {Key.Tab, "Tab" },
        {Key.Oem5, "Oem5" },
        {Key.CapsLock, "CapsLock" },
        {Key.Enter, "Enter" },
        {Key.LeftShift, "LeftShift" },
        {Key.RightShift, "RightShift" },
        {Key.LeftCtrl, "LeftCtrl" },
        {Key.RightCtrl, "RightCtrl" },
        {Key.LWin, "LWin" },
        {Key.RWin, "RWin" },
        {Key.OemQuestion, "OemQuestion" },
        {Key.OemOpenBrackets, "OemOpenBrackets" },
        {Key.OemCloseBrackets, "OemCloseBrackets" },
        {Key.OemQuotes, "OemQuotes" },
        {Key.Oem1, "Oem1" },
        {Key.OemComma, "OemComma" },
        {Key.OemPeriod, "OemPeriod" },
        { Key.A, "A" },
        { Key.B, "B" },
        { Key.C, "C" },
        { Key.D, "D" },
        { Key.E, "E" },
        { Key.F, "F" },
        { Key.G, "G" },
        { Key.H, "H" },
        { Key.I, "I" },
        { Key.J, "J" },
        { Key.K, "K" },
        { Key.L, "L" },
        { Key.M, "M" },
        { Key.N, "N" },
        { Key.O, "O" },
        { Key.P, "P" },
        { Key.Q, "Q" },
        { Key.R, "R" },
        { Key.S, "S" },
        { Key.T, "T" },
        { Key.U, "U" },
        { Key.V, "V" },
        { Key.W, "W" },
        { Key.X, "X" },
        { Key.Y, "Y" },
        { Key.Z, "Z" },
        {Key.Space, "Space" }
        };

        private void ProgressTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"{e.Key}");

            e.Handled = true;

            clicksCount++;

            string key = e.Key.ToString().ToLower();
            string punctuation = PunctuationMarks[e.Key];

            if (punctuation != null)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift))
                {
                    switch (e.Key)
                    {
                        case Key.OemMinus:
                            if (ProgressTextBox.Text[currentIndex] == '-') return;
                            if (ProgressTextBox.Text[currentIndex] == '_') punctuation = "_";
                            break;
                        case Key.D1:
                            if (ProgressTextBox.Text[currentIndex] == '1') return;
                            if (ProgressTextBox.Text[currentIndex] == '!') punctuation = "!";
                            break;
                        case Key.OemPlus:
                            if (ProgressTextBox.Text[currentIndex] == '=') return;
                            if (ProgressTextBox.Text[currentIndex] == '+') punctuation = "+";
                            break;
                        case Key.D8:
                            if (ProgressTextBox.Text[currentIndex] == '8') return;
                            if (ProgressTextBox.Text[currentIndex] == '*') punctuation = "*";
                            break;
                        case Key.D9:
                            if (ProgressTextBox.Text[currentIndex] == '9') return;
                            if (ProgressTextBox.Text[currentIndex] == '(') punctuation = "(";
                            break;
                        case Key.D4:
                            if (ProgressTextBox.Text[currentIndex] == '4') return;
                            if (ProgressTextBox.Text[currentIndex] == ';') punctuation = ";";
                            break;
                        case Key.D0:
                            if (ProgressTextBox.Text[currentIndex] == '0') return;
                            if (ProgressTextBox.Text[currentIndex] == ')') punctuation = ")";
                            break;
                        case Key.D7:
                            if (ProgressTextBox.Text[currentIndex] == '7') return;
                            if (ProgressTextBox.Text[currentIndex] == '?') punctuation = "?";
                            break;
                        case Key.D2:
                            if (ProgressTextBox.Text[currentIndex] == '2') return;
                            if (ProgressTextBox.Text[currentIndex] == '\"') punctuation = "\"";
                            break;
                        case Key.D6:
                            if (ProgressTextBox.Text[currentIndex] == '6') return;
                            if (ProgressTextBox.Text[currentIndex] == ':') punctuation = ":";
                            break;
                        case Key.D3:
                            if (ProgressTextBox.Text[currentIndex] == '3') return;
                            if (ProgressTextBox.Text[currentIndex] == '№') punctuation = "№";
                            break;
                        case Key.D5:
                            if (ProgressTextBox.Text[currentIndex] == '5') return;
                            if (ProgressTextBox.Text[currentIndex] == '%') punctuation = "%";
                            break;
                    }
                }
            }

            if (e.Key == Key.Space)
            {
                key = " ";
            }
            //else key = null;

            if (char.IsUpper(ProgressTextBox.Text[currentIndex]))
            {
                if (Keyboard.IsKeyDown(Key.LeftShift) & e.IsDown)
                {
                    key = key.ToUpper();
                }
                else return;
            }

            if (currentIndex + 1 < ProgressTextBox.Text.Length && char.IsPunctuation(ProgressTextBox.Text[currentIndex + 1]))
            {
                if (currentIndex == letters[currentLevel].Length - 1)
                {
                    return;
                }
                else
                {
                    ButtonsPunctuationContent();
                }
            }
            else
            {
                ButtonsLettersContent();
            }

            if (!isStarted)
            {
                if (e.Key == Key.Space)
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

                else if (e.Key == Key.Escape)
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
                    correctCount++;

                    if (currentIndex == letters[currentLevel].Length - 1)
                    {
                        currentIndex = 0;
                        currentLevel++;
                        ProgressTextBox.Text = letters[currentLevel];
                    }

                    if (currentLevel == letters.Length - 1)
                    {
                        var brush = new SolidColorBrush(Color.FromRgb(0xDD, 0xDD, 0xDD));

                        isStarted = false;

                        timer.Stop();

                        currentLevel = 0;
                        Q.Background = brush;

                        ProgressTextBox.Text = "Уровень пройден! (Пробел - Перепройти/ESC - Список уровней)";
                        progressBar.Value = progressBar.Maximum;

                        MessageBox.Show($"Кол - во ошибок: {errosCount} \nСредняя точность: {averageAccuracy()} \nЗатраченное время: {timeBlock.Text.Substring(7, 5)}", "Результаты тренировки");
                    }

                    else
                    {
                        ProgressTextBox.SelectionStart = 1;
                        ProgressTextBox.SelectionLength = currentIndex;
                        ProgressTextBox.SelectionBrush = Brushes.Black;

                        currentIndex++;
                        progressBar.Value++;
                    }
                }

                else if (isStarted && e.Key == Key.Escape)
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

        private void ButtonPreview_Up(object sender, KeyEventArgs e)
        {
            var brush = new SolidColorBrush(Color.FromRgb(0xDD, 0xDD, 0xDD));

            string keyPressed = KeyboardButtons.ContainsKey(e.Key) ? KeyboardButtons[e.Key] : null;

            // Находим кнопку с соответствующим именем
            Button button = (Button)this.FindName(keyPressed);

            // Если кнопка найдена, меняем её фон в зависимости от нажатой клавиши
            if (button != null)
            {
                button.Background = brush;
            }

            if (e.Key.ToString() == "System")
            {
                LeftAlt.Background = brush;
                RightAlt.Background = brush;
            }
        }

        private void ButtonPreview_Down(object sender, KeyEventArgs e)
        {
            var brush = new SolidColorBrush(Color.FromRgb(0xB3, 0x9D, 0xDB));

            string keyPressed = KeyboardButtons.ContainsKey(e.Key) ? KeyboardButtons[e.Key] : null;

            // Находим кнопку с соответствующим именем
            Button button = (Button)this.FindName(keyPressed);

            // Если кнопка найдена, меняем её фон в зависимости от нажатой клавиши
            if (button != null)
            {
                button.Background = brush;
            }

            if (e.Key.ToString() == "System")
            {
                LeftAlt.Background = brush;
                RightAlt.Background = brush;
            }
        }

        private void ButtonsPunctuationContent()
        {
            OemTilde.Content = "~Ё`";
            D1.Content = "1 !";
            D2.Content = "2\"";
            D3.Content = "3№";
            D4.Content = "4;";
            D5.Content = "5%";
            D6.Content = "6:";
            D7.Content = "7?";
            D8.Content = "8*";
            D9.Content = "9 (";
            D0.Content = "0 )";
            OemMinus.Content = "-_";
            OemPlus.Content = "=+";
            OemQuestion.Content = ".,";
        }

        private void ButtonsLettersContent()
        {
            OemTilde.Content = "ё";
            D1.Content = "1";
            D2.Content = "2";
            D3.Content = "3";
            D4.Content = "4";
            D5.Content = "5";
            D6.Content = "6";
            D7.Content = "7";
            D8.Content = "8";
            D9.Content = "9";
            D0.Content = "0";
            OemMinus.Content = "-";
            OemPlus.Content = "=";
            OemQuestion.Content = ".";
        }
        private string averageAccuracy()
        {
            string accuracy = Math.Round(correctCount / clicksCount * 100).ToString() + "%";
            return accuracy;
        }

        private void ProgressTextBox_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            e.Handled = true;
        }
    }
}