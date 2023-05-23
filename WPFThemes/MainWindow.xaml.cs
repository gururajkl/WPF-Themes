using System;
using System.Windows;

namespace WPFThemes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LightThemeClick(object sender, RoutedEventArgs e)
        {
            AppTheme.SwitchTheme(new Uri("Themes/Light.xaml", UriKind.Relative));
        }

        private void DarkThemeClick(object sender, RoutedEventArgs e)
        {
            AppTheme.SwitchTheme(new Uri("Themes/Dark.xaml", UriKind.Relative));
        }
    }
}
