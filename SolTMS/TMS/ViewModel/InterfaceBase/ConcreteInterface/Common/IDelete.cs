﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ViewModel.InterfaceBase.ConcreteInterface.Common
{
    public interface IDelete
    {
        Task DeleteAsync<TModel, TViewModel>(TModel TModelObj, TViewModel TViewModelObj);
    }
}
