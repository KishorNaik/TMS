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
using TMS.PropertyChanged;

namespace TMS.ViewModel
{
    public class MainWindowViewModel :PropertyChangedBase, IMainWindow
    {
        
        #region Constructor

        public MainWindowViewModel()
        {
        }

        #endregion

        #region Property

        private Object _CurrentView;

        /// <summary>
        ///  Bind Menu user Control in Content Control
        /// </summary>
        public Object CurrentView
        {
            get { return _CurrentView; }
            set
            {
                _CurrentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        #endregion

        #region Commands

        private ICommand _LoadMenuCommand;

        /// <summary>
        /// Load Menu User Control in Main Window by default.
        /// On Window Load Event Load Menu Control.
        /// </summary>
        public ICommand LoadMenuCommand
        {
            get
            {
                return _LoadMenuCommand ?? (_LoadMenuCommand = new RelayCommand(Param =>
                {
                    // Create a instance MenuViewModel to load Menu User Control in Main window.
                    CurrentView = new MenuViewModel();
                }));
            }
        }

        #endregion
    }
}
