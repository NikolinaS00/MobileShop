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
    }
}
