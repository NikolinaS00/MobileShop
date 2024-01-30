using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataBase;

namespace WpfApp1.Model
{
    internal class SuppliersViewModel
    {

        public static ObservableCollection<Supplier> suppliers {  get; set; }
       

        public SuppliersViewModel() {
            suppliers = new ObservableCollection<Supplier>();
            List<Supplier> Suppliers = DbMobileShop.GetSuppliers();
            foreach (var supplier in Suppliers) { 
            suppliers.Add(supplier);
            }

        }
    }
}
