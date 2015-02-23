using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ViewModel.Concrete;
using TMS.ViewModel.ViewModelInterface;
using TMS.ViewModel.ViewModelInterface.Process;

namespace TMS.ViewModel.Factory
{
    public static class ViewModelFactory
    {
        #region Enum

        public enum ViewModelSelector
        {
            MainWindowViewModel=0
        };

        #endregion

        #region Execute Factory

        public static TViewModel ExecuteFactory<TViewModel>(ViewModelSelector ViewModelSelectorEnum)
        {
            TViewModel TViewModelObj = default(TViewModel);

            switch (ViewModelSelectorEnum)
            {
                case ViewModelSelector.MainWindowViewModel:
                    ILoadUserControl ILoadUserControlObj= new MainWindowConcrete();
                    TViewModelObj = (TViewModel)ILoadUserControlObj;
                    break;
            }

            return TViewModelObj;
        }

        #endregion

    }
}
