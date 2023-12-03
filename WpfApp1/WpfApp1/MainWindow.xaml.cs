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
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ResourceDictionary ThemeDictionaryColor
        {
            get { return Resources.MergedDictionaries[0]; }
        }
            public ResourceDictionary ThemeDictionaryFontSize
            {
               
                get { return Resources.MergedDictionaries[0]; }
            }

        public ResourceDictionary ThemeDictionaryLanguage
        {
            get { return Resources.MergedDictionaries[0]; }
        }
        public ResourceDictionary ThemeDictionaryFontStyle
         {
             get { return Resources.MergedDictionaries[0]; }
         }

        public MainWindow()
        {
            InitializeComponent();
        }


   

        private void ApplyThemeee(string themeFileName)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary dictionary1 = new ResourceDictionary();
        dictionary1.Source = new Uri("C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryThemeGREEN.xaml", UriKind.RelativeOrAbsolute); //TODO napraviti da se mijenjaju putanje u zavisnnsti od parametara funkcije

            ResourceDictionary dictionary2 = new ResourceDictionary();
        dictionary2.Source = new Uri("C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionarySR.xaml", UriKind.RelativeOrAbsolute); //TODO napraviti da se mijenjaju putanje u zavisnnsti od parametara funkcije

        Application.Current.Resources.MergedDictionaries.Add(dictionary1);
            Application.Current.Resources.MergedDictionaries.Add(dictionary2);
           
     }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {

            ApplyThemeee("utfgiu");

        }
    }
}
