using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBase
{
    internal class Sale
    {
        public int SaleNumber { get; set; }
        public string EmployeeUID { get; set; }
        public string SaleDate { get; set; }

        public string EmployeeNameAndSurname { get; set; } 
     

        public Sale() {
        
        }
    }
}
