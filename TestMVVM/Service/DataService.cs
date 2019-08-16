using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using TestMVVM.Model;


namespace TestMVVM.Service
{
    public class DataService : ObservableObject, IDataService
    {
        public DataService()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee("John", "Street", "Software Engineer"));
            Employees.Add(new Employee("Mike", "Willians", "System Engineer"));
            Employees.Add(new Employee("Lily", "Smith", "Electric Engineer"));
            Employees.Add(new Employee("Lucy", "Taylor", "Software Engineer"));
        }
        public ObservableCollection<Employee> Employees
        {
            get;
            set;
        }
        public void Reset()
        {
            //Employees = new ObservableCollection<Employee>();
        }
    }
}
