using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HT_8___Regisrtation_Form.ViewModel.Commands
{
    public class RegistrationCommand
    {
        public UserVM VM { get; set; }

        public RegistrationCommand(UserVM vm)
        {
            VM = vm;
        }


        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.AddUsers();
        }
    }
}
