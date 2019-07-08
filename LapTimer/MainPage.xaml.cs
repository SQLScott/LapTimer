using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LapTimer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int laps = 0;
        int _Counter = 0;
        DispatcherTimer timer = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TxtLapCount_Tapped(object sender, TappedRoutedEventArgs e)
        {
            laps += 1;
            //lbllaps.Content = laps;
            txtLapCount.Text = laps.ToString();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            _Counter = 0;
            txtLapTime.Text = "00:00:00";
        }

        private void BtnLapReset_Click(object sender, RoutedEventArgs e)
        {
            laps = 0;
            txtLapCount.Text = laps.ToString();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        public void Timer_Tick(object sender, object e)
        {
            _Counter += 1;
            txtLapTime.Text = TimeSpan.FromSeconds(_Counter).ToString();
        }

    }
}
