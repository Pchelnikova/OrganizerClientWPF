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
                _dal.ChangeUser_Status(CurrentUser.Login, Status_ComboBox.Text);
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
    }
}
