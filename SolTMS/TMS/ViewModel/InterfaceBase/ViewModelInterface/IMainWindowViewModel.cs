using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.ViewModel.InterfaceBase.ViewModelInterface.Common;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface
{
    public interface IMainWindowViewModel : IContentView
    {
        /// <summary>
        /// Load Menu View.
        /// </summary>
        ICommand LoadMenuCommand { get; }
    }
}
