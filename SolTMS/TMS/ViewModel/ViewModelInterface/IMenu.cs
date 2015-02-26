using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TMS.ViewModel.ViewModelInterface
{
    public interface IMenu
    {
        #region IMenu Declaration

         ICommand LoadCreateCommand { get; }
       
        #endregion
    }
}
