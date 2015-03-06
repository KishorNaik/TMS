using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.InterfaceBase.ConcreteInterface.Common
{
    public interface ICancel
    {
       // This Method used for to cancel the content.
        Task CancelAsync<TModel, TUi>(TModel TModelObj, TUi TUiObj);
    }
}
