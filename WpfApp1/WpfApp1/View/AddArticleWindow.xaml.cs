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

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for AddArticleWindow.xaml
    /// </summary>
    public partial class AddArticleWindow : Window
    {
        private string SelectedCategory = "";
        public AddArticleWindow()
        {
            InitializeComponent();
            Closed += AddArticleWindow_Closed;
        }
        private void AddArticleWindow_Closed(object sender, EventArgs e)
        {
            // Your code to handle the closing of Window1
        }

        private void AddArticleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ArticleNametxtbox.Text != null && ArticlePricetxtbox.Text != null && NumofArticlestxtbox.Text != null && SelectedCategory != "" && Varrantytxtbox.Text != null)
            {
                Article art = new Article();
                art.Name = ArticleNametxtbox.Text;
                art.ArticlePrice = Int32.Parse(ArticlePricetxtbox.Text);
                art.ArticleCategory = SelectedCategory;
                art.NumberOfArticles = Int32.Parse(NumofArticlestxtbox.Text);
                art.Varrranty = Int32.Parse(Varrantytxtbox.Text);
                DbMobileShop.AddArticle(art);
            }
            else
            {

                string messageBoxText = "Obavezno popunite sva polja";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            ArticleNametxtbox.Clear();
            ArticlePricetxtbox.Clear();
            Descriptiontxtbox.Clear();
            NumofArticlestxtbox.Clear();
            Varrantytxtbox.Clear();

        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CategoryComboBox.SelectedIndex == 0) 
            { 
                SelectedCategory="mobilni telefon";
            }
            else if(CategoryComboBox.SelectedIndex == 1)
            {
                SelectedCategory = "maska za telefon";
            }
            else if(CategoryComboBox.SelectedIndex == 2)
            {
                SelectedCategory = "ostala oprema";
            }
            else if(CategoryComboBox.SelectedIndex == 3)
            {
                SelectedCategory = "punjaci";
            }
        }
    }
}
