using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.InterfaceBase.ViewModelInterface.Common
{
    public interface IContentView
    {
        /// <summary>
        ///  Display View through ViewModel Object.
        /// </summary>
        Object CurrentView { get; set; }
    }
}
