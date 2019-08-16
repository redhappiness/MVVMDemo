using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM.Model
{
    public class EmployeeMessage
    {
        public EmployeeMessage(Employee sender, string message)
        {
            Sender = sender;
            Message = message;
        }

        public Employee Sender
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
    }
}
