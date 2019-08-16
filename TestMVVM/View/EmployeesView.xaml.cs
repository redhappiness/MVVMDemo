using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;

namespace TestMVVM.View
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        public EmployeesView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this, (message) =>
            {
                if (message.Notification == "ShowMessageWindow")
                {
                    var messageView = new MessageView();
                    messageView.Show();
                }
            });
        }

        /// <summary>
        /// Handles binding of TextBox values on Enter-key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxKeyEnterUpdate(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox tBox = (TextBox)sender;
                DependencyProperty prop = TextBox.TextProperty;

                BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null) { binding.UpdateSource(); }

                // Moves focus to the next UI element
                TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
                request.Wrapped = true;
                ((Control)e.Source).MoveFocus(request);
            }
        }
    }
}
