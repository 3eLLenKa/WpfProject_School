using System.Windows.Controls;
using System.Windows.Input;
using WpfProject_School.Core.RussianLevelsClasses;

namespace WpfProject_School.Levels.RussianLevels.LettersLevels
{
    public partial class FirstLettersLevelPage : Page
    {
        private RussianLettersLevel russianLetters;

        public FirstLettersLevelPage()
        {
            InitializeComponent();
            ProgressTextBox.Focus();

            // Создаем экземпляр класса RussianLettersLevel, передавая текущий экземпляр страницы
            russianLetters = new RussianLettersLevel();
        }

        private void ProgressTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            russianLetters.ProgressTextBox_PreviewKeyDown(sender, e);
        }

        private void ProgressTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            russianLetters.ProgressTextBox_PreviewMouseDown(sender, e);
        }

        private void ButtonPreview_Down(object sender, KeyEventArgs e)
        {
            russianLetters.ButtonPreview_Down(sender, e);
        }

        private void ButtonPreview_Up(object sender, KeyEventArgs e)
        {
            russianLetters.ButtonPreview_Up(sender, e);
        }
    }
}
