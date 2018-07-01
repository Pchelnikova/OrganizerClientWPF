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
    /// Interaction logic for WISH.xaml
    /// </summary>
    public partial class WISH : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();
        public User CurrentUser { get; } = new User();

        public WISH (User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            title.Text = CurrentUser.Login.ToString().ToUpper() + "'s Wish-List";

        }

        private void See_All_Wishes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_New_Wish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Note_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DIARY diary = new DIARY(CurrentUser);
            diary.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BUDGET budget = new BUDGET(CurrentUser);
            budget.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Note_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void dairy_Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
