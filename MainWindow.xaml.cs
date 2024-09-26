using Localization.Models;
using Localization.Pages;
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

namespace Localization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Languague> lang = new List<Languague>()
        {
            new Languague(Properties.Lang.Lang.en, "en-US","/Resourses/usa_icon.png"),
            new Languague(Properties.Lang.Lang.ru, "ru-US","/Resourses/russia_icon.png"),
            new Languague(Properties.Lang.Lang.fr, "fr-FR","/Resourses/france_icon.png"),
        };
        public MainWindow()
        {
            InitializeComponent();
            CbLangue.ItemsSource = lang;
            MainFrame.Navigate(new MainPage());
        }

        private void CbLangue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CbLangue.SelectedItem is Languague languague)
            {
                Properties.Settings.Default.langCode = languague.Value;
                Properties.Settings.Default.Save();
            }
            
        }
    }
}
