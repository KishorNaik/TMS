using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace TMS.Helper
{
    public static class DispatcherHelper
    {
        #region Method

        public static Task DispatcherAsync(Action actionObj)
        {
            try
            {
                return Task.Run(() =>
                {
                    Application.Current.Dispatcher.InvokeAsync(actionObj,
                        System.Windows.Threading.DispatcherPriority.Normal);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static Task<TResult> DispatcherAsync<TResult>(Func<TResult> funcObj)
        {
            DispatcherOperation<TResult> tResultObj;
            return Task.Run<TResult>(async () =>
            {

                tResultObj = Application.Current.Dispatcher.InvokeAsync<TResult>((funcObj),
                    System.Windows.Threading.DispatcherPriority.Normal);

                return await tResultObj;
            });
        }


        #endregion
    }
}
