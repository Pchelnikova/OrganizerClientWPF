using MahApps.Metro.Controls;
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
using DALOrganizerClientWPF;
using OrganizerClientWPF.Converters;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for User_Account_Show.xaml
    /// </summary>
    public partial class User_Account_Info : MetroWindow
    {
        private readonly DataDAL _dal = new DataDAL();
        public User CurrentUser { get; } = new User();
        private bool _change_login = false;
        private bool _change_password = false;
        private bool _change_status = false;
        public User_Account_Info(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
            title.Text = CurrentUser.Login.ToString().ToUpper() + "'s INFO";
            if (_dal.GetTypeUser(CurrentUser.Login) == true)
            {
                Status_ComboBox.Visibility = Visibility.Visible;
                Binding binding = new Binding();
                binding.Source = (_dal.GetAllJuniors().ToList());
                Choose_user_for_change_status.SetBinding(DataGrid.ItemsSourceProperty, binding);
                Choose_user_for_change_status.Visibility = Visibility.Visible;
                Binding binding2 = new Binding();
                binding2.Source = (_dal.GetAllRangs().ToList());
                Status_ComboBox.SetBinding(DataGrid.ItemsSourceProperty, binding2);
                Status_ComboBox.Visibility = Visibility.Visible;

            }
        }
        //change login
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _change_login = true;
        }
        //change password
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _change_password = true;
        }
        //Button Logout
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login_Window login_Window = new Login_Window();
            login_Window.Show();
            this.Close();
        }
        //save changes Button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (_change_login == true)
            {
                _dal.ChangeUser_Login(CurrentUser.Login, Login_TextBox.Text);
            }
            if (_change_password == true)
            {
                _dal.ChangeUser_Password(CurrentUser.Login, Password_TextBox.Text);
            }
            if (_change_status == true)
            {
                _dal.ChangeUser_Status(Choose_user_for_change_status.SelectedValue.ToString(), Status_ComboBox.Text);
            }
        }
        //button Delete Account
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _dal.DeleteUser(CurrentUser.Login);
        }
        //change status
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _change_status = true;
        }
        //back to menu
        private void Button_Click_BackToMenu(object sender, RoutedEventArgs e)
        {
            FirstChoice_Window firstChoice_Window = new FirstChoice_Window(CurrentUser.Login);
            firstChoice_Window.Show();
            this.Close();
        }

        private void Choose_user_for_change_status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
