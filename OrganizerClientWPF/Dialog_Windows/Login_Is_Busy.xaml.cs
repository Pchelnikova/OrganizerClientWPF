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
    /// Interaction logic for Login_Is_Busy.xaml
    /// </summary>
    public partial class Login_Is_Busy : MetroWindow
    {
        public Login_Is_Busy()
        {
            InitializeComponent();
        }

        //go to Create_Login
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Create_Account create_Account = new Create_Account();
            create_Account.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
