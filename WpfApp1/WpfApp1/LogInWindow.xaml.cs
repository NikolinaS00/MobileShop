using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.DataBase;

namespace WpfApp1.View
{
    public partial class LogInWindow : Window
    {
        static Account LoggedInUser { get; set; } = null;
        public static bool ItsAdmin = false;
        public static string themeFileName = "";
        public static string fontSizeFileName = "";
        public static string fontStyleFileName = "";
        public static string languageFileName = "";
        List<Account> Accounts = new List<Account>();
        public LogInWindow()
        {
            InitializeComponent();
        }

        private Account SearchAccount(String name, String passw)
        {
            Accounts = DbMobileShop.GetAccounts();
            Account res = null;
            foreach(Account a in this.Accounts)
            {
                if(a.Name == name && a.Password==passw) 
                { 
                    res = a;
                    DbMobileShop.LoggedAccount = a;
                    LoggedInUser = a;
                }
            }
            return res;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           this.Visibility = Visibility.Visible;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var username = UserName.Text;
            var pass = Password.Password;
            if(SearchAccount(username, pass)!= null)
            {
                ApplyTheme();
               ItsAdmin = DbMobileShop.IsAdmin(LoggedInUser);
                this.Hide();
                MainWindow win = new MainWindow();
                win.Closing += Window_Closing;
                win.Show();
              
            }
            else 
            {
                string messageBoxText = (string)Application.Current.FindResource("MessageBoxWrongDatas");
                string caption = (string)Application.Current.FindResource("MessageBoxError");
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            UserName.Clear();
            Password.Clear();
        }

        private void ApplyTheme()
        {
            if(LoggedInUser.Language == "sr")
            {
                LogInWindow.languageFileName = MainWindow.LanguageSRFilePath; 
            }
            else if(LoggedInUser.Language == "en")
            {
                LogInWindow.languageFileName = MainWindow.LanguageENFilePath; 
            }

            if(LoggedInUser.ThemeFontStyle == "t")
            {
                LogInWindow.fontStyleFileName = MainWindow.ThemeFontStyle2FilePath; 
            }
            else if(LoggedInUser.ThemeFontStyle=="g")
            {
                LogInWindow.fontStyleFileName = MainWindow.ThemeFontStyle1FilePath;
            }

            if (LoggedInUser.ThemeColor == "b")
            {
                LogInWindow.themeFileName = MainWindow.ThemeBlueFilePath;
            }
            else if(LoggedInUser.ThemeColor == "g")
            {
                LogInWindow.themeFileName = MainWindow.ThemeGreenFilePath;
            }

            if (LoggedInUser.ThemeFontSize == "16")
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize16FilePath;
            }
            else if (LoggedInUser.ThemeFontSize == "20")
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize20FilePath;
            }
            else if (LoggedInUser.ThemeFontSize == "24")
            {
                LogInWindow.fontSizeFileName = MainWindow.ThemeFontSize24FilePath;
            }
        }
    }
}
