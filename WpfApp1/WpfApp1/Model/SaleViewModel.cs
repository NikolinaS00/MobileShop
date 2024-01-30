using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataBase;

namespace WpfApp1.Model
{
    internal class SaleViewModel
    {
        public static ObservableCollection<SaleItem> Items { get; set; }
        public static SaleItem SelectedItem { get; set; }
        public SaleViewModel() {
            Items = new ObservableCollection<SaleItem>();
        }
        
  
    }
}
