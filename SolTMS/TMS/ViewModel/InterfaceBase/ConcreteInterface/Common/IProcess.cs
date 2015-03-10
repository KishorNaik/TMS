using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.InterfaceBase.ConcreteInterface.Common
{
    public interface IProcess
    {
        Task InsertUpdateAsync<TModel,TViewModel>(TModel TModelObj,TViewModel TViewModelObj);

        Task EditAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj);

        Task DeleteAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj);

    }
}
