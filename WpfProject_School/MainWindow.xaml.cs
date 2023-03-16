﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfProject_School;

namespace WpfProject_School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private Point startPoint;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                MainFrame.Content = new AuthPage();
                LoadLoginInfo();
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadLoginInfo()
        {
            if (File.Exists(@"C:\Logs\currentUser.json"))
            {
                string loginJson = File.ReadAllText(@"C:\Logs\currentUser.json");
                dynamic loginInfo = JsonConvert.DeserializeObject(loginJson);

                if ((bool)loginInfo.IsLoggedIn)
                {
                    MainFrame.Content = new UIPage();
                }
                //else throw new Exception("Error Ocured: Account is not autorized.");
            }
        }
    }
}