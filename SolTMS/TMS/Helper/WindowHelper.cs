using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TMS.Helper
{
    public static class WindowHelper
    {
        #region Static Methods

        /// <summary>
        /// Open and Close Window
        /// </summary>
        /// <typeparam name="TWindowOpen">Specify the type of Open Window</typeparam>
        /// <typeparam name="TWindowClose">Specify the type of Close Window</typeparam>
        /// <param name="WindowOpenObj">Specify the Open Window Object</param>
        /// <param name="WindowCloseObj">Specify the Close Window Object</param>
        /// <returns>Task</returns>
        public static Task OpenWindowAsync<TWindowOpen, TWindowClose>(TWindowOpen WindowOpenObj,
            TWindowClose WindowCloseObj) where TWindowOpen:Window where TWindowClose:Window
        {
            try
            {
                // Run task for Opening and Closing window.
                return Task.Run(() =>
                {
                    WindowCloseObj.Dispatcher.InvokeAsync(() =>
                    {
                        // Close Window
                        WindowCloseObj.Close();
                      
                        // Open Window
                        WindowOpenObj.ShowDialog();

                       
                    },System.Windows.Threading.DispatcherPriority.Normal);
                    
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Minimized the window.
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of Window</typeparam>
        /// <param name="WindowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task WindowMinimizedAsync<TWindow>(TWindow WindowObj) where TWindow:Window
        {
            try
            {
                return Task.Run(() =>
                {
                    WindowObj.Dispatcher.InvokeAsync(() =>
                    {
                          WindowObj.WindowState = WindowState.Minimized;
                    },System.Windows.Threading.DispatcherPriority.Background);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Close Window
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of Window</typeparam>
        /// <param name="WindowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task CloseWindowAsync<TWindow>(TWindow WindowObj) where TWindow : Window
        {
            try
            {
                return Task.Run(() =>
                {
                    WindowObj.Dispatcher.InvokeAsync(() => { WindowObj.Close(); }, System.Windows.Threading.DispatcherPriority.Normal);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
