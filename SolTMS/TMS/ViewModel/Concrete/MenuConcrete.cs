using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Helper;
using TMS.ViewModel.ConcreteInterface.Process;

namespace TMS.ViewModel.Concrete
{
    public class MenuConcrete:ILoadSubMenu
    {
        /// <summary>
        /// Load Create Sub Menu User Control
        /// </summary>
        /// <param name="UcMenuObj">Specify the UcMenu Objects</param>
        /// <returns>Task</returns>
        public async Task LoadCreateAsync(UCMenu UcMenuObj)
        {
            try
            {
                // Run Animation
                await WindowHelper.RunAnimationAsync<UCMenu>(UcMenuObj, "SubMenuStoryboard");

                // Load Sub Menu Create User Control.
                await WindowHelper.LoadUserControlAsync<UCMenu, UCSubMenuCreate>(UcMenuObj, new UCSubMenuCreate());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
