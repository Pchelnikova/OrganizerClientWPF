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
        public User_Account_Info(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
            title.Text = CurrentUser.Login.ToString().ToUpper() + "'s INFO";
        }

        //change login
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //change parol
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login_Window login_Window = new Login_Window();
            login_Window.Show();
            this.Close();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _dal.DeleteUser(CurrentUser.Login);
        }
    }
}
