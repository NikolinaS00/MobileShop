using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataBase;

namespace WpfApp1.Model
{
    internal class ProcurementViewModel
    {
        public static ObservableCollection<ProcurementItem> Items { get; set; }
        public static ObservableCollection<Procurement> Procurements { get; set; }
        public static ProcurementItem SelectedItem { get; set; }
        public static Procurement SelectedProcurement { get; set; }

        public ProcurementViewModel() {
            Items = new ObservableCollection<ProcurementItem>();
            Procurements = new ObservableCollection<Procurement>();
            List<Procurement> list = new List<Procurement>();
            list = DbMobileShop.GetProcurements();

            foreach (Procurement item in list)
            {
                Procurements.Add(item);
            }
        }
    }
}
