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
        public static ObservableCollection<Sale> Sales { get; set; }
        public static SaleItem SelectedItem { get; set; }
        public static Sale SelectedSale { get; set; }

        public SaleViewModel() {
            Items = new ObservableCollection<SaleItem>();
            Sales = new ObservableCollection<Sale>();
            List<Sale> list = new List<Sale>();
            list = DbMobileShop.GetSales();
          
            foreach (Sale item in list)
            {
                Sales.Add(item);
            }
        }
        
  
        public static void RefreshList()
        {
          
            Sales.Clear();
            List<Sale> list = new List<Sale>();
            list = DbMobileShop.GetSales();

            foreach (Sale item in list)
            {
                Sales.Add(item);
            }
        }
    }
}
