using System.Windows;
using MahApps.Metro.Controls;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class FirstWindow : MetroWindow
    {

        public FirstWindow()
        {
            InitializeComponent();
        }
        //глобальная змінна для ІД
        public static class Global
        {
            public static int userID { get; set; }
        }

        //Старт. Авторизація
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }
    }
}

