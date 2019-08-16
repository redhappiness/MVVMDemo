using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using TestMVVM.Service;
using TestMVVM.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace TestMVVM.ViewModel
{
    public class EmployeesViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private NavigationService<NavigationPage> _navigationService;
        public event PropertyChangedEventHandler PropertyChanged;
        private IDataService _dataService;
        private ObservableCollection<Employee> _employees;
        private Employee _selectedEmployee;
        private RelayCommand _newEmployeeCommand;
        private RelayCommand _openMessageWindowCommand;
        private RelayCommand _sendMessageCommand;
        private string _employeeMessage;

        #region Constructor
        public EmployeesViewModel(NavigationService<NavigationPage> navigationService, IDataService dataService)
        {
            _dataService = dataService;
            Employees = _dataService.Employees;
            SelectedEmployee = new Employee();
        }
        #endregion

        #region Properties
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                Set(ref _employees, value);
            }
        }
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                Set(ref _selectedEmployee, value);
                OnPropertyChanged("EmployeeFirstName");
                OnPropertyChanged("EmployeeLastName");
                OnPropertyChanged("EmployeeTitle");
            }
        }

        public string EmployeeFirstName
        {
            get
            {
                if (SelectedEmployee != null)
                {
                    return _selectedEmployee.FirstName;
                }
                else
                {
                    return "";
                }
            }
            set {
                _selectedEmployee.FirstName = value;
                OnPropertyChanged("EmployeeFirstName");
            }
        }
        public string EmployeeLastName
        {
            get
            {
                if (SelectedEmployee != null)
                {
                    return _selectedEmployee.LastName;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                _selectedEmployee.LastName = value;
                OnPropertyChanged("EmployeeLastName");
            }
        }

        public string EmployeeTitle
        {
            get
            {
                if (SelectedEmployee != null)
                {
                    return _selectedEmployee.Title;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                _selectedEmployee.Title = value;
                OnPropertyChanged("EmployeeTitle");
            }
        }
        public string EmployeeMessage
        {
            get
            {
                return _employeeMessage;
            }
            set
            {
                Set(ref _employeeMessage, value);
            }

        }
        #endregion
        #region Commands and Methods

        public RelayCommand NewEmployeeCommand => _newEmployeeCommand
            ?? (_newEmployeeCommand = new RelayCommand(
                () => NewEmployee()));

        public RelayCommand OpenMessageWindowCommand => _openMessageWindowCommand
            ?? (_openMessageWindowCommand = new RelayCommand(
                () => OpenMessageWindow()));

        public RelayCommand SendMessageCommand => _sendMessageCommand
            ?? (_sendMessageCommand = new RelayCommand(
                () => SendMessage()));

        public void NewEmployee()
        {
            Employees.Add(new Employee(EmployeeFirstName, EmployeeLastName, EmployeeTitle));
            OnPropertyChanged("Employees");
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OpenMessageWindow()
        {
            
            Messenger.Default.Send(new NotificationMessage("ShowMessageWindow"));
        }

        private void SendMessage()
        {
            Messenger.Default.Send<EmployeeMessage>(new EmployeeMessage(SelectedEmployee, EmployeeMessage));
        }
        #endregion
    }
}
