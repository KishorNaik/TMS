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

        public static Task DispatcherAsync(Action ActionObj)
        {
            try
            {
                return Task.Run(() =>
                {
                    Application.Current.Dispatcher.InvokeAsync(ActionObj,
                        System.Windows.Threading.DispatcherPriority.Normal);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static Task<TResult> DispatcherAsync<TResult>(Func<TResult> FuncObj)
        {
            DispatcherOperation<TResult> TResultObj;
            return Task.Run<TResult>(async () =>
            {

                TResultObj = Application.Current.Dispatcher.InvokeAsync<TResult>((FuncObj),
                    System.Windows.Threading.DispatcherPriority.Normal);

                return await TResultObj;
            });
        }


        #endregion
    }
}
