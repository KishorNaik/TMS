using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.Helper;
using TMS.ViewModel.Command;
using TMS.ViewModel.Factory;
using TMS.ViewModel.ConcreteInterface;
using TMS.ViewModel.ConcreteInterface.Process;

namespace TMS.ViewModel
{
    public class MainWindowViewModel : IMainWindow
    {
        #region Select Factory

        private ILoadUserControl ILoadUserControlObj =
            ViewModelFactory.ExecuteFactory<ILoadUserControl>(
                ViewModelFactory.ViewModelSelector.MainWindowViewModel);

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
        }

        #endregion

        #region Commands

        private ICommand _LoadMenuCommand;

        /// <summary>
        /// Load Menu Control be default.
        /// On Window Load Event Load Menu Control.
        /// </summary>
        public ICommand LoadMenuCommand
        {
            get
            {
                return _LoadMenuCommand ??
                       (_LoadMenuCommand = new RelayCommand(async Param => await DispatcherHelper.DispatcherAsync(
                           async () =>
                           {
                               // Get Main Window Object from Command Parameter.
                               var MainWindowObj = Param as MainWindow;

                               // Call Load user Control Method to Load Menu User Control by default.
                               await ILoadUserControlObj.LoadUserControlAsync<MainWindow>(MainWindowObj);
                           })));
            }
        }

        #endregion
    }
}
