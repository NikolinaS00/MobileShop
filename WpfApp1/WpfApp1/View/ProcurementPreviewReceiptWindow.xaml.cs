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
using System.Windows.Shapes;
using WpfApp1.DataBase;
using WpfApp1.Model;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for ProcurementPreviewReceiptWindow.xaml
    /// </summary>
    public partial class ProcurementPreviewReceiptWindow : Window
    {
        List<ProcurementItem> saleItems = new List<ProcurementItem>();
        public ProcurementPreviewReceiptWindow()
        {
            foreach (ProcurementItem it in ProcurementViewModel.Items)
                saleItems.Add(it);
            InitializeComponent();

            foreach (ProcurementItem it in saleItems)
                ProcurementViewModel.Items.Add(it);
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PrintReceiptButton_Click(object sender, RoutedEventArgs e)
        {
            string jbmg = DbMobileShop.GetUIDbyAccountID(DbMobileShop.LoggedAccount.Id);
            DbMobileShop.CreateProcurement(1,jbmg, DateTime.Today, saleItems);  //hardkodovan id dobavljaca
            saleItems.Clear();
            ProcurementViewModel.Items.Clear();
        }
    }
}
