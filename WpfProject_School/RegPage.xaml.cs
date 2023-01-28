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
using System.Data.SqlClient;
using System.Data;

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        DataBase dataBase = new DataBase();
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = passwordBox.Password.Trim();

            if (checkData() == false)
            {
                string querrystring = $"insert into Users(login, password) values('{login}', '{password}')";

                SqlCommand command = new SqlCommand(querrystring, dataBase.GetConnection());

                dataBase.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");
                }
                else MessageBox.Show("Ошибка #1");
            }
        }
        private Boolean checkData()
        {
            var login = textBoxLogin.Text.Trim();
            string connectionString = @"Data Source=DESKTOP-HCK9T1F\SQLEXPRESS; Initial Catalog=ProjectDB; User ID=login; Password=password; Integrated Security=True";

            if (textBoxLogin.Text.Length < 5)
            {
                textBoxLogin.ToolTip = "Логин должен быть больше 5-ти символов!";
                textBoxLogin.Background = Brushes.Red;
                return true;
            }

            else if (passwordBox.Password.Length < 5)
            {
                passwordBox.ToolTip = "Пароль должен быть больше 5-ти символов!";
                passwordBox.Background = Brushes.Red;

                textBoxLogin.Background = Brushes.Transparent;
                textBoxLogin.ToolTip = null;
                return true;
            }

            else if (passwordBox.Password == "qwerty" | passwordBox.Password == "qwerty".ToUpper()
                    | passwordBox.Password == "12345")
            {
                passwordBox.ToolTip = "Пароль слишком простой!";
                passwordBox.Background = Brushes.Red;

                textBoxLogin.Background = Brushes.Transparent;
                textBoxLogin.ToolTip = null;

                return true;
            }

            else if (passwordBoxDouble.Password != passwordBox.Password)
            {
                passwordBoxDouble.ToolTip = "Пароли не совпадают!";
                passwordBoxDouble.Background = Brushes.Red;

                passwordBox.Background = Brushes.Transparent;
                passwordBox.ToolTip = null;

                return true;
            }

            else
            {
                textBoxLogin.ToolTip = null;
                passwordBox.ToolTip = null;
                passwordBoxDouble.ToolTip = null;

                textBoxLogin.Background = Brushes.Transparent;
                passwordBox.Background = Brushes.Transparent;
                passwordBoxDouble.Background = Brushes.Transparent;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login = @login", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Этот аккаунт уже зарегестрирован!");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Новый аккаунт успешно зарегестрирован!");
                            NavigationService.Navigate(new UIPage());
                            return false;
                        }
                    }
                }
            }
        }
    }
}