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
    /// Interaction logic for UpdateArticleWindow.xaml
    /// </summary>
    public partial class UpdateArticleWindow : Window
    {
        private string SelectedCategory = "";
        public UpdateArticleWindow()
        {

            InitializeComponent();
            ArticleNametxtbox.Text = ArticlesViewModel.SelectedItem.Name;
            ArticlePricetxtbox.Text = ArticlesViewModel.SelectedItem.ArticlePrice.ToString();
            SelectedCategory = ArticlesViewModel.SelectedItem.ArticleCategory;
            SelectedCategorySet(ArticlesViewModel.SelectedItem.ArticleCategory);
            NumofArticlestxtbox.Text = ArticlesViewModel.SelectedItem.NumberOfArticles.ToString();
            Varrantytxtbox.Text = ArticlesViewModel.SelectedItem.Varrranty.ToString();
            Descriptiontxtbox.Text = ArticlesViewModel.SelectedItem.Description;


        }

        private void SelectedCategorySet(string category)
        {
            if(category == "mobilni telefon")
            {
                CategoryComboBox.SelectedIndex = 0;
            }
            else if (category == "maska za telefon")
            {
                CategoryComboBox.SelectedIndex = 1;
            }
            else if (category == "ostala oprema")
            {
                CategoryComboBox.SelectedIndex = 2;
            }
            else if(category == "punjaci")
            {
                CategoryComboBox.SelectedIndex = 3;
            }
        }
        private void UpdateArticleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ArticleNametxtbox.Text != null && ArticlePricetxtbox.Text != null && NumofArticlestxtbox.Text != null && SelectedCategory != "" && Varrantytxtbox.Text != null)
            {
                Article art = new Article
                {
                    Id = ArticlesViewModel.SelectedItem.Id,
                    Name = ArticleNametxtbox.Text,
                    ArticlePrice = Int32.Parse(ArticlePricetxtbox.Text),
                    ArticleCategory = SelectedCategory,
                    NumberOfArticles = Int32.Parse(NumofArticlestxtbox.Text),
                    Varrranty = Int32.Parse(Varrantytxtbox.Text),
                    Description = Descriptiontxtbox.Text
                };
                Console.Write("-----------" + NumofArticlestxtbox.Text);
                DbMobileShop.EditArticle(art);
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
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                SelectedCategory = "mobilni telefon";
            }
            else if (CategoryComboBox.SelectedIndex == 1)
            {
                SelectedCategory = "maska za telefon";
            }
            else if (CategoryComboBox.SelectedIndex == 2)
            {
                SelectedCategory = "ostala oprema";
            }
            else if (CategoryComboBox.SelectedIndex == 3)
            {
                SelectedCategory = "punjaci";
            }
        }
    }
}
