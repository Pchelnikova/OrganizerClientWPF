using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows.Media.Animation;
using System.Collections.Generic;
using System.Threading;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow
    {
        private TranslateTransform _translateTransform;
        private DispatcherTimer _timer = new DispatcherTimer();
        private int _counter = 0;
        private double _coord = 0;
        private int[] _level = new[] { 4, 8, 11, 13, 15, 16 };
        private int _countLevel = 0;
        private bool _end = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _timer.Tick += new EventHandler(dispatcherTimer_Tick);
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            _timer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (MainGrid.Children[_counter] is Label)
            {
                if (_counter < _level[_countLevel])
                {
                    _coord += (MainGrid.Children[_counter] as Label).ActualWidth;
                    AnimationControls(MainGrid.Children[_counter], this.ActualWidth + ((MainGrid.Children[_counter] as Label).Margin.Right) - _coord);
                    _counter++;
                }
                else
                {
                    _countLevel++;
                    _coord = 0;
                }
                if (_counter == _level[_level.Length - 1])
                {
                    _end = true;
                    _timer.Stop();
                    foreach (var item in MainGrid.Children)
                    {
                        if (item is Label)
                        {
                            AnimationControls(item, 0);
                        }
                    }
                    SetGrid();
                }
            }
        }
        private void AnimationControls(object obj, double coordinates)
        {
            if (obj is Label)
            {
                _translateTransform = new TranslateTransform(0, 0);
                (obj as Label).Visibility = Visibility.Visible;
                (obj as Label).RenderTransform = _translateTransform;
                DoubleAnimation animX = new DoubleAnimation(coordinates, new Duration(new TimeSpan(0, 0, 0, 0, 100)));
                if (_end == true)
                {
                    animX.FillBehavior = FillBehavior.Stop;
                }
                _translateTransform.BeginAnimation(TranslateTransform.XProperty, animX);
            }
        }
        private void SetGrid()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is Label)
                {
                    (item as Label).Margin = new Thickness(0);
                    Grid.SetColumn((item as Label), Int32.Parse((item as Label).Tag.ToString()));
                }
            }
        }
        //START 
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Window window2 = new Login_Window();
            window2.Show();
            this.Close();
        }
    }
}

