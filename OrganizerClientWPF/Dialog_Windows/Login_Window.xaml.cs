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

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
   
    public partial class Login_Window : MetroWindow
    {
       
        public Login_Window()
        {
            InitializeComponent();
        }
        //перевірка логіна/пароля
        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text == "1" && passwordBox.Password == "1")
            {
                FirstChoice_Window firstChoice_Window = new FirstChoice_Window();
                firstChoice_Window.Show();
                DTO.User.Login = loginBox.Text;

            }
            //using (var ctx = new Model())
            //{
            //    List<Model_Classes.User> users = ctx.Users.ToList();
            //    var log = users.FirstOrDefault(item => item.Login == loginBox.Text && item.Password_ == passwordBox.Password);
            //    if (log != null)
            //    {
            //        Begin_Window begin = new Begin_Window();
            //        begin.Show();
            //        //глобальна змінна для id
            //        MainWindow.Global.userID = log == null ? 0 : log.Id;
            //        this.Close();
            //    }
            //    else
            //    {
            //        Login_Not_Exist login_Not_Exist = new Login_Not_Exist();
            //        login_Not_Exist.Show();
            //        this.Close();
            //    }
            //}
        }
        //for create new account
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Create_Account window1 = new Create_Account();
            window1.Show();
            this.Close();
        }
    }
}
