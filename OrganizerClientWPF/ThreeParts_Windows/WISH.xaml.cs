using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MahApps.Metro.Controls;
using DALOrganizerClientWPF;
using OrganizerClientWPF.DTO;
using OrganizerClientWPF.Converters;
using System;
using System.Globalization;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for WISH.xaml
    /// </summary>
    public partial class WISH : MetroWindow
    {
        private readonly DataDAL _dal = new DataDAL();
        public User CurrentUser { get; } = new User();

        public WISH (User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            Title.Text = CurrentUser.Login.ToString().ToUpper() + "'s Wish-List";

            Binding binding = new Binding
            {
                Source = _dal.GetWishTypes()
            };
            Type.SetBinding(ComboBox.ItemsSourceProperty, binding);
        }
        private void See_All_Wishes_Click(object sender, RoutedEventArgs e)
        {
            Wish_Grid.Visibility = Visibility.Visible;
            Diary_Text.Visibility = Visibility.Hidden;
            left_grid.Visibility = Visibility.Hidden;
            Binding binding = new Binding();

            if (Converter_Profit_Expence.DAL_to_WPF_List(_dal.Get_All_Wishes(CurrentUser.Login)) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(_dal.Get_All_Wishes(CurrentUser.Login));
                Wish_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
            }
        }
        private void Add_New_Wish_Click(object sender, RoutedEventArgs e)
        {
            Wish_Grid.Visibility = Visibility.Hidden;
            left_grid.Visibility = Visibility.Visible;
            Diary_Text.Visibility = Visibility.Visible;
        }
        private void Save_Note_Click(object sender, RoutedEventArgs e)
        {
            var result = Decimal.TryParse(Sum.Text, NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number);
            if ( Type.Text != String.Empty && result == true)
            {
                Profit_ExpenceWPF_DTO new_wish = new Profit_ExpenceWPF_DTO()
                {
                    Date_ = Date.SelectedDate ?? DateTime.Now,
                    Sum = number,
                    Profit_Expance_Type = Type.Text.ToString(),
                    Description = Diary_Text.Text
                };
                _dal.Save_New_Wish(Converter_Profit_Expence.WPF_to_DAL(new_wish), Type.Text, CurrentUser.Login);
                Sum.Text = "";
                Diary_Text.Text = "";
            }
            else
            {
                Sum.Text = "Input DIGITALS, please!";
                Sum.FontSize = 16;
            }
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
            User_Account_Info user_Account = new User_Account_Info(CurrentUser);
            user_Account.Show();
            this.Close();
        }
        private void Delete_Note_Click(object sender, RoutedEventArgs e)
        {
            if (Wish_Grid.SelectedIndex > -1)
            {
                MessageBox.Show("A");
                var wish = Converter_Profit_Expence.WPF_to_DAL(Wish_Grid.Items[Wish_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO);
                _dal.Delete_Profit(wish, CurrentUser.Login);
            }
            See_All_Wishes_Click(sender, e);
        }
        private void Sum_GotFocus(object sender, RoutedEventArgs e)
        {
            Sum.Text = string.Empty;
        }
    }
}
