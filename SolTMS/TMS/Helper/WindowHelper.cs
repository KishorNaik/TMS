﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace TMS.Helper
{
    public static class WindowHelper
    {
        #region Static Methods

        /// <summary>
        /// Open and Close Window Asynchronously 
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
                return Task.Run(async() =>
                {
                    await WindowCloseObj.Dispatcher.InvokeAsync(async() =>
                    {
                        // Close Window
                        await CloseWindowAsync<TWindowClose>(WindowCloseObj);
                      
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
        /// Minimized the window Asynchronously.
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of Window</typeparam>
        /// <param name="WindowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task WindowMinimizedAsync<TWindow>(TWindow WindowObj) where TWindow:Window
        {
            try
            {
                return Task.Run(async() =>
                {
                    await WindowObj.Dispatcher.InvokeAsync(() =>
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
        /// Close Window Asynchronously
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of Window</typeparam>
        /// <param name="WindowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task CloseWindowAsync<TWindow>(TWindow WindowObj) where TWindow : Window
        {
            try
            {
                return Task.Run(async() =>
                {
                   await WindowObj.Dispatcher.InvokeAsync(() => { WindowObj.Close(); }, System.Windows.Threading.DispatcherPriority.Normal);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Load User control in window Asynchronously.
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of window</typeparam>
        /// <typeparam name="TUserControl">Specify the type of the user control</typeparam>
        /// <param name="WindowObj">specify the window object</param>
        /// <param name="UserControlObj">specify the user control object</param>
        /// <returns>Task</returns>
        public static Task LoadUserControlAsync<TWindow, TUserControl>(TWindow WindowObj, TUserControl UserControlObj)
        {
            try
            {
                return Task.Run(async() =>
                {
                    // Get Main Window Object.
                     dynamic DynamicMainWindowObj = WindowObj;
               
                    // Get specified user control object.
                     dynamic DynamicUserControlObj = UserControlObj;

                    // Check if both object is null or not.
                    if (DynamicMainWindowObj != null && DynamicUserControlObj != null)
                    {

                       await DynamicMainWindowObj.Dispatcher.InvokeAsync(new Action(() =>
                        {
                            // Clear the grid before loading user control.
                            DynamicMainWindowObj.ChildUserControl.Children.Clear();
                            //add user control in grid.
                            DynamicMainWindowObj.ChildUserControl.Children.Add(DynamicUserControlObj);
                        }),System.Windows.Threading.DispatcherPriority.Normal);
                    }
                });
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Run the animation Asynchronously.
        /// </summary>
        /// <typeparam name="TWindow">Specify the type of window</typeparam>
        /// <param name="WindowObj">Specify the Window Object</param>
        /// <param name="AnimationStoreyboardResourceName">Specify the name of animation storyboard resource</param>
        /// <returns>Task</returns>
        public static Task RunAnimation<TWindow>(TWindow WindowObj, String AnimationStoreyboardResourceName)
        {
            try
            {
                return Task.Run(async() =>
                {
                    // Get Main Window Object.
                    dynamic DynamicMainWindowObj = WindowObj;

                    // Check the object is null or not
                    if (DynamicMainWindowObj != null)
                    {
                        await DynamicMainWindowObj.Dispatcher.InvokeAsync(new Action(() =>
                        {
                            // get animation storyboard resource and run the animation Asynchronously in background.
                           var StoreyBoardobj= DynamicMainWindowObj.Resources[AnimationStoreyboardResourceName] as Storyboard;
                            // Initiated storyboard
                            StoreyBoardobj.Begin();
                        }), System.Windows.Threading.DispatcherPriority.Background);
                    }
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
