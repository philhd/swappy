using Microsoft.Practices.Prism.Mvvm;
using Swappy.UserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.UserInterface.ViewModels
{
    public class ActionsViewModel : BindableBase
    {
        private ActionsModel actionsModel;

        public ActionsViewModel()
        {
            this.actionsModel = new ActionsModel();
        }

        public ActionsModel ActionsModel {
            get { return this.actionsModel; }
            set { SetProperty(ref this.actionsModel, value); }
        }
    }
}
