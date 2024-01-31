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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for ArticlesView.xaml
    /// </summary>
    public partial class ArticlesView : UserControl
    {
        public ArticlesView()
        {
            InitializeComponent();
        }

        private void ArticlePhone_Click(object sender, RoutedEventArgs e)
        {
            
            MobilePhonesWin.Visibility = Visibility.Visible;
            DefaultWin.Visibility = Visibility.Hidden;
            PhoneCasesWin.Visibility = Visibility.Hidden;
            OtherEquipmentWin.Visibility = Visibility.Hidden;
            PowerBanksWin.Visibility= Visibility.Hidden;
            Console.WriteLine("kliiiiiiiiiiik");
        }

        private void ArticlePhoneCases_Click(object sender, RoutedEventArgs e)
        {
            PhoneCasesWin.Visibility = Visibility.Visible;
            DefaultWin.Visibility = Visibility.Hidden;
            MobilePhonesWin.Visibility = Visibility.Hidden;
            OtherEquipmentWin.Visibility = Visibility.Hidden;
            PowerBanksWin.Visibility = Visibility.Hidden;
        }

        private void PhoneEquipment_Click(object sender, RoutedEventArgs e)
        {
            MobilePhonesWin.Visibility = Visibility.Hidden;
            DefaultWin.Visibility = Visibility.Hidden;
            PhoneCasesWin.Visibility = Visibility.Hidden;
            OtherEquipmentWin.Visibility = Visibility.Visible;
            PowerBanksWin.Visibility = Visibility.Hidden;
        }

        private void PowerBanks_Click(object sender, RoutedEventArgs e)
        {
            MobilePhonesWin.Visibility = Visibility.Hidden;
            DefaultWin.Visibility = Visibility.Hidden;
            PhoneCasesWin.Visibility = Visibility.Hidden;
            OtherEquipmentWin.Visibility = Visibility.Hidden;
            PowerBanksWin.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MobilePhonesWin.Visibility = Visibility.Hidden;
            DefaultWin.Visibility = Visibility.Visible;
            PhoneCasesWin.Visibility = Visibility.Hidden;
            OtherEquipmentWin.Visibility = Visibility.Hidden;
            PowerBanksWin.Visibility = Visibility.Hidden;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddArticleWindow winn = new AddArticleWindow();
            winn.Closed += AddArticleWindow_Closed;
            winn.ShowDialog();
        }
        private void AddArticleWindow_Closed(object sender, EventArgs e)
        {
            Refresh();
        }
        private void UpdateArticleWindow_Closed(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (ArticlesViewModel.SelectedItem != null)
            {
                UpdateArticleWindow win = new UpdateArticleWindow();
                win.Closed += UpdateArticleWindow_Closed;
                win.ShowDialog();
            }
            else
            {
                string messageBoxText = "Niste izabrali artikal za uređivanje, pokušajte ponovo!";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if(ArticlesViewModel.SelectedItem!=null)
            {
                if (ArticlesViewModel.SelectedItem.ArticleCategory == "mobilni telefon")
                {
                    if (ArticlesViewModel.SelectedItem.Id != 0)
                    {
                        string messageBoxText = "Da li ste sigurni da želite obrisati izabrani artikal?";
                        string caption = "Upozorenje";
                        MessageBoxButton button = MessageBoxButton.YesNo;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                        if (result == MessageBoxResult.Yes)
                        {
                            DbMobileShop.DeleteArticle(ArticlesViewModel.SelectedItem);
                            var itemToRemove = MobilePhonesDataGrid.Items.Cast<Article>().FirstOrDefault(item => item == ArticlesViewModel.SelectedItem);
                            ArticlesViewModel.MobilePhones.Remove(ArticlesViewModel.SelectedItem);
                            MobilePhonesDataGrid.Items.Refresh();
                        }
               


                    }
                    else
                    {
                        string messageBoxText = "Niste izabrali artikal za brisanje, pokušajte ponovo!";
                        string caption = "Greška";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    }
                }
                else if (ArticlesViewModel.SelectedItem.ArticleCategory == "maska za telefon")
                {
                    if (ArticlesViewModel.SelectedItem.Id != 0)
                    {
                        string messageBoxText = "Da li ste sigurni da želite obrisati izabrani artikal?";
                        string caption = "Upozorenje";
                        MessageBoxButton button = MessageBoxButton.YesNo;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                        if (result == MessageBoxResult.Yes)
                        {
                            DbMobileShop.DeleteArticle(ArticlesViewModel.SelectedItem);
                            var itemToRemove = PhoneCasesDataGrid.Items.Cast<Article>().FirstOrDefault(item => item == ArticlesViewModel.SelectedItem);
                            ArticlesViewModel.PhoneCases.Remove(ArticlesViewModel.SelectedItem);
                            PhoneCasesDataGrid.Items.Refresh();
                        }
                     


                    }
                    else
                    {
                        string messageBoxText = "Niste izabrali artikal za brisanje, pokušajte ponovo!";
                        string caption = "Greška";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    }
                }
                else if (ArticlesViewModel.SelectedItem.ArticleCategory == "punjaci")
                {
                    if (ArticlesViewModel.SelectedItem.Id != 0)
                    {
                        string messageBoxText = "Da li ste sigurni da želite obrisati izabrani artikal?";
                        string caption = "Upozorenje";
                        MessageBoxButton button = MessageBoxButton.YesNo;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                        if (result == MessageBoxResult.Yes)
                        {
                            DbMobileShop.DeleteArticle(ArticlesViewModel.SelectedItem);
                            var itemToRemove = PowerBanksDataGrid.Items.Cast<Article>().FirstOrDefault(item => item == ArticlesViewModel.SelectedItem);
                            ArticlesViewModel.PowerBanks.Remove(ArticlesViewModel.SelectedItem);
                            PowerBanksDataGrid.Items.Refresh();
                        }
                    


                    }
                    else
                    {
                        string messageBoxText = "Niste izabrali artikal za brisanje, pokušajte ponovo!";
                        string caption = "Greška";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    }
                }
                else if (ArticlesViewModel.SelectedItem.ArticleCategory == "ostala oprema")
                {
                    if (ArticlesViewModel.SelectedItem.Id != 0)
                    {
                        string messageBoxText = "Da li ste sigurni da želite obrisati izabrani artikal?";
                        string caption = "Upozorenje";
                        MessageBoxButton button = MessageBoxButton.YesNo;
                        MessageBoxImage icon = MessageBoxImage.Warning;
                        MessageBoxResult result;
                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                        if (result == MessageBoxResult.Yes)
                        {
                            DbMobileShop.DeleteArticle(ArticlesViewModel.SelectedItem);
                            ArticlesViewModel.OtherPhoneEquipment.Remove(ArticlesViewModel.SelectedItem);
                            OtherEquipmentDataGrid.Items.Refresh();
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
            }else
            {
                string messageBoxText = "Niste izabrali artikal za brisanje, pokušajte ponovo!";
                string caption = "Greška";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            }


        }

        private void Refresh()
        {
            ArticlesViewModel.RefreshList();
            PhoneCasesDataGrid.Items.Refresh();
            OtherEquipmentDataGrid.Items.Refresh();
            MobilePhonesDataGrid.Items.Refresh();
            PowerBanksDataGrid.Items.Refresh();
        }
    }
}
