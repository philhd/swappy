using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Swappy.UserInterface.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            this.AddActionCommand = new DelegateCommand<object>(this.OnAddAction);
            this.ActionsViewModel = new ActionsViewModel();
        }

        public ICommand AddActionCommand { get; private set; }

        public ActionsViewModel ActionsViewModel { get; private set; }

        private void OnAddAction(object obj)
        { 
            this.ActionsViewModel.ActionsModel.Actions.Add("action");
        }
    }
}
