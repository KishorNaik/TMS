using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.ViewModel.InterfaceBase;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface
{
    public interface IMainWindowViewModel : IContentView
    {
        ICommand LoadMenuCommand { get; }
    }
}
