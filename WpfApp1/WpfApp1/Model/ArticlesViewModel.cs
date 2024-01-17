using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.objects;

namespace WpfApp1.Model
{
    internal class ArticlesViewModel : ObservableObject
    {
       
        public RelayCommand MobilePhonesRelayCommand { get; set; }
        public RelayCommand PhoneCasesRelayCommand { get; set; }
        public RelayCommand OtherEquipmentRelayCommand { get; set; }
        public RelayCommand PowerBanksRelayCommand { get; set; }
        public MobilePhonesViewModel MobilePhonesVM { get; set; }

     
    }
}
