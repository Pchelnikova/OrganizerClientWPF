using MahApps.Metro.Controls;
using System.Windows;


namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //START 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }
    }
}

