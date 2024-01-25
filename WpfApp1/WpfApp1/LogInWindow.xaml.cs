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
                    LoggedInUser = a;
                }
            }
            return res;
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var username = UserName.Text;
            var pass = Password.Password;
            if(SearchAccount(username, pass)!= null)
            {
                ApplyTheme();
               ItsAdmin = DbMobileShop.IsAdmin(LoggedInUser);
                MainWindow win = new MainWindow();
                win.Show();
            }
            else 
            {
                string messageBoxText = "Neispravni korisnički podaci. Pokušajte ponovo!";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }

        }

        private void ApplyTheme()
        {
            if(LoggedInUser.Language == "sr")
            {
                Console.WriteLine("ssssssssssrrrrrrrrr");
                LogInWindow.languageFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionarySR.xaml";
            }
            else if(LoggedInUser.Language == "en")
            {
                Console.WriteLine("eeeeeeeeeennnnnnnnnnnnn");
                LogInWindow.languageFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryEN.xaml";
            }

            if(LoggedInUser.ThemeFontStyle == "t")
            {
                LogInWindow.fontStyleFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle2.xaml";
            }
            else if(LoggedInUser.ThemeFontStyle=="g")
            {
                LogInWindow.fontStyleFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontStyle1.xaml";
            }

            if (LoggedInUser.ThemeColor == "b")
            {
                LogInWindow.themeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryTHEME.xaml";
            }
            else if(LoggedInUser.ThemeColor == "g")
            {
                LogInWindow.themeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryThemeGREEN.xaml";
            }

            if (LoggedInUser.ThemeFontSize == "16")
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize16.xaml";
            }
            else if (LoggedInUser.ThemeFontSize == "20")
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize20.xaml";
            }
            else if (LoggedInUser.ThemeFontSize == "24")
            {
                LogInWindow.fontSizeFileName = "C:\\Users\\stojc\\OneDrive\\Desktop\\GIT\\MobileShop\\WpfApp1\\WpfApp1\\Resources\\ResourceDictionaryFontSize24.xaml";
            }
        }
    }
}
