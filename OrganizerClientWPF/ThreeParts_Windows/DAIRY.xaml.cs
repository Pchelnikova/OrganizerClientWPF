using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MahApps.Metro.Controls;


namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class DAIRY : MetroWindow
    {
        public DAIRY()
        {
            InitializeComponent();
            //Title by login
            using (var ctx = new DAL.Model())
            {
                var users = ctx.Users.ToList();
                var user = users.FirstOrDefault(item => item.Id == MainWindow.Global.userID);
                string user_ = user.Login.ToUpper();
                title.Text = user_ + "'s Dairy";
            }
        }

        ///all notes by dates
        private void select_date(object sender, RoutedEventArgs e)
        {
            using (var ctx = new DAL.Model())
            {
                var dairies = ctx.Dayries.Where(note => note.User.Id == MainWindow.Global.userID).ToList();
                dairies = dairies.Where(day => (day.Date_ >= Calendar.SelectedDate.Value) && (day.Date_ <= Calendar2.SelectedDate.Value)).ToList();
                Binding binding = new Binding();
                binding.Source = dairies;
                dairy_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
            }

        }

        ///see all dairy by id
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            add.Visibility = Visibility.Hidden;
            period.Visibility = Visibility.Visible;
            Calendar.Visibility = Visibility.Visible;
            Calendar2.Visibility = Visibility.Visible;

            using (var ctx = new DAL.Model())
            {
                var dairies = ctx.Dayries.Where(note => note.User.Id == MainWindow.Global.userID).ToList();
                var dairy_list = dairies.Select(item => new { item.Date_, item.Text });
                Dairy_Text.Visibility = Visibility.Hidden;
                dairy_Grid.Visibility = Visibility.Visible;
                Binding binding = new Binding();
                binding.Source = dairy_list;
                dairy_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
            }

        }

        ///add to base new note
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            using (var ctx = new DAL.Model())
            {
                var dairies = ctx.Dayries.ToList();
                var users = ctx.Users.ToList();
                var dairy = dairies.Where(item => item.Id == MainWindow.Global.userID);
                if (dairy != null)
                {
                    DAL.Model_Classes.Dairy new_note = new DAL.Model_Classes.Dairy
                    {
                        Date_ = System.DateTime.Now,
                        Text = Dairy_Text.Text,
                        User = users.FirstOrDefault(item => item.Id == MainWindow.Global.userID)
                    };
                    ctx.Dayries.Add(new_note);
                    ctx.SaveChanges();
                }
            }
            Dairy_Text.Text = null;
        }
        ///open form to add new note
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dairy_Text.Visibility = Visibility.Visible;
            add.Visibility = Visibility.Visible;
            Calendar.Visibility = Visibility.Hidden;
            Calendar2.Visibility = Visibility.Hidden;
            period.Visibility = Visibility.Hidden;
        }


        //go to budjet
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BUDJET budjet = new BUDJET();
            budjet.Show();
            this.Close();
        }
        //Wish-List
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            User_Account_Info user_Account = new User_Account_Info();
            user_Account.Show();
            this.Close();
        }
    }
}
