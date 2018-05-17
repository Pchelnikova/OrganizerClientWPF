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

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text == "1" && passwordBox.Password == "1")
            {
                FirstChoice_Window firstChoice_Window = new FirstChoice_Window(loginBox.Text);
                firstChoice_Window.Show();
                //DTO.User.Login = loginBox.Text;
                this.Close();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
