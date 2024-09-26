using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Localization
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var langCode = Localization.Properties.Settings.Default.langCode;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(langCode);

            base.OnStartup(e);
        }
    }
}
