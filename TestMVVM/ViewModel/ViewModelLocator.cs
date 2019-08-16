using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using TestMVVM.Model;
using TestMVVM.Service;

namespace TestMVVM.ViewModel
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        private static bool initialized;
        public ViewModelLocator()
        {

            if (initialized) { return; }
            initialized = true;

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<EmployeesViewModel>();
            SimpleIoc.Default.Register<MessageViewModel>();
            SetupNavigation();
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
                //SimpleIoc.Default.Register<IDataService, DesignDataService>();
            }
            else
            {
                // Create run time view services and models
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

            //SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public EmployeesViewModel EmployeesViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmployeesViewModel>();
            }
        }

        public MessageViewModel MessageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MessageViewModel>();
            }
        }

        private void SetupNavigation()
        {
            var navigationService = new NavigationService<NavigationPage>();
            navigationService.ConfigurePages();
            SimpleIoc.Default.Register<NavigationService<NavigationPage>>(() => navigationService);
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
