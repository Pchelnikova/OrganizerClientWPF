using DALOrganizerClientWPF;
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
       private readonly DataDAL _dalCl = new DataDAL();
        public Login_Window()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if(_dalCl.Authorization(loginBox.Text, passwordBox.Password))            
            {
                FirstChoice_Window firstChoice_Window = new FirstChoice_Window(loginBox.Text);
                firstChoice_Window.Show();
                this.Close();
            }
            else
            {
                Login_Not_Exist login_Not_Exist = new Login_Not_Exist();
                login_Not_Exist.Show();
                this.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Create_Account create_Account = new Create_Account();
            create_Account.Show();
            this.Close();
        }
    }
}
