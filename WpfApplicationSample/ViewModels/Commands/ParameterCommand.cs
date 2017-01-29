using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommands.ViewModels.Commands
{
    public class ParameterCommand:ICommand
    {
        public ViewModelBase viewmodel;

        public ParameterCommand(ViewModelBase myViewModel)
        {
            this.viewmodel = myViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            viewmodel.SimpleMethod(parameter as String);
        }
    }
}
