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
using LiveCharts;
using LiveCharts.Wpf;
namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class BUDGET : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();
        private Dictionary<string, decimal> _dictionaryExpense = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> _dictionaryProfits = new Dictionary<string, decimal>();
        public enum ThreeButton { PROFIT, EXPENCE, PLAN, REPORTS };
   
        public User CurrentUser { get; } = new User();
        List<List<RoutedEventHandler>> delegates = new List<List<RoutedEventHandler>>();
        List<Button> buttons = new List<Button>();
        public BUDGET(User currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
            title.Text = CurrentUser.Login.ToUpper() + "'s Budjet";
            // Create delegats for change main buttons Profit/Expence/Plans
            List<RoutedEventHandler> delegates_Profits = new List<RoutedEventHandler>()
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
            List<RoutedEventHandler> delegates_Reports = new List<RoutedEventHandler>()
            {
                 Chart_Profits_click, Chart_Expense_Click, Add_Click_Expance, Save_New_Plan_Click
            };
            List<List<RoutedEventHandler>> delegates__ = new List<List<RoutedEventHandler>>();
            delegates__.Add(delegates_Profits);
            delegates__.Add(delegates_Expence);
            delegates__.Add(delegates_Plans);
            delegates__.Add(delegates_Reports);
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
        //!!!!!!
        private void Chart_Profits_click(object sender, RoutedEventArgs e)
        {
            Chart.Series.Clear();
            _dictionaryProfits.Clear();
            Chart.Series.Clear();
            Chart.Visibility = Visibility.Visible;
            FillChart_Profits(_dictionaryProfits);
            ViewChart(_dictionaryProfits);
        }
        private void Chart_Expense_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series.Clear();
            _dictionaryExpense.Clear();
            Chart.Series.Clear();
            Chart.Visibility = Visibility.Visible;
            FillChart_Expenses(_dictionaryExpense);
            ViewChart(_dictionaryExpense);
        }
        //!!!!!!!!!!



        #region  Profits CRUD 
        private void Profits_Click(object sender, RoutedEventArgs e)
        {

            Change_Window();
            add.Content = "Add Profit";
            show_all.Content = "Show all Profits";
            delete.Content = "Delete Profit";
            Choise_Buttons((int)ThreeButton.PROFIT);
            Chart.Visibility = Visibility.Collapsed;

        }

        private void Show_All_Profits_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            save_add.Visibility = Visibility.Collapsed;

            budget_grid2.Visibility = Visibility.Visible;
            List <Profit_ExpenceDAL> profits_list;
            Binding binding = new Binding();
            if (_dalCl.GetTypeUser(CurrentUser.Login))
            {
               profits_list = _dalCl.Get_All_Profits();
            }
            else
            {
                profits_list = _dalCl.Get_All_Profits(CurrentUser.Login);
            }
            if (Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList()) != null)
            {
                binding.Source = Converter_Profit_Expence.DAL_to_WPF_List(profits_list.ToList());
                budget_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
                budget_Grid.Visibility = Visibility.Visible;
            }
            Show_Total_Sum_Profits();
            Show_Balance();
            total_sum.Visibility = Visibility.Visible;

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
            var result = Decimal.TryParse(sum.Text, NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number);
            if (type.Text != String.Empty && result == true)
            {
                Profit_ExpenceWPF_DTO new_profit = new Profit_ExpenceWPF_DTO()
                {
                    Date_ = date.SelectedDate ?? DateTime.Now,
                    Sum = number,
                    Profit_Expance_Type = type.Text.ToString(),
                    Description = description.Text ?? ""
                };
                _dalCl.Save_New_Profit(Converter_Profit_Expence.WPF_to_DAL(new_profit), type.Text.ToString(), CurrentUser.Login);
                sum.Text = "";
                description.Text = "";
            }
            else if (result != true)
            {
                sum.Text = "Input DIGITALS, please!";
                sum.FontSize = 16;
            }
            else if (type.Text == String.Empty)
            {

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
            Chart.Visibility = Visibility.Collapsed;
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
        private void Show_All_Expance_Click(object sender, RoutedEventArgs e) //////////////////////////////// !!!
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

        private void Delete_Expence(object sender, RoutedEventArgs e)
        {
            if (budget_Grid.SelectedIndex > -1)
            {
                _dalCl.Delete_Expence(Converter_Profit_Expence.WPF_to_DAL(budget_Grid.Items[budget_Grid.SelectedIndex] as Profit_ExpenceWPF_DTO), CurrentUser.Login);
            }
            Show_All_Expance_Click(sender, e);
        }
        private void Save_New_Expence_Click(object sender, RoutedEventArgs e)
        {
            var result = Decimal.TryParse(sum.Text, NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number);
            if (type.Text != String.Empty && result == true)
            {
                Profit_ExpenceWPF_DTO new_expence = new Profit_ExpenceWPF_DTO()
                {
                    Date_ = date.SelectedDate ?? DateTime.Now,
                    Sum = number,
                    Profit_Expance_Type = type.Text.ToString(),
                    Description = description.Text
                };
                _dalCl.Save_New_Expence(Converter_Profit_Expence.WPF_to_DAL(new_expence), type.Text.ToString(), CurrentUser.Login);
                sum.Text = "";
                description.Text = "";
            }
            else if (result == false)
            {
                sum.Text = "Input DIGITALS, please!";
                sum.FontSize = 16;
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
            Chart.Visibility = Visibility.Collapsed;
        }
        private void Add_Click_Plan(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            save_add.Visibility = Visibility.Visible;
            delete.Visibility = Visibility.Hidden;
            budget_Grid.Visibility = Visibility.Hidden;
            budget_grid2.Visibility = Visibility.Collapsed;
            date.Visibility = Visibility.Collapsed;
            date_plan.Visibility = Visibility.Visible;
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
            var result = Decimal.TryParse(sum.Text, NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("uk-UA"), out decimal number);
            if (type.Text != String.Empty && result == true)
            {
                Profit_ExpenceWPF_DTO new_plan = new Profit_ExpenceWPF_DTO()
                {
                    Date_ = date_plan.SelectedDate ?? DateTime.Now,
                    Sum = number,
                    Profit_Expance_Type = type.Text.ToString(),
                    Description = description.Text
                };
                _dalCl.Save_New_Plan(Converter_Profit_Expence.WPF_to_DAL(new_plan), type.Text.ToString(), CurrentUser.Login);
                sum.Text = "";
                description.Text = "";
            }
            else if (result == false)
            {
                sum.Text = "Input DIGITALS, please!";
                sum.FontSize = 16;
            }
        }

        /// <summary>
        ///   Validation for date of plan-expence. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Selected_Date_Plan(object sender, RoutedEventArgs e)
        {
            if (date_plan.SelectedDate.Value.Month == DateTime.Now.Month)
            {
                description.Foreground = Brushes.Red;
                description.Text = "Date must be later than the current month!!!";
                type.Visibility = Visibility.Collapsed;
                sum.Visibility = Visibility.Collapsed;
            }
            else
            {
                description.Foreground = Brushes.Black;
                description.Text = "";
                type.Visibility = Visibility.Visible;
                sum.Visibility = Visibility.Visible;
            }

        }
        #endregion

        //Open Reports
        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            Change_Window();
            //change button "add" and "show_all"
            add.Content = "PROFITS CHART";
            show_all.Content = "EXPANCE CHART";
           
            add.Visibility = Visibility.Visible;
            show_all.Visibility = Visibility.Visible;
            Chart.Visibility = Visibility.Visible;
            Choise_Buttons((int)ThreeButton.REPORTS);
        }
        #region Charts 
        //методи 355 і 375 злити в один метод 
        public void FillChart_Profits(Dictionary<string, decimal> dic)
        {
            decimal sum = 0;
            List<string> name = new List<string>();
            foreach (var item in _dalCl.Get_Name_byType_forChart_Profits(CurrentUser.Login))
            {
                name.Add(item);
            }
            for (int i = 0; i < name.Count; i++)
            {
                foreach (var s in _dalCl.Get_Sum_byType_forChart_Profits(CurrentUser.Login, name[i]))
                {
                    sum += s;
                }
                dic.Add(name[i], sum);
                sum = 0;
            }
        }
        public void FillChart_Expenses(Dictionary<string, decimal> dic)
        {
            decimal sum = 0;
            List<string> name = new List<string>();
            foreach (var item in _dalCl.Get_Name_byType_forChart_Expense(CurrentUser.Login))
            {
                name.Add(item);
            }
            for (int i = 0; i < name.Count; i++)
            {
                foreach (var s in _dalCl.Get_Sum_byType_forChart_Expense(CurrentUser.Login, name[i]))
                {
                    sum += s;
                }
                dic.Add(name[i], sum);
                sum = 0;
            }
        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        private void ViewChart(Dictionary<string, decimal> dic)
        {
            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            DataContext = this;
            foreach (var item in dic)
            {
                PieSeries p = new PieSeries()
                {
                    Values = new ChartValues<Decimal> { item.Value },
                    Title = item.Key,
                    DataLabels = true,
                    LabelPoint = PointLabel,
                    FontSize = 12
                };
                Chart.Series.Add(p);
            }

        }
        
        #endregion
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
            WISH wish_Window = new WISH(CurrentUser);
            wish_Window.Show();
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
            total_sum_text.Text = String.Empty;
            total_sum_text.Visibility = Visibility.Collapsed;
            balance_text.Text = String.Empty;
            balance_text.Visibility = Visibility.Collapsed;
            total_sum.Visibility = Visibility.Collapsed;
            balance.Visibility = Visibility.Collapsed;
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
        private void Show_Total_Sum_Profits()
        {
            total_sum_text.Visibility = Visibility.Visible;
            total_sum.Visibility = Visibility.Visible;
            total_sum_text.Text = _dalCl.Get_Total_Profits().ToString();
        }
        private void Show_Total_Sum_Expences()
        {
            total_sum_text.Visibility = Visibility.Visible;
            total_sum.Visibility = Visibility.Visible;
            total_sum_text.Text = _dalCl.Get_Total_Expences().ToString();
        }
        private void Show_Total_Sum_Plans()
        {
            total_sum_text.Visibility = Visibility.Visible;
            total_sum.Visibility = Visibility.Visible;
            total_sum_text.Text = _dalCl.Get_Total_Plans().ToString();
        }
        private void Show_Balance()
        {
            balance_text.Visibility = Visibility.Visible;
            balance.Visibility = Visibility.Visible;
            balance_text.Text = _dalCl.Get_Balance().ToString();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            User_Account_Info user_Account = new User_Account_Info(CurrentUser);
            user_Account.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        // public List<string, decimal> Get_Sum_byType_forChart_Profits()
        // {
        //     return _dalCl.Get_Sum_byType_forChart_Profits();
        // }

        #endregion

       
    }
}
