﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace wp8html5
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Url of Home page
        private string MainUri = "/Html/index.html";
        private string Page2Uri = "/Html/page2.html";

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Browser_Loaded(object sender, RoutedEventArgs e)
        {
            // Add your URL here
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
            // Set in XAML
            // Browser.IsScriptEnabled = true;
        }

        // Navigates back in the web browser's navigation stack, not the applications.
        private void BackApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        // Navigates forward in the web browser's navigation stack, not the applications.
        private void ForwardApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        // Navigates to the initial "home" page.
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            //Browser.Navigate(new Uri(MainUri, UriKind.Relative));
            Browser.Navigate(new Uri(Page2Uri, UriKind.Relative));
        }

        // Handle navigation failures.
        private void Browser_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            MessageBox.Show("Navigation to this page failed, check your internet connection");
        }

        private void ChangeParagraph(object sender, NotifyEventArgs e)
        {
            Browser.InvokeScript("setParagraph");
        }
    }
}