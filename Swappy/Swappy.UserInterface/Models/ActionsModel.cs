using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.UserInterface.Models
{
    public class ActionsModel
    {
        public ActionsModel()
        {
            this.Actions = new ObservableCollection<string> { "yes" };
        }
        public ObservableCollection<string> Actions { get; set; }
    }
}
