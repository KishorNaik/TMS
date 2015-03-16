using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEntity;
using DAL;
using TMS.ViewModel.InterfaceBase.ConcreteInterface;
using TMS.ViewModel.InterfaceBase.ConcreteInterface.Common;

namespace TMS.ViewModel.Concrete
{
    public sealed class TransportConcrete : TransportDal, ITransportConcrete
    {
        public new Task<List<ITransport>> GetTransportDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj)
        {
            
            throw new NotImplementedException();
        }

        public Task EditAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj)
        {
            throw new NotImplementedException();
        }

        public Task CancelAsync<TModel, TUi>(TModel TModelObj, TUi TUiObj)
        {
            throw new NotImplementedException();
        }
    }
}
