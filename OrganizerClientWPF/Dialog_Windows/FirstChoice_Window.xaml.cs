﻿using MahApps.Metro.Controls;
using OrganizerClientWPF.DTO;
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
using System.Windows.Shapes;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FirstChoice_Window : MetroWindow
    {

        public User CurrentUser { get; } = new User();
        public FirstChoice_Window(string userLogin)
        {
            CurrentUser.Login = userLogin;
            InitializeComponent();
        }

        //DIARY begin
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DIARY dairy_Window = new DIARY(CurrentUser);
            dairy_Window.Show();
            this.Close();
        }
        //Budget begin
        private void Budjet_Click(object sender, RoutedEventArgs e)
        {
            BUDGET budjet_Window = new BUDGET(CurrentUser);
            budjet_Window.Show();
            this.Close();
        }
        //Wish-List
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WISH wish_Window = new WISH(CurrentUser);
            wish_Window.Show();
            this.Close();
        }
    }
}
