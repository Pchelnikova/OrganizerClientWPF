using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow 
    {
        public TranslateTransform translateTransform;
        DispatcherTimer timer = new DispatcherTimer();
        int counter = 0;
        double coord = 0;
        int[] level = new[] { 4, 8, 11, 13, 15 , 16 };
        int countLevel = 0;
        //bool nextAnimation = false;  не зроблено
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
        }
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Start();
            //nextAnimation = true;
        }
        //START 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
                if (MainGrid.Children[counter] is Label)
                {
                    if (counter < level[countLevel])
                    {
                        Animation();
                        counter++;
                    }
                    else
                    {
                        countLevel++;
                        coord = 0;
                    }
                    if (counter == level[level.Length - 1]) timer.Stop();
                }
            //nextAnimation = true;
        }
        private void Animation()
        {
           // if (nextAnimation == true)
           // {
                translateTransform = new TranslateTransform();
                MainGrid.Children[counter].Visibility = Visibility.Visible;
                MainGrid.Children[counter].RenderTransform = translateTransform;
                coord += (MainGrid.Children[counter] as Label).ActualWidth;
                DoubleAnimation animX = new DoubleAnimation(this.ActualWidth + 
                    ((MainGrid.Children[counter] as Label).Margin.Right) - coord ,
                    new Duration(new TimeSpan(0, 0, 0, 0, 250)));
                translateTransform.BeginAnimation(TranslateTransform.XProperty, animX);
            //    nextAnimation = false;
           // }
        }
    }
}

