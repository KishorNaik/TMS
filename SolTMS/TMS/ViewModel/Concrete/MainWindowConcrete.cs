using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Helper;
using TMS.ViewModel.ViewModelInterface;
using TMS.ViewModel.ViewModelInterface.Process;

namespace TMS.ViewModel.Concrete
{
    public sealed class MainWindowConcrete:ILoadUserControl
    {
      
        /// <summary>
        ///  Load by default Menu User Control in Main window
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of Window</typeparam>
        /// <param name="WindowObj">Specify the Main Window Object</param>
        /// <returns></returns>
        public async Task LoadUserControlAsync<TWindow>(TWindow WindowObj)
        {
            try
            {
                // get Main Window Object.
                var MainWindowObj = WindowObj as MainWindow;

                // Run Animation.
                await WindowHelper.RunAnimationAsync<MainWindow>(MainWindowObj, "ChildUserControlStoryboard");

                // Load Menu User Control.
                await WindowHelper.LoadUserControlAsync<MainWindow, UCMenu>(MainWindowObj, new UCMenu());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
