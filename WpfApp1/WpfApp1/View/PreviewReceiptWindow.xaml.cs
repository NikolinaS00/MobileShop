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
    /// Interaction logic for PreviewReceiptWindow.xaml
    /// </summary>
    public partial class PreviewReceiptWindow : Window
    {
        List<SaleItem> saleItems = new List<SaleItem>();
        public PreviewReceiptWindow()
        {
            foreach(SaleItem it in SaleViewModel.Items)
            saleItems.Add(it);
            InitializeComponent();

            foreach(SaleItem it in saleItems)
                SaleViewModel.Items.Add(it);


        }

        private void PrintReceiptButton_Click(object sender, RoutedEventArgs e)
        {

            string jbmg = DbMobileShop.GetUIDbyAccountID(DbMobileShop.LoggedAccount.Id);
            DbMobileShop.CreateSale(jbmg,DateTime.Today,saleItems);
            saleItems.Clear();
            SaleViewModel.Items.Clear();
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {

            if (SaleViewModel.SelectedItem != null)
            {

               
                    string messageBoxText = "Da li ste sigurni da želite obrisati izabrani artikal?";
                    string caption = "Upozorenje";
                    MessageBoxButton button = MessageBoxButton.YesNo;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBoxResult result;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    if (result == MessageBoxResult.Yes)
                    {
                     
                        var itemToRemove = DataGridItems.Items.Cast<SaleItem>().FirstOrDefault(item => item == SaleViewModel.SelectedItem);
                        SaleViewModel.Items.Remove(SaleViewModel.SelectedItem);
                        saleItems.Remove(SaleViewModel.SelectedItem);
                        DataGridItems.Items.Refresh();
                    }



            

            }
            else
            {
                string messageBoxText = "Niste izabrali artikal za brisanje, pokušajte ponovo!";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            }
        }
    }
}
