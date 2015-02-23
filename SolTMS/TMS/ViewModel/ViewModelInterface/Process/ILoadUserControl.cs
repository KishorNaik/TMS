using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.ViewModelInterface.Process
{
    public interface ILoadUserControl
    {
        Task LoadUserControlAsync<TWindow>(TWindow WindowObj);
    }
}
