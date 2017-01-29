using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCommands.ViewModels.Commands;

namespace WpfCommands.ViewModels
{
    public class ViewModelBase
    {
        /// <summary>
        /// This property should have getter and setter
        /// </summary>
        public SimpleCommand SimpleButtonClickCommand
        {
            get;
            set;
        }

        public ParameterCommand SimpleButtonClickCommandWithParam
        {
            get;
            set;
        }


        public ViewModelBase()
        {
            this.SimpleButtonClickCommand = new SimpleCommand(this);
            this.SimpleButtonClickCommandWithParam = new ParameterCommand(this);
        }

        public void SimpleMethod()
        {
            Debug.WriteLine("Hey My Simple Command");
        }

        public void SimpleMethod(string input)
        {
            Debug.WriteLine("Hey My Simple Command with Parameter " +input);
        }
    }

    public class Person
    {
        public string Name{get;set;}

    }
}
