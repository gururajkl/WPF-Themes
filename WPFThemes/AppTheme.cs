using System;
using System.Windows;

namespace WPFThemes
{
    /// <summary>
    /// Sets the theme of the application.
    /// </summary>
    public class AppTheme
    {
        /// <summary>
        /// Changes the theme dynamically at run time.
        /// </summary>
        /// <param name="themeUri">Relative position of the resource dictionary.</param>
        public static void SwitchTheme(Uri themeUri)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary()
            {
                Source = themeUri,
            };

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
