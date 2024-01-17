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
using WpfApp1.Model;

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

        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
