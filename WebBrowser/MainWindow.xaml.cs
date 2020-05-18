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
                browser.CoreWebView2.Navigate("https://www.google.com/search?btnI=1&q=" + url_bar.Text);
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
