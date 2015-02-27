using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.ViewModel.ConcreteInterface;
using TMS.ViewModel.ViewModelInterface;

namespace TMS.ViewModel.ConcreteInterface
{
    public interface IMainWindow : IContentView
    {
        ICommand LoadMenuCommand { get; }
    }
}
