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
            SetValuesForComboBox();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            SetThemeParameters();
            MainWindow.ApplyTheme();
            DbMobileShop.changeThemeParameters();

        }

        private void SetValuesForComboBox()
        {
            if (DbMobileShop.LoggedAccount.ThemeColor == "b")
            {
                themeComboBox.SelectedIndex = 0;
            }
            else if(DbMobileShop.LoggedAccount.ThemeColor == "g")
            {
                themeComboBox.SelectedIndex = 1;
            }

            if (DbMobileShop.LoggedAccount.ThemeFontSize == "16")
            {
                FontSizeComboBox.SelectedIndex = 0;
            }
            else if(DbMobileShop.LoggedAccount.ThemeFontSize == "20")
            {
                FontSizeComboBox.SelectedIndex = 1;
            }
            else if(DbMobileShop.LoggedAccount.ThemeFontSize == "24")
            {
                FontSizeComboBox.SelectedIndex = 2;
            }

            if(DbMobileShop.LoggedAccount.ThemeFontStyle == "g")
            {
                FontStyleComboBox.SelectedIndex = 0;
            }
            else if(DbMobileShop.LoggedAccount.ThemeFontStyle == "t")
            {

                FontStyleComboBox.SelectedIndex = 1;
            }

            if (DbMobileShop.LoggedAccount.Language == "sr")
            {
                LanguageComboBox.SelectedIndex = 0;
            }
            else if(DbMobileShop.LoggedAccount.Language == "en")
            {
                LanguageComboBox.SelectedIndex = 1;
            }
        }
        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            Console.WriteLine(themeComboBox.SelectedIndex);
            if (themeComboBox.SelectedIndex == 0)
            {
                   
                LogInWindow.themeFileName =MainWindow.ThemeBlueFilePath;
            }
            else if (themeComboBox.SelectedIndex == 1)
            {
                LogInWindow.themeFileName = MainWindow.ThemeGreenFilePath;
            }

        }

        private void FontStyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(FontStyleComboBox.SelectedIndex==0)
            {
                
                LogInWindow.fontStyleFileName = MainWindow.ThemeFontStyle1FilePath;
            }
            else if(FontStyleComboBox.SelectedIndex==1)
            {
                LogInWindow.fontStyleFileName = MainWindow.ThemeFontStyle2FilePath;
            }
        }

        private void FontSizeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSizeComboBox.SelectedIndex == 0)
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize16FilePath;
            }
            else if(FontSizeComboBox.SelectedIndex == 1)
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize20FilePath; 
            }
            else if(FontSizeComboBox.SelectedIndex == 2)
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize24FilePath; 
            }
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 0)
            {
                LogInWindow.languageFileName = MainWindow.LanguageSRFilePath; 
            }
            else if(LanguageComboBox.SelectedIndex == 1)
            {
                LogInWindow.languageFileName = MainWindow.LanguageENFilePath; 
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
