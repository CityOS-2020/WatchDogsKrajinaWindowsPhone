﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



namespace WatchDogsKrajina
{
    public sealed partial class MainPage : Page
    {

        private static readonly Uri HomeUri = new Uri("http://watchdogskrajina.herokuapp.com/mobile/", UriKind.Absolute);

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            WebViewControl.Navigate(HomeUri);

            HardwareButtons.BackPressed += this.MainPage_BackPressed;
        }

   
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed -= this.MainPage_BackPressed;
        }

        
        private void MainPage_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (WebViewControl.CanGoBack)
            {
                WebViewControl.GoBack();
                e.Handled = true;
            }
        }

        private void Browser_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if (!args.IsSuccess)
            {
                Debug.WriteLine("Fail");
            }
        }

        
        private void CenterMapBtn_Click(object sender, RoutedEventArgs e)
        {
            WebViewControl.Refresh();
        }

        
        private void DodatneBtn_Click(object sender, RoutedEventArgs e)
        {
        }



        private void SwitchMapBtn_Click(object sender, RoutedEventArgs e)
        {

            WebViewControl.Navigate(new Uri("http://watchdogskrajina.herokuapp.com/mobile/"));
        }

        private void SwitchMapBtn_Click_1(object sender, RoutedEventArgs e)
        {
            WebViewControl.Navigate(new Uri("http://watchdogskrajina.herokuapp.com/mobile/transport.html"));
        }
    }
}
