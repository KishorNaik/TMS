using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.Helper;
using TMS.ViewModel.Command;
using TMS.ViewModel.Factory;
using TMS.PropertyChanged;
using TMS.ViewModel.InterfaceBase.ViewModelInterface;


namespace TMS.ViewModel
{
    public class MenuViewModel:PropertyChangedBase, IMenuViewModel
    {
        

        #region Constructor

        public MenuViewModel()
        {
            
        }

        #endregion

        private Object _CurrentView;
        /// <summary>
        /// This Property is used for to display user specific current view through Viewmodel class.
        /// </summary>
        public object CurrentView
        {
            get { return _CurrentView; }
            set
            {
                _CurrentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        private ICommand _LoadCreateCommand;
        /// <summary>
        /// This Property is used for Load Create Sub Menu View 
        /// </summary>
        public ICommand LoadCreateCommand
        {
            get
            {
                return _LoadCreateCommand ?? (_LoadCreateCommand = new RelayCommand(Param =>
                {
                        // Load Create Sub Menu View through CreateSubMenuViewModel Class.
                        CurrentView = new CreateSubMenuViewModel();
                }));
            }
        }

       
    }
}
