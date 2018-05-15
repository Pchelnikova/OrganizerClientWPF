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

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class BUDGET : MetroWindow
    {
        public BUDGET()
        {
            InitializeComponent();            
            title.Text = DTO.User.Login.ToString().ToUpper() + "'s Budjet";

        }
        ////open Profits
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //    Change_Window();
            //    add.Click += ProfitAdd;
            //    show_all.Click += Show_All_Expance_Click;
            //}
            ////open Expances
            //private void Button_Click_1(object sender, RoutedEventArgs e)
            //{
            //    Change_Window();
            //    add.Click += ExpanceAdd;
        }
        //Open Plans
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Change_Window();

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
        //button ADD (Profits)
        private void ProfitAdd(object sender, RoutedEventArgs e)
        {
            //    var prof_type = _ctx.Profit_Types.Select(item => item.Name).ToList();
            //    Binding binding = new Binding
            //    {
            //        Source = prof_type
            //    };
            //    type.SetBinding(ComboBox.ItemsSourceProperty, binding);
        }

        ////button ADD (Expance)
        private void ExpanceAdd(object sender, RoutedEventArgs e)
        {
            //    var expance_type = _ctx.Expances_Types.Select(item => item.Name).ToList();
            //    Binding binding = new Binding
            //    {
            //        Source = expance_type
            //    };
            //    type.SetBinding(ComboBox.ItemsSourceProperty, binding);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            border_add.Visibility = Visibility.Hidden;
            edit.Visibility = Visibility.Hidden;
            delete.Visibility = Visibility.Hidden;
            budjet_Grid.Visibility = Visibility.Hidden;

        }
        ////SHOW ALL
        private void Show_All_Profits_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;
            //Bind_To_DataGrid_Profits();
        }
        private void Show_All_Expance_Click(object sender, RoutedEventArgs e)
        {
            delete.Visibility = Visibility.Visible;
            edit.Visibility = Visibility.Visible;
           // Bind_To_DataGrid_Expance();
        }
        //ADD  new budget or expance or plan
        private void add_profit(object sender, RoutedEventArgs e)
        {

            //    {
            //        using (var ctx = new Model())
            //        {
            //            var profits = ctx.Profits.ToList();
            //            var users = ctx.Users.ToList();
            //            var profit_type = ctx.Profit_Types.ToList();

            //            int pars;

            //            if (Int32.TryParse(sum.Text, out pars))
            //            {
            //                int sum_ = Int32.Parse(sum.Text);

            //                Profit new_profit = new Profit
            //                {
            //                    Date_ = date.SelectedDate.Value == null ? System.DateTime.Now : date.SelectedDate.Value,
            //                    Sum = sum_,
            //                    Profit_Type = profit_type.FirstOrDefault(item => item.Name == type.Text),
            //                    Description = description.Text,
            //                    User = users.FirstOrDefault(item => item.Id == MainWindow.Global.userID)
            //                };
            //                ctx.Profits.Add(new_profit);
            //                ctx.SaveChanges();
            //            }
            //        }
            //    }

            //    {
            //        using (var ctx = new Model())
            //        {
            //            var expances = ctx.Expences.ToList();
            //            var users = ctx.Users.ToList();
            //            var expance_type = ctx.Expances_Types.ToList();
            //            var expance = expances.Where(item => item.Id == MainWindow.Global.userID);
            //            int pars;

            //            if (Int32.TryParse(sum.Text, out pars))
            //            {
            //                int sum_ = Int32.Parse(sum.Text);

            //                Expance new_expance = new Expance
            //                {
            //                    Date_ = date.SelectedDate.Value == null ? System.DateTime.Now : date.SelectedDate.Value,
            //                    Sum = sum_,
            //                    Expance_Type = expance_type.FirstOrDefault(item => item.Name == type.Text),
            //                    Description = description.Text,
            //                    User = users.FirstOrDefault(item => item.Id == MainWindow.Global.userID)
            //                };
            //                ctx.Expences.Add(new_expance);
            //                ctx.SaveChanges();
            //            }
            //        }
            //    }

            //    {
            //        using (var ctx = new Model())
            //        {
            //            var plans = ctx.Budjet_plans.ToList();
            //            var users = ctx.Users.ToList();
            //            var expance_type = ctx.Expances_Types.ToList();

            //            int pars;

            //            if (Int32.TryParse(sum.Text, out pars))
            //            {
            //                int sum_ = Int32.Parse(sum.Text);
            //                if (date.SelectedDate.Value >= System.DateTime.Now.AddMonths(1))
            //                {

            //                    Budjet_plan new_plan = new Budjet_plan
            //                    {
            //                        Date_ = date.SelectedDate.Value,
            //                        Sum = sum_,
            //                        Expance_Type = expance_type.FirstOrDefault(item => item.Name == type.Text),
            //                        Description = description.Text,
            //                        User = users.FirstOrDefault(item => item.Id == MainWindow.Global.userID)
            //                    };
            //                    ctx.Budjet_plans.Add(new_plan);
            //                    ctx.SaveChanges();
            //                }
            //                else
            //                    MessageBox.Show("DATE must be in future monthes!");
            //            }

            //        }
            //    }
            //    sum.Text = null;
            //    description.Text = null;
            //    type.SelectedIndex = 0;
        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {

            //    {
            //        using (var ctx = new Model())
            //        {
            //            var profits = ctx.Profits.ToList();
            //            // var profit_for_del = profits.Where(item => item.Id == budjet_Grid.SelectedItem.)
            //        }
            //    }
            //    budjet_Grid.Items.Remove(budjet_Grid.SelectedItem);


        }

        //Dairy
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
             DIARY diary = new DIARY();
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

        //зміна розмітки вікна при натисканні головних кнопок
        private void Change_Window()
        {
            add.Visibility = Visibility.Visible;
            show_all.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Hidden;
            border_add.Visibility = Visibility.Visible;
            budjet_Grid.Visibility = Visibility.Hidden;
        }

        ////Profits to Grid
        //private void Bind_To_DataGrid_Profits()
        //{

        //    var budgets = _ctx.Profits.ToList();
        //    budgets = budgets.Where(item => item.User.Id == MainWindow.Global.userID).ToList();
        //    budjet_Grid.Visibility = Visibility.Visible;
        //    var budgets_list = budgets.Select(item => new { item.Id, item.Date_, item.Profit_Type.Name, item.Sum, item.Description });
        //    Binding binding = new Binding();
        //    binding.Mode = BindingMode.TwoWay;
        //    binding.Source = budgets_list;
        //    binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
        //    budjet_Grid.ItemsSource = budgets_list;
        //}
        //private void Bind_To_DataGrid_Expance()
        //{
        //    var expances = _ctx.Expences.ToList();
        //    expances = expances.Where(item => item.User.Id == MainWindow.Global.userID).ToList();
        //    budjet_Grid.Visibility = Visibility.Visible;
        //    var expance_list = expances.Select(item => new { item.Date_, item.Expance_Type.Name, item.Sum, item.Description });
        //    Binding binding = new Binding();
        //    binding.Source = expance_list;
        //    budjet_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
        //}


        ////                //expances
        ////                if (Choise == 2) 
        ////                {
        ////                    var expances = ctx.Expences.ToList();
        ////expances = expances.Where(item => item.User.Id == MainWindow.Global.userID).ToList();
        ////budjet_Grid.Visibility = Visibility.Visible;
        ////                    var expance_list = expances.Select(item => new { item.Date_, item.Expance_Type.Name, item.Sum, item.Description });
        ////Binding binding = new Binding();
        ////binding.Source = expance_list;
        ////                    budjet_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
        ////                }
        ////                if (Choise == 3) //plans
        ////                {
        ////                    var plans = ctx.Budjet_plans.ToList();
        ////plans = plans.Where(item => item.User.Id == MainWindow.Global.userID).ToList();
        ////budjet_Grid.Visibility = Visibility.Visible;
        ////                    var plans_list = plans.Select(item => new { item.Date_, item.Expance_Type.Name, item.Sum, item.Description });
        ////Binding binding = new Binding();
        ////binding.Source = plans_list;
        ////                    budjet_Grid.SetBinding(DataGrid.ItemsSourceProperty, binding);
        ////                }



        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            User_Account_Info user_Account = new User_Account_Info();
            user_Account.Show();
            //this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
