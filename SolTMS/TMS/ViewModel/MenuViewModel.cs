using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TMS.Helper;
using TMS.ViewModel.Command;
using TMS.ViewModel.ConcreteInterface.Process;
using TMS.ViewModel.Factory;
using TMS.ViewModel.ViewModelInterface;


namespace TMS.ViewModel
{
    public class MenuViewModel: IMenu
    {
        #region Factory Select

        private ILoadSubMenu ILoadSubMenulObj =
            ViewModelFactory.ExecuteFactory<ILoadSubMenu>(ViewModelFactory.ViewModelSelector.MenuViewModel);

        #endregion

        #region Constructor

        public MenuViewModel()
        {

        }

        #endregion

        private ICommand _LoadCreateCommand;
        public ICommand LoadCreateCommand
        {
            get
            {
                return _LoadCreateCommand ?? (_LoadCreateCommand = new RelayCommand(async Param =>
                {
                    await DispatcherHelper.DispatcherAsync(async() =>
                    {
                        // Get UcMenu User Control Obj.
                        var UcMenuObj = Param as UCMenu;

                        // Load UcMenuSubMenu Create User Control.
                        await ILoadSubMenulObj.LoadCreateAsync(UcMenuObj);
                    });
                }));
            }
        }
    }
}
