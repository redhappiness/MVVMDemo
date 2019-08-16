using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using TestMVVM.Model;

namespace TestMVVM.ViewModel
{
    public class MessageViewModel : ViewModelBase
    {
        private string _receivedMessage;
        private string _sender;
        public MessageViewModel()
        {
            _receivedMessage = "";
            _sender = "";
            Messenger.Default.Register<EmployeeMessage>(this, (message) => UpdateReceivedMessage(message));
        }

        public string ReceivedMessage
        {
            get { return _receivedMessage; }
            set { Set(ref _receivedMessage, value); }
        }

        public string Sender
        {
            get { return _sender; }
            set { Set(ref _sender, value); }

        }

        public void UpdateReceivedMessage(EmployeeMessage message)
        {
            ReceivedMessage = message.Message;
            Sender = message.Sender.ToString();
        }
    }
}
