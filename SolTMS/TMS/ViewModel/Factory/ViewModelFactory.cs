using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ViewModel.Concrete;
using TMS.ViewModel.ConcreteInterface;
using TMS.ViewModel.ConcreteInterface.Process;

namespace TMS.ViewModel.Factory
{
    public static class ViewModelFactory
    {
        #region Enum

        public enum ViewModelSelector
        {
            MainWindowViewModel=0,
            MenuViewModel=1
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

                case ViewModelSelector.MenuViewModel:
                    ILoadSubMenu ILoadChildUserControlObj = new MenuConcrete();
                    TViewModelObj = (TViewModel) ILoadChildUserControlObj;
                    break;
            }

            return TViewModelObj;
        }

        #endregion

    }
}
