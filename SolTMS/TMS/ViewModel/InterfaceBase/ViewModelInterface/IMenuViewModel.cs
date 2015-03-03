using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface
{
    public interface IMenuViewModel : IContentView
    {
        #region IMenu Declaration

         ICommand LoadCreateCommand { get; }
       
        #endregion
    }
}
