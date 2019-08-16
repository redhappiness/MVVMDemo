using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using TestMVVM.Service;
using TestMVVM.Model;

namespace TestMVVM.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private NavigationService<NavigationPage> _navigationService;
        private RelayCommand _employeesViewCommand;

        public LoginViewModel(NavigationService<NavigationPage> navigationService)
        {
            _navigationService = navigationService;
        }

        public RelayCommand EmployeesViewCommand => _employeesViewCommand
                   ?? (_employeesViewCommand = new RelayCommand(
                   () => _navigationService.NavigateTo("EmployeesView", new PageItem("Employee List"))));
    }
}
