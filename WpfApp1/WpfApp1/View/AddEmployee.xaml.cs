using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date1 = (DateTime)EmployeeBirthdatetxtbox.SelectedDate;
            DateTime date2 = (DateTime)EmployeeExpirationtxtbox.SelectedDate;
            Account account = new Account
            {
                Name = EmployeeUsernametxtbox.Text,
                Password = EmployeePasswordtxtbox.Text,
            };

            Employee emp = new Employee
            {

                FirstName = EmployeeNametxtbox.Text,
                LastName = EmployeeSurnametxtbox.Text,
                UID = EmployeeUIDtxtbox.Text,
                DateOfBirth = date1.ToString("yyyy-MM-dd"),
                ExpirationOfContract = date2.ToString("yyyy-MM-dd"),
                YearOfEmployment = EmployeeEmploymentyeartxtbox.Text,
                Email = EmployeeEmailtxtbox.Text,
                Salary =Int32.Parse( EmployeeSalarytxtbox.Text),
                Address = EmployeeAddresstxtbox.Text

            };

            DbMobileShop.AddEmployee(emp, account);
            EmployeeNametxtbox.Clear();
            EmployeeSurnametxtbox.Clear();
            EmployeeUIDtxtbox.Clear();
            EmployeeEmploymentyeartxtbox.Clear();
            EmployeeEmailtxtbox.Clear();
            EmployeeSalarytxtbox.Clear();
            EmployeeAddresstxtbox.Clear();

        }
    }
}
