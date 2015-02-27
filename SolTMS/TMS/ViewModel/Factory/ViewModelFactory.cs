using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.ViewModel.ConcreteInterface;

namespace TMS.ViewModel.Factory
{
    public static class ViewModelFactory
    {
        #region Enum

        public enum ViewModelSelector
        {
            MenuViewModel=0
        };

        #endregion

        #region Execute Factory

        public static TViewModel ExecuteFactory<TViewModel>(ViewModelSelector ViewModelSelectorEnum)
        {
            TViewModel TViewModelObj = default(TViewModel);

            switch (ViewModelSelectorEnum)
            {
               

                case ViewModelSelector.MenuViewModel:
                    //ILoadSubMenu ILoadChildUserControlObj = new MenuConcrete();
                    //TViewModelObj = (TViewModel) ILoadChildUserControlObj;
                    break;
            }

            return TViewModelObj;
        }

        #endregion

    }
}
