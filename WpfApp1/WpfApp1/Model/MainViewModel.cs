
using WpfApp1.objects;

namespace WpfApp1.Model
{

	

	internal class MainViewModel : ObservableObject {

        public RelayCommand HomeRelayCommand { get; set; }
        public RelayCommand ArticlesRelayCommand { get; set; }
        public RelayCommand EmployeesRelayCommand { get; set; }
        public RelayCommand SuppliersRelayCommand { get; set; }
        public RelayCommand ProcurementRelayCommand { get; set; }
        public RelayCommand SaleRelayCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public ArticlesViewModel ArticleVM { get; set; }
        public EmployeesViewModel EmployeesVM { get; set; }
        public SuppliersViewModel SuppliersVM { get; set; }
        public ProcurementViewModel ProcurementVM { get; set; }
        public SaleViewModel SaleVM { get; set; }


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
      public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            ArticleVM = new ArticlesViewModel();
            EmployeesVM = new EmployeesViewModel();
            SuppliersVM = new SuppliersViewModel();
            ProcurementVM = new ProcurementViewModel();
            SaleVM = new SaleViewModel();
            CurrentView = HomeVM;

            HomeRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = HomeVM;
            });


            ArticlesRelayCommand = new RelayCommand((o) =>
            {
                CurrentView = ArticleVM;
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
        }
    }
}
