using DALOrganizerClientWPF;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class BUDGET : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var rnd = new Random();
        //    for (int i = 0; i < rnd.Next(5); i++)
        //    {
        //        Tester.Click += delegates[rnd.Next(delegates.Count)];
        //    }
        //}

        public static RoutedEventHandlerInfo[] GetRoutedEventHandlers(UIElement element, RoutedEvent routedEvent)
        {
            // Get the EventHandlersStore instance which holds event handlers for the specified element.
            // The EventHandlersStore class is declared as internal.
            var eventHandlersStoreProperty = typeof(UIElement).GetProperty(
                "EventHandlersStore", BindingFlags.Instance | BindingFlags.NonPublic);
            object eventHandlersStore = eventHandlersStoreProperty.GetValue(element, null);

            // Invoke the GetRoutedEventHandlers method on the EventHandlersStore instance 
            // for getting an array of the subscribed event handlers.
            var getRoutedEventHandlers = eventHandlersStore.GetType().GetMethod(
                "GetRoutedEventHandlers", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var routedEventHandlers = (RoutedEventHandlerInfo[])getRoutedEventHandlers.Invoke(
                eventHandlersStore, new object[] { routedEvent });

            return routedEventHandlers;
        }

        private void RemoveClickEvent(Button b)
        {
            var routedEventHandlers = GetRoutedEventHandlers(b, ButtonBase.ClickEvent);
            foreach (var routedEventHandler in routedEventHandlers)
                b.Click -= (RoutedEventHandler)routedEventHandler.Handler;
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    RemoveClickEvent(Tester);
        //    delegates.ForEach((item) => { if (delegates.IndexOf(item) % 2 == 0) Tester.Click += item; });
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    RemoveClickEvent(Tester);
        //    delegates.ForEach((item) => { if (delegates.IndexOf(item) % 2 != 0) Tester.Click += item; });
        //}

        public User CurrentUser { get; } = new User();
        List<RoutedEventHandler> delegates = new List<RoutedEventHandler>();
        List<Button> buttons = new List<Button>();
        public BUDGET(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();            
            title.Text = CurrentUser.Login.ToUpper() + "'s Budjet";
            List <List<RoutedEventHandler>> delegates_ = new List <List<RoutedEventHandler>>()
            {
                { Add_Click_Profits, Show_All_Profits_Click, Delete_Profit, Save_New_Profit_Click },
                { Add_Click_Expance, Show_All_Expance_Click, Delete_Expence, Save_New_Expence_Click }
            };
            delegates = delegates_;
            List<Button> buttons_ = new List<Button>
            {
                add, show_all, delete, save_add
            };
            buttons = buttons_;
        }
       
        //open Profits CRUD
        private void Profits_Click(object sender, RoutedEventArgs e)
        {
            stack_panelPlan.Visibility = Visibility.Collapsed;
            Change_Window();
            add.Content = "Add Profit";
            show_all.Content = "Show all Profits";
            delete.Content = "Delete Profit";
            foreach (Button item in buttons)
            {
                RemoveClickEvent(item);
                delegates.ForEach((itemd) => { if (delegates.IndexOf(itemd) % 2 == 0) item.Click += itemd; });
            }


                //add.Click += Add_Click_Profits;
                //save_add.Click += Save_New_Profit_Click;                
                //show_all.Click += Show_All_Profits_Click;
                //delete.Click += Delete_Profit;

            }
        private void Show_All_Profits_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;
            var profits_list = _dalCl.Get_All_Profits(CurrentUser.Login);
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
            }
        }
        public void Add_Click_Profits(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;
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
            stack_panelPlan.Visibility = Visibility.Collapsed;
            Change_Window();
            add.Content = "Add Expance";
            show_all.Content = "Show all Expences";
            delete.Content = "Delete Expence";
         
            add.Click += Add_Click_Expance;
            save_add.Click += Save_New_Expence_Click;
            show_all.Click += Show_All_Expance_Click;
            delete.Click += Delete_Expence;
        }
        private void Add_Click_Expance(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;
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
            edit.Visibility = Visibility.Visible;         
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
            // add.Click += Plans_Click;
        }
        
        //Open Reports
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;
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
