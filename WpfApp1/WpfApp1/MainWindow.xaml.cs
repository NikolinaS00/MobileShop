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
using WpfApp1.View;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isAdmin;

        public static string ThemeBlueFilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryTHEME.xaml";
        public static string ThemeGreenFilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryThemeGREEN.xaml";
        public static string ThemeFontSize16FilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize16.xaml";
        public static string ThemeFontSize20FilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize20.xaml";
        public static string ThemeFontSize24FilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize24.xaml";
        public static string ThemeFontStyle1FilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle1.xaml";
        public static string ThemeFontStyle2FilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle2.xaml";
        public static string LanguageSRFilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionarySR.xaml";
        public static string LanguageENFilePath = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryEN.xaml";

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


        public static void ApplyTheme()
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary dictionary1 = new ResourceDictionary();
            ResourceDictionary dictionary2 = new ResourceDictionary();
            ResourceDictionary dictionary3 = new ResourceDictionary();
            ResourceDictionary dictionary4 = new ResourceDictionary();
            dictionary1.Source = new Uri(LogInWindow.themeFileName, UriKind.RelativeOrAbsolute);
            dictionary2.Source = new Uri(LogInWindow.languageFileName, UriKind.RelativeOrAbsolute);
            dictionary3.Source = new Uri(LogInWindow.fontSizeFileName, UriKind.RelativeOrAbsolute); 
            dictionary4.Source = new Uri(LogInWindow.fontStyleFileName, UriKind.RelativeOrAbsolute); 

            Application.Current.Resources.MergedDictionaries.Add(dictionary1);
            Application.Current.Resources.MergedDictionaries.Add(dictionary2);
            Application.Current.Resources.MergedDictionaries.Add(dictionary3);
            Application.Current.Resources.MergedDictionaries.Add(dictionary4);
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ArticleButton_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("inicalizacija");
           ArticleButton.Command.Execute("Binding ArticlesRelayCommand");
           
        }
    }
}
