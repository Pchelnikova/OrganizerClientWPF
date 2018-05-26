﻿using DALOrganizerClientWPF;
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

        public  enum ThreeButton { PROFIT, EXPENCE, PLAN };    

        public User CurrentUser { get; } = new User();
        List<List<RoutedEventHandler>> delegates = new List<List<RoutedEventHandler>>();
        List<Button> buttons = new List<Button>();
        public BUDGET(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();            
            title.Text = CurrentUser.Login.ToUpper() + "'s Budjet";
            // Create delegats for change main buttons Profit/Expence/Plans
            List <RoutedEventHandler> delegates_Profits = new List <RoutedEventHandler>()
            {
                 Add_Click_Profits, Show_All_Profits_Click, Delete_Profit, Save_New_Profit_Click                
            };
            List<RoutedEventHandler> delegates_Expence = new List<RoutedEventHandler>()
            {
                 Add_Click_Expance, Show_All_Expance_Click, Delete_Expence, Save_New_Expence_Click
            };
            List<RoutedEventHandler> delegates_Plans = new List<RoutedEventHandler>()
            {
                 Add_Click_Plan, Show_All_Plans_Click, Delete_Plan, Save_New_Plan_Click
            };
            List<List<RoutedEventHandler>> delegates__ = new List<List<RoutedEventHandler>>();
            delegates__.Add(delegates_Profits);
            delegates__.Add(delegates_Expence);
            delegates__.Add(delegates_Plans);
            delegates = delegates__;
            //buttons, which will change by delegats
            List<Button> buttons_ = new List<Button>
            {
                add, show_all, delete, save_add
            };
            buttons = buttons_;
            //first values of buttons (Profits)
            for (int i = 0; i < buttons.Count; i++)
            {
               
                buttons[i].Click += delegates[0].FirstOrDefault(item => (delegates[0].IndexOf(item) == i));
            }
        }

       
      
        //open Profits CRUD
        #region
        private void Profits_Click(object sender, RoutedEventArgs e)
        {
           
            Change_Window();
            add.Content = "Add Profit";
            show_all.Content = "Show all Profits";
            delete.Content = "Delete Profit";           
            Choise_Buttons((int)ThreeButton.PROFIT);
           
            }
       
        private void Show_All_Profits_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            save_add.Visibility = Visibility.Collapsed;
            //result.Visibility = Visibility.Visible;
            //result_text.Visibility = Visibility.Visible;
            //balance.Visibility = Visibility.Visible;
            //balance_text.Visibility = Visibility.Visible;
            budget_grid2.Visibility = Visibility.Visible;
            var profits_list = _dalCl.Get_All_Profits(CurrentUser.Login);
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
            }
            Show_Total_Sum_Profits();
            Show_Balance();
        }
        public void Add_Click_Profits(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            save_add.Visibility = Visibility.Visible;
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;
            budget_grid2.Visibility = Visibility.Collapsed;

            Binding binding = new Binding
            {
                Source = _dalCl.GetProfitsTypes()
            };
            type.SetBinding(ComboBox.ItemsSourceProperty, binding);
           
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
        #endregion

        ///open Expances CRUD
        #region
        private void Expances_Click(object sender, RoutedEventArgs e)
        {
          
            Change_Window();
            add.Content = "Add Expance";
            show_all.Content = "Show all Expences";
            delete.Content = "Delete Expence";
            Choise_Buttons((int)ThreeButton.EXPENCE);

            
        }
        private void Add_Click_Expance(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            save_add.Visibility = Visibility.Visible;
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;
            budget_grid2.Visibility = Visibility.Collapsed;
            Binding binding = new Binding
            {
                Source = _dalCl.GetExpanceTypes()
            };
            type.SetBinding(ComboBox.ItemsSourceProperty, binding);
          
            save_add.Content = "SAVE";
        }                  
        private void Show_All_Expance_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            save_add.Visibility = Visibility.Collapsed;
            budget_grid2.Visibility = Visibility.Visible;
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Expance(CurrentUser.Login).ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Expance(CurrentUser.Login).ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
                delete.Content = "DELETE";
                delete.Visibility = Visibility.Visible;
            }
            Show_Total_Sum_Expences();
            Show_Balance();
            
        }
        private void Delete_Expence (object sender, RoutedEventArgs e)
        {           
                if (budget_Grid.SelectedIndex > -1)
                {          
                    _dalCl.Delete_Expence(Converter_Profit_Expence.WPF_to_DAL(budget_Grid.Items[budget_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO), CurrentUser.Login);
                }
            Show_All_Expance_Click(sender, e);
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
        #endregion

        //Plans CRUD
        #region
        private void Plans_Click(object sender, RoutedEventArgs e)
        {
            Change_Window();
            add.Content = "Add Plan ";
            show_all.Content = "Show all Plans";
            delete.Content = "Delete Plan";
            Choise_Buttons((int)ThreeButton.PLAN);
        }
        private void Add_Click_Plan(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            save_add.Visibility = Visibility.Visible;
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;
            budget_grid2.Visibility = Visibility.Collapsed;
            Binding binding = new Binding
            {
                Source = _dalCl.GetExpanceTypes()
            };
            type.SetBinding(ComboBox.ItemsSourceProperty, binding);
            
            save_add.Content = "SAVE";
        }
        private void Show_All_Plans_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            save_add.Visibility = Visibility.Collapsed;
            //result.Visibility = Visibility.Visible;
            //result_text.Visibility = Visibility.Visible;
            //balance.Visibility = Visibility.Visible;
            //balance_text.Visibility = Visibility.Visible;
            budget_grid2.Visibility = Visibility.Visible;
            Binding binding = new Binding();
            if (Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Plans(CurrentUser.Login).ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(_dalCl.Get_All_Plans(CurrentUser.Login).ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
                delete.Content = "DELETE";
                delete.Visibility = Visibility.Visible;
            }
            Show_Total_Sum_Plans();
            Show_Balance();

        }
        private void Delete_Plan(object sender, RoutedEventArgs e)
        {
            if (budget_Grid.SelectedIndex > -1)
            {
                _dalCl.Delete_Plan(Converter_Profit_Expence.WPF_to_DAL(budget_Grid.Items[budget_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO), CurrentUser.Login);
            }
            Show_All_Plans_Click(sender, e);
        }
        private void Save_New_Plan_Click(object sender, RoutedEventArgs e)
        {
            if (type.Text != null && description.Text != null)
            {
                if (Decimal.TryParse(sum.Text, System.Globalization.NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number) == true)
                {
                    Profit_ExpenceWPF_DTO new_plan = new Profit_ExpenceWPF_DTO()
                    {
                        Date_ = date.SelectedDate.Value,
                        Sum = number,
                        Profit_Expance_Type = type.Text.ToString(),
                        Description = description.Text
                    };
                    _dalCl.Save_New_Plan(Converter_Profit_Expence.WPF_to_DAL(new_plan), type.Text.ToString(), CurrentUser.Login);
                    sum.Text = "";
                    description.Text = "";
                }
            }
        }
        #endregion

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

        //HELPERS
        #region
        //Change window
        private void Change_Window()
        {
            add.Visibility = Visibility.Visible;
            show_all.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Hidden;
            border_add.Visibility = Visibility.Visible;
            budget_Grid.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;
            delete.Visibility = Visibility.Hidden;
        }

        //Helper for Choice_Buttons
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
        //Helper for Choice_Buttons
        private void RemoveClickEvent(Button b)
        {
            var routedEventHandlers = GetRoutedEventHandlers(b, ButtonBase.ClickEvent);
            foreach (var routedEventHandler in routedEventHandlers)
                b.Click -= (RoutedEventHandler)routedEventHandler.Handler;
        }       
        //Change methods for buttons by main buttons Profit/Expence/Plan
        private void Choise_Buttons(int number_of_button)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                RemoveClickEvent(buttons[i]);
                buttons[i].Click += delegates[number_of_button].FirstOrDefault(item => (delegates[number_of_button].IndexOf(item) == i));
            }
        }
        
        //Get Total Sum
        private void Show_Total_Sum_Profits ()
        {
            total_sum_text.Text = _dalCl.Get_Total_Profits().ToString();          
        }
        private void Show_Total_Sum_Expences()
        {            
             total_sum_text.Text = _dalCl.Get_Total_Expences().ToString();
        }
        private void Show_Total_Sum_Plans()
        {
            total_sum_text.Text = _dalCl.Get_Total_Plans().ToString();
        }
        private void Show_Balance()
        {
            balance_text.Text = _dalCl.Get_Balance().ToString();
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

        #endregion

    }
}
