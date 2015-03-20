using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RepositoryInterface;
using IENTITY;
using DAL;
using TMS.ViewModel.InterfaceBase.ConcreteInterface;
using TMS.ViewModel.InterfaceBase.ConcreteInterface.Common;

namespace TMS.ViewModel.Concrete.Module.Transport
{
    public sealed partial class TransportConcrete : ITransportConcrete
    {
        #region Declaration
        // get Transport Repository object.
        private  ITransportDal _transportDal = null;

        #endregion

        #region Constructor

        public TransportConcrete()
        {
            
        }

        public TransportConcrete(ITransportDal iTransportDalObj)
        {
            //  get Transport Repository object and store in property
            TransportDalObj = iTransportDalObj;
        }


        #endregion

        #region Property

        /// <summary>
        ///  Get Transport Repository object.
        /// </summary>
        public ITransportDal TransportDalObj {
            get { return _transportDal; }
            set { _transportDal = value; }
        }

        #endregion

        #region Implement ITransportConcrete Interface Implement
        public Task InsertAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj)
        {
            ITransportEntity iTransportEntityObj = TModelObj as ITransportEntity;
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

        #endregion
    }
}
