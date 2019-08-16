using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using TestMVVM.Model;
using TestMVVM.Service;

namespace TestMVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand _loadedCommand;
        private RelayCommand _logoutCommand;
        private NavigationService<NavigationPage> _navigationService;
        private string _pageTitle = string.Empty;
        private IDataService _dataService;
        private string _header;
        private string _footer;
        public MainViewModel(NavigationService<NavigationPage> navigationService, IDataService dataService)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _header = "MVVM Demo";
            _footer = "Version 1.0";
        }

        public RelayCommand LogoutCommand
        {
            get
            {
                return _logoutCommand
                    ?? (_logoutCommand = new RelayCommand(
                    () =>
                    {
                        //Messenger.Default.Send(new NotificationMessage("Logout"));
                        _dataService.Reset();
                        _navigationService.NavigateTo("LoginView", new PageItem(""));
                    }));
            }
        }

        public RelayCommand LoadedCommand
        {
            get
            {
                return _loadedCommand
                    ?? (_loadedCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("LoginView", new PageItem("Login"));
                    }));
            }
        }

        public string PageTitle
        {
            get => _pageTitle;
            set => Set(ref _pageTitle, value);
        }
        public string Header
        {
            get => _header;
            set => Set(ref _header, value);
        }

        public string Footer
        {
            get => _footer;
            set => Set(ref _footer, value);
        }
    }
}
