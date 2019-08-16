using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVVM.Model;

namespace TestMVVM.Service
{
    public interface IDataService
    {
        void Reset();
        ObservableCollection<Employee> Employees { get; set; }
    }
}
