using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MahApps.Metro.Controls;
using DALOrganizerClientWPF;
using OrganizerClientWPF.DTO;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class DIARY : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();
        public DIARY()
        {
            InitializeComponent();

            //Title by login           
            title.Text = DTO.User.Login.ToString().ToUpper() + "'s Dairy";
        }

        ///all notes by dates
        private void select_date(object sender, RoutedEventArgs e)
        {
           
            //    var dairies = ctx.Dayries.Where(note => note.User.Id == MainWindow.Global.userID).ToList();
            //    dairies = dairies.Where(day => (day.Date_ >= Calendar.SelectedDate.Value) && (day.Date_ <= Calendar2.SelectedDate.Value)).ToList();
            //    Binding binding = new Binding();
            //    binding.Source = dairies;
            //    dairy_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
            

        }

        ///see all notes
        private void See_All_Notes_Click(object sender, RoutedEventArgs e)
        {

            add.Visibility = Visibility.Hidden;
            period.Visibility = Visibility.Visible;
            Calendar.Visibility = Visibility.Visible;
            Calendar2.Visibility = Visibility.Visible;
            add.Visibility = Visibility.Hidden;
            delete.Visibility = Visibility.Visible;

            //       
            var dairy_list = _dalCl.Show_All_Notes(DTO.User.Login);
            Diary_Text.Visibility = Visibility.Hidden;
            dairy_Grid.Visibility = Visibility.Visible;
            Binding binding = new Binding();
            binding.Source = dairy_list;
            dairy_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
           

        }
        ///open form to add new note
        private void Write_New_Note_Click(object sender, RoutedEventArgs e)
        {
            Diary_Text.Visibility = Visibility.Visible;
            add.Visibility = Visibility.Visible;
            Calendar.Visibility = Visibility.Hidden;
            Calendar2.Visibility = Visibility.Hidden;
            period.Visibility = Visibility.Hidden;
            delete.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Visible;
        }

        ///add to base new note
        private void Add_Note_Click(object sender, RoutedEventArgs e)
        {
            _dalCl.Add_Note(Diary_Text.Text, User.Login);           
             Diary_Text.Text = null;
        }

        private void Delete_Note_Click(object sender, RoutedEventArgs e)
        {
            //if (dairy_Grid.SelectedIndex > -1)
            //{
            //    string note_for_delete = (dairy_Grid.Items[dairy_Grid.SelectedIndex] as DiaryWPF_DTO).Text.ToString();

            //    _dalCl.Delete_Note(note_for_delete);
            //}           
        }




        //go to budjet
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BUDGET budjet = new BUDGET();
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
