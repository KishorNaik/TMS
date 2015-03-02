using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.Helper;
using TMS.ViewModel.Command;
using TMS.ViewModel.Factory;
using TMS.ViewModel.ViewModelInterface;
using TMS.PropertyChanged;


namespace TMS.ViewModel
{
    public class MenuViewModel:PropertyChangedBase, IMenu
    {
        

        #region Constructor

        public MenuViewModel()
        {
            
        }

        #endregion

        private Object _CurrentView;
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
        public ICommand LoadCreateCommand
        {
            get
            {
                return _LoadCreateCommand ?? (_LoadCreateCommand = new RelayCommand(Param =>
                {
                        CurrentView = new CreateSubMenuViewModel();
                }));
            }
        }

       
    }
}
