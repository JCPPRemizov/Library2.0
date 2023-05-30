using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library2._0
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string _theme;
        public static string Theme
        {
            get { return _theme; }
            set
            {
                _theme = value;
                var dict = new ResourceDictionary
                {
                    Source = new Uri($"pack://application:,,,/WpfCustomControlLibrary;component/Themes/{value}",
                        UriKind.Absolute)
                };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }
        public App()
        {
            InitializeComponent();
        }
    }
}
