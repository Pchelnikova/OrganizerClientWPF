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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FirstChoice_Window : MetroWindow
    {
        public FirstChoice_Window()
        {
            InitializeComponent();
        }

        //DAIRY begin
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DAIRY dairy_Window = new DAIRY();
            dairy_Window.Show();
            this.Close();
        }
        //Budjet begin
        private void Budjet_Click(object sender, RoutedEventArgs e)
        {
            BUDGET budjet_Window = new BUDGET();
            budjet_Window.Show();
            this.Close();
        }
        //Wish-List
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }
    }
}
