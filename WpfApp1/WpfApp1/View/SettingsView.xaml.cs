using System;
using System.Collections.Generic;
using System.Data.Common;
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
using WpfApp1.DataBase;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        string themeResource = "";
        public SettingsView()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            SetThemeParameters();
            MainWindow.ApplyTheme();
            DbMobileShop.changeThemeParameters();

        }

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            Console.WriteLine(themeComboBox.SelectedIndex);
            if (themeComboBox.SelectedIndex == 0)
            {
                LogInWindow.themeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryTHEME.xaml";
            }
            else if (themeComboBox.SelectedIndex == 1)
            {
                LogInWindow.themeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryThemeGREEN.xaml";
            }

        }

        private void FontStyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(FontStyleComboBox.SelectedIndex==0)
            {
                LogInWindow.fontStyleFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle1.xaml";
            }
            else if(FontStyleComboBox.SelectedIndex==1)
            {
                LogInWindow.fontStyleFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle2.xaml";
            }
        }

        private void FontSizeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSizeComboBox.SelectedIndex == 0)
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize16.xaml";
            }
            else if(FontSizeComboBox.SelectedIndex == 1)
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize20.xaml";
            }
            else if(FontSizeComboBox.SelectedIndex == 2)
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize24.xaml";
            }
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 0)
            {
                LogInWindow.languageFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionarySR.xaml";
            }
            else if(LanguageComboBox.SelectedIndex == 1)
            {
                LogInWindow.languageFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryEN.xaml";
            }
        }

        private  List<String> SetThemeParameters()
        {
            List<String> res = new List<string>();
            if (LogInWindow.languageFileName == MainWindow.LanguageENFilePath)
            {
                DbMobileShop.ThemeAttributes.Add("en");
            }
            else DbMobileShop.ThemeAttributes.Add("sr");

            if (LogInWindow.themeFileName == MainWindow.ThemeGreenFilePath)
            {
                DbMobileShop.ThemeAttributes.Add("g");
            }
            else if (LogInWindow.themeFileName == MainWindow.ThemeBlueFilePath)
            {
                DbMobileShop.ThemeAttributes.Add("b");
            }
            if (LogInWindow.fontSizeFileName == MainWindow.ThemeFontSize16FilePath)
            {
                DbMobileShop.ThemeAttributes.Add("16");
            }
            else if (LogInWindow.fontSizeFileName == MainWindow.ThemeFontSize20FilePath)
            {
                DbMobileShop.ThemeAttributes.Add("20");
            }
            else DbMobileShop.ThemeAttributes.Add("24");

            if (LogInWindow.fontStyleFileName == MainWindow.ThemeFontStyle1FilePath)
            {
                DbMobileShop.ThemeAttributes.Add("g");
            }
            else DbMobileShop.ThemeAttributes.Add("t");

         
            return res;
        }
    }
}
