using DALOrganizerClientWPF;
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
using OrganizerClientWPF.DTO;
using System.Globalization;
using DALOrganizerClientWPF.DTO;
using OrganizerClientWPF.Converters;
using System.Reflection;
using System.Windows.Controls.Primitives;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class BUDGET : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();
       
    

        public User CurrentUser { get; } = new User();
        public BUDGET(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();            
            title.Text = CurrentUser.Login.ToUpper() + "'s Budjet";        
           
        }

        //open Profits CRUD
        private void Profits_Click(object sender, RoutedEventArgs e)
        {
                Change_Window();
            add.Content = "Add Profit";
            show_all.Content = "Show all Profits";
            delete.Content = "Delete Profit";

            add.Click -= Add_Click_Expance;
            add.Click += Add_Click_Profits;
            save_add.Click -= Save_New_Expence_Click;
            save_add.Click += Save_New_Profit_Click;
            show_all.Click -= Show_All_Expance_Click;
            show_all.Click += Show_All_Profits_Click;
            delete.Click -= Delete_Expence;
            delete.Click += Delete_Profit;

        }
    
        private void Show_All_Profits_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
        
            var profits_list = _dalCl.Get_All_Profits(CurrentUser.Login);
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
            }

        }
        private void Add_Click_Profits(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
         
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;

            Binding binding = new Binding
            {
                Source = _dalCl.GetProfitsTypes()
            };
            type.SetBinding(ComboBox.ItemsSourceProperty, binding);
            save_add.Click -= Save_New_Expence_Click;
            save_add.Click += Save_New_Profit_Click;
            save_add.Content = "SAVE";

        }
        private void Save_New_Profit_Click(object sender, RoutedEventArgs e)
        {
            if (type.Text != null && description.Text != null)
            {
                if (Decimal.TryParse(sum.Text, System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number))
                {
                    Profit_ExpenceWPF_DTO new_profit = new Profit_ExpenceWPF_DTO()
                    {
                        Date_ = date.SelectedDate.Value == null ? System.DateTime.Now : date.SelectedDate.Value,
                        Sum = number,
                        Profit_Expance_Type = type.Text.ToString(),
                        Description = description.Text
                    };
                    _dalCl.Save_New_Profit(Converter_Profit_Expence.WPF_to_DAL(new_profit), type.Text.ToString(), CurrentUser.Login);
                    sum.Text = "";
                    description.Text = "";
                }
            }
        }       
        private void Delete_Profit(object sender, RoutedEventArgs e)
        {
            if (budget_Grid.SelectedIndex > -1)
            {                  
                var profit = Converter_Profit_Expence.WPF_to_DAL(budget_Grid.Items[budget_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO);

                _dalCl.Delete_Profit(profit, CurrentUser.Login);                
            }
            Show_All_Profits_Click(sender, e);
        }

        ///open Expances CRUD
        private void Expances_Click(object sender, RoutedEventArgs e)
        {
            Change_Window();
            add.Content = "Add Expance";
            show_all.Content = "Show all Expences";
            delete.Content = "Delete Expence";
            add.Click -= Add_Click_Profits;
            add.Click += Add_Click_Expance;
            save_add.Click -= Save_New_Profit_Click;
            save_add.Click += Save_New_Expence_Click;
            show_all.Click -= Show_All_Profits_Click;
            show_all.Click += Show_All_Expance_Click;
            delete.Click -= Delete_Profit;
            delete.Click += Delete_Expence;
        }
        private void Add_Click_Expance(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;           
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;
            Binding binding = new Binding
            {
                Source = _dalCl.GetExpanceTypes()
            };
            type.SetBinding(ComboBox.ItemsSourceProperty, binding);
            save_add.Click -= Save_New_Profit_Click;
            save_add.Click += Save_New_Expence_Click;
            save_add.Content = "SAVE";
        }                  
        private void Show_All_Expance_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
                   
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Expance(CurrentUser.Login).ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Expance(CurrentUser.Login).ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
                delete.Content = "DELETE";
                delete.Visibility = Visibility.Visible;
            }
            Show_All_Expance_Click(sender, e);
        }
        private void Delete_Expence (object sender, RoutedEventArgs e)
        {           
                if (budget_Grid.SelectedIndex > -1)
                {          
                    _dalCl.Delete_Expence(Converter_Profit_Expence.WPF_to_DAL(budget_Grid.Items[budget_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO), CurrentUser.Login);
                }          
        }
        private void Save_New_Expence_Click(object sender, RoutedEventArgs e)
        {
            if (type.Text != null && description.Text != null)
            {
                if (Decimal.TryParse(sum.Text, System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number) == true)
                {
                    Profit_ExpenceWPF_DTO new_expence = new Profit_ExpenceWPF_DTO()
                    {
                        Date_ = date.SelectedDate.Value,
                        Sum = number,
                        Profit_Expance_Type = type.Text.ToString(),
                        Description = description.Text
                    };
                    _dalCl.Save_New_Expence(Converter_Profit_Expence.WPF_to_DAL(new_expence), type.Text.ToString(), CurrentUser.Login);
                    sum.Text = "";
                    description.Text = "";
                }
            }
        }

        //Open Plans
        private void Plans_Click(object sender, RoutedEventArgs e)
        {
            Change_Window();
          
        }
        //Open Reports
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
           
            delete.Visibility = Visibility.Hidden;
            //change button "add" and "show_all"
            add.Content = "PROFITS";
            show_all.Content = "EXPANCE";
        }
      

        // Open Dairy
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
             DIARY diary = new DIARY(CurrentUser);
            diary.Show();
            this.Close();

        }
        //Wish-List
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }

        //change window
        private void Change_Window()
        {
            add.Visibility = Visibility.Visible;
            show_all.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Hidden;
            border_add.Visibility = Visibility.Visible;
            budget_Grid.Visibility = Visibility.Hidden;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            User_Account_Info user_Account = new User_Account_Info(CurrentUser);
            user_Account.Show();
            //this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
       
    }
}
