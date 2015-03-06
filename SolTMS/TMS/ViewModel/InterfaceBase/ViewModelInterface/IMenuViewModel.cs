using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.ViewModel.InterfaceBase.ViewModelInterface.Common;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface
{
    public interface IMenuViewModel : IContentView
    {
        #region IMenu Declaration

        /// <summary>
        /// Load Create Sub menu View.
        /// </summary>
         ICommand LoadCreateCommand { get; }
       
        #endregion
    }
}
