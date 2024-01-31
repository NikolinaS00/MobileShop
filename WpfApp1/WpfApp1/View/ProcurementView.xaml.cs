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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataBase;
using WpfApp1.Model;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for ProcurementView.xaml
    /// </summary>
    public partial class ProcurementView : UserControl
    {
        Article newArticle { get; set; }
        public ProcurementView()
        {
            InitializeComponent();
        }
        private void SaleReviseButton_Click(object sender, RoutedEventArgs e)
        {
            SaleReviseGrid.Visibility = Visibility.Visible;
            NewSaleGrid.Visibility = Visibility.Collapsed;
        }

        private void NewSaleButton_Click(object sender, RoutedEventArgs e)
        {
            SaleReviseGrid.Visibility = Visibility.Collapsed;
            NewSaleGrid.Visibility = Visibility.Visible;
        }

        private void AddItemOnReceiptButton_Click(object sender, RoutedEventArgs e)
        {
            if (ArticleAmountTxtBox.Text != "" && ArticleIdTxtBox.Text != "" && ArticlePriceTxtBox.Text != "" && TotalPriceTxtBox.Text != "")
            {
                ProcurementViewModel.Items.Add(new ProcurementItem
                {
                    ArticleId = Int32.Parse(ArticleIdTxtBox.Text),
                    Amount = Int32.Parse(ArticleAmountTxtBox.Text),
                    TotalPrice = Int32.Parse(TotalPriceTxtBox.Text),
                    ArticleName = newArticle.Name,
                    ArticlePrice = newArticle.ArticlePrice
                });
            }
            else
            {
                string messageBoxText = "Jedno od polja nije pravilno popunjeno, pokušajte ponovo";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            }
            ArticleAmountTxtBox.Clear();
            ArticleIdTxtBox.Clear();
            ArticlePriceTxtBox.Clear();
            TotalPriceTxtBox.Clear();

        }

        private void PreviewReceiptButton_Click(object sender, RoutedEventArgs e)
        {

            ProcurementPreviewReceiptWindow win = new ProcurementPreviewReceiptWindow();
            win.ShowDialog();
        }

        private void ArticleAmountTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ArticleAmountTxtBox.Text != "")
            {

             

                    TotalPriceTxtBox.Text = (Int32.Parse(ArticleAmountTxtBox.Text) * newArticle.ArticlePrice).ToString();
               
               
            }
        }

        private void ArticleIdTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ArticleIdTxtBox.Text != "")
            {
                int id = Int32.Parse(ArticleIdTxtBox.Text);
                Article art = DbMobileShop.GetaArticleById(id);
                if (art != null)
                {
                    newArticle = art;
                    ArticlePriceTxtBox.Text = art.ArticlePrice.ToString();
                    ArticleAmountTxtBox.IsReadOnly = false;
                }
                else
                {
                    string messageBoxText = "Uneseni ID artikla ne postoji, pokušajte ponovo!";
                    string caption = "Greška";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    MessageBoxResult result;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

                }
            }

        }
    }
}
