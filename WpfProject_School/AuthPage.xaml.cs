﻿using System;
using System.IO;
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
using Newtonsoft.Json;

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        DataBase dataBase = new DataBase();
        public AuthPage()
        {
            InitializeComponent();
            //LoadLoginInfo();
        }

        private void RegNavigate(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void AuthClick(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = passwordBox.Password.Trim();

            string connectionString = @"Data Source=DESKTOP-HCK9T1F\SQLEXPRESS; Initial Catalog=ProjectDB; User ID=login; Password=password; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login = @login AND Password = @password", connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // сохраняем информацию о входе пользователя в файл
                        var loginInfo = new { Login = login, IsLoggedIn = true };
                        string loginJson = JsonConvert.SerializeObject(loginInfo);

                        using (StreamWriter sw = File.CreateText(@"C:\Logs\currentUser.json"))
                        {
                            sw.Write(loginJson);
                        }

                        MessageBox.Show("Вы усешно вошли в аккаунт", "Информация о входе.");

                        var mainFrame = (Window.GetWindow(this)?.FindName("MainFrame") as Frame);
                        mainFrame?.Navigate(new UIPage());
                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль!");
                    }
                }
            }
        }
    }
}