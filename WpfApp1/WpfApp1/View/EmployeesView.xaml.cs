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
using WpfApp1.DataBase;
using WpfApp1.Model;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
     
        public EmployeesView()
        {

            InitializeComponent();
           
        }

        private void ButtonAdd1_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee win = new AddEmployee();
            win.Closing += Window_Closed;
            win.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ButtonEdit1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDelete1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchTxtBox.Text;
            List<Employee> employees = new List<Employee>();
            foreach(Employee emp in daataGridEmployees.Items)
            {
               
                if (emp.FirstName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(emp.FirstName);
                    employees.Add(emp);
                   
                }
            }

            EmployeesViewModel.Employees.Clear();
            foreach(Employee em in employees)
            {
                EmployeesViewModel.Employees.Add(em);
            }
            Refresh();
        }

        private void Refresh()
        {
           // EmployeesViewModel.RefreshList();
          daataGridEmployees.Items.Refresh();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeesView view = new EmployeesView();
            EmployeesViewModel.RefreshList();
            Refresh();
        }
    }
}
