using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM.Model
{
    public class Employee: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        private string _lastName;
        private string _title;

        public Employee() { }
        public Employee(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                onPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                onPropertyChanged("LastName");
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                onPropertyChanged("Title");
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
