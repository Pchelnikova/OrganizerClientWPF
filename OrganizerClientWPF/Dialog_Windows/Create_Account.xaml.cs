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
using DALOrganizerClientWPF;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Create_Account.xaml
    /// </summary>
    public partial class Create_Account : MetroWindow
    {
        private readonly DataDAL _dal = new DataDAL();
        public Create_Account()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
          if( _dal.Create_New_User(loginBox.Text, passwordBox.Text))
            {
                Login_Window login_Window = new Login_Window();
                login_Window.Show();
                this.Close();
            }
          else
          { 
                Login_Is_Busy login_Is_Busy = new Login_Is_Busy();
                login_Is_Busy.Show();
                this.Close();
          }          
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        

    }
}
