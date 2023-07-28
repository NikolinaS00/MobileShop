using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataBase;
using WpfApp1.objects;

namespace WpfApp1.Model
{
   
    internal class EmployeesViewModel : ObservableObject
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public EmployeesViewModel() {
            
            Employees = new ObservableCollection<Employee>();
            List<Employee> list = DbMobileShop.GetEmployees();
             foreach (var item in list)
             {
                 Employees.Add(item);

             }

            Console.WriteLine("===========" + Employees[0].UID);
        }
    }
}
