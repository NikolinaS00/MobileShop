
using System;
using System.Windows;
using System.Windows.Input;
using WpfApp1.objects;
using WpfApp1.View;

namespace WpfApp1.Model
{

	

	internal class MainViewModel : ObservableObject {

      
        public Visibility isAdminLogged;
        public RelayCommand HomeRelayCommand { get; set; }
        public RelayCommand EmployeesRelayCommand { get; set; }
        public RelayCommand SuppliersRelayCommand { get; set; }
        public RelayCommand ProcurementRelayCommand { get; set; }
        public RelayCommand SaleRelayCommand { get; set; }
        public RelayCommand SettingsRelayCommand { get; set; }
        public RelayCommand MobilePhonesRelayCommand { get; set; }
        public RelayCommand PhoneCasesRelayCommand { get; set; }
        public RelayCommand OtherEquipmentRelayCommand { get; set; }
        public RelayCommand PowerBanksRelayCommand { get; set; }
        public MobilePhonesViewModel MobilePhonesVM { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public ArticlesViewModel ArticleVM { get; set; }
        public EmployeesViewModel EmployeesVM { get; set; }
        public SuppliersViewModel SuppliersVM { get; set; }
        public ProcurementViewModel ProcurementVM { get; set; }
        public SaleViewModel SaleVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        private ICommand _articlesRelayCommand;

        public ICommand ArticlesRelayCommand
        {
            get
            {
                if (_articlesRelayCommand == null)
                {
                    _articlesRelayCommand = new RelayCommand(ExecuteButtonClick);
                }
                return _articlesRelayCommand;
            }
        }

        private void ExecuteButtonClick(object parameter)
        {
            Console.WriteLine("executeeeeee");
            ArticleVM = new ArticlesViewModel();
            CurrentView = ArticleVM;
        }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                onPropertyChanged();
            }
        }

        private Visibility _isComponentVisible;

        public Visibility IsComponentVisible
        {
            get { return _isComponentVisible; }
            set
            {
                _isComponentVisible =value;
                onPropertyChanged(nameof(IsComponentVisible));
            }
        }
        public MainViewModel()
        {


           
            HomeVM = new HomeViewModel();
            ArticleVM = new ArticlesViewModel();
            EmployeesVM = new EmployeesViewModel();
            SuppliersVM = new SuppliersViewModel();
            ProcurementVM = new ProcurementViewModel();
            SaleVM = new SaleViewModel();
            SettingsVM = new SettingsViewModel();
            CurrentView = HomeVM;

            HomeRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = HomeVM;
            });


           


            EmployeesRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = EmployeesVM;
            });

            SuppliersRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = SuppliersVM;
            });

            ProcurementRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = ProcurementVM;
            });

            SaleRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = SaleVM;
            });
            
            SettingsRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = SettingsVM;
            });

        if(LogInWindow.ItsAdmin)
            {
                IsComponentVisible = Visibility.Visible;
            }
        else
            {
                IsComponentVisible = Visibility.Hidden;
            }

        }

        public void MobilePhonesCurrentView()
        {
            Console.WriteLine("phoneeeeeeeeeeeeeee");
            CurrentView = MobilePhonesVM;
            onPropertyChanged();
        }
    }
}
