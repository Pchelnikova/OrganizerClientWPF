using MahApps.Metro.Controls;
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
    /// Interaction logic for Create_Account.xaml
    /// </summary>
    public partial class Create_Account : MetroWindow
    {
        public Create_Account()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            //string new_login = loginBox.Text;
            //string new_password = passwordBox.Text;

            //using (var ctx = new Model())
            //{
            //    var users = ctx.Users.ToList();
            //    var rang = ctx.Rangs_of_User.ToList();
            //    var user_ = users.FirstOrDefault(item => item.Login == new_login);
            //    if (user_ == null)
            //    {
            //        User user = new User() { Login = new_login, Password_ = new_password, Rang_of_User = rang.FirstOrDefault(item => item.Rang == "Junior") };
            //        ctx.Users.Add(user);
            //        MainWindow.Global.userID = user == null ? 0 : user.Id;
            //        ctx.SaveChanges();

            //        Login_Window login = new Login_Window();
            //        login.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        Login_Is_Busy login_Is_Busy = new Login_Is_Busy();
            //        login_Is_Busy.Show();
            //        this.Close();
            //        loginBox.Text = null;
            //        passwordBox.Text = null;
            //    }
            //}

        }
        //exit
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
