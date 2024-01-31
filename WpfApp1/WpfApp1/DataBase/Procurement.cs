using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBase
{
    internal class Procurement
    {
        public  int ProcurementNumber { get; set; } 
        public string Date { get; set; }
        public int SupplierId { get; set; }
        public string AdminUID { get; set; }

        public string EmployeeNameAndSurname { get; set; }
    }
}
