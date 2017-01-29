﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommands.ViewModels.Commands
{
    public class SimpleCommand:ICommand
    {
        public ViewModelBase MyViewModel;

        public SimpleCommand(ViewModelBase viewmodel)
        {
            MyViewModel = viewmodel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.MyViewModel.SimpleMethod();
        }
    }
}
