using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.ViewModel.ConcreteInterface;
using TMS.ViewModel.ConcreteInterface.Process;

namespace TMS.ViewModel.ConcreteInterface
{
    public interface IMainWindow
    {
        ICommand LoadMenuCommand { get; }
    }
}
