﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;

namespace WebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void go_button_Click(object sender, RoutedEventArgs e)
        {
            if (browser != null && browser.CoreWebView2 != null)
            {
                Uri url;
                try
                {
                    url = new UriBuilder(url_bar.Text).Uri;
                }
                catch(Exception)
                {
                    url = new Uri("https://www.google.com/search?q=" + url_bar.Text);
                }
                string final_dest = url.AbsoluteUri;
                browser.CoreWebView2.Navigate(final_dest);
                url_bar.Text = final_dest;
            }
        }

        private void url_bar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                go_button_Click(sender, e);
            }
        }
    }
}
