using System;
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
        /// <param name="windowOpenObj">Specify the Open Window Object</param>
        /// <param name="windowCloseObj">Specify the Close Window Object</param>
        /// <returns>Task</returns>
        public static Task OpenWindowAsync<TWindowOpen, TWindowClose>(TWindowOpen windowOpenObj,
            TWindowClose windowCloseObj) where TWindowOpen:Window where TWindowClose:Window
        {
            try
            {
                // Run task for Opening and Closing window.
                return Task.Run(async() =>
                {
                    await DispatcherHelper.DispatcherAsync(async() =>
                    {
                        // Close Window
                        await CloseWindowAsync<TWindowClose>(windowCloseObj);
                      
                        // Open Window
                        windowOpenObj.ShowDialog();

                       
                    });
                    
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
        /// <param name="windowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task WindowMinimizedAsync<TWindow>(TWindow windowObj) where TWindow:Window
        {
            try
            {
                return Task.Run(async() =>
                {
                    await DispatcherHelper.DispatcherAsync(() =>
                    {
                          windowObj.WindowState = WindowState.Minimized;
                    });
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
        /// <param name="windowObj">Specify the Window object</param>
        /// <returns>Task</returns>
        public static Task CloseWindowAsync<TWindow>(TWindow windowObj) where TWindow : Window
        {
            try
            {
                return Task.Run(async() =>
                {
                    await DispatcherHelper.DispatcherAsync(windowObj.Close);
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
        /// <typeparam name="TParentContent">Specify the type of window</typeparam>
        /// <typeparam name="TChildContent">Specify the type of the user control</typeparam>
        /// <param name="parentContentObj">specify the window object</param>
        /// <param name="childContentObj">specify the user control object</param>
        /// <returns>Task</returns>
        public static Task LoadUserControlAsync<TParentContent, TChildContent>(TParentContent parentContentObj, TChildContent childContentObj)
        {
            try
            {
                return Task.Run(async() =>
                {
                    // Get Main Window Object.
                     dynamic dynamicMainWindowObj = parentContentObj;
               
                    // Get specified user control object.
                     dynamic dynamicUserControlObj = childContentObj;

                    // Check if both object is null or not.
                    if (dynamicMainWindowObj != null && dynamicUserControlObj != null)
                    {

                        //DynamicMainWindowObj.Dispatcher.InvokeAsync(new Action(() =>
                        // {
                        //     // Clear the grid before loading user control.
                        //     DynamicMainWindowObj.ChildUserControl.Children.Clear();
                        //     //add user control in grid.
                        //     DynamicMainWindowObj.ChildUserControl.Children.Add(DynamicUserControlObj);
                        // }), System.Windows.Threading.DispatcherPriority.Normal);

                        await DispatcherHelper.DispatcherAsync(() =>
                        {
                            // Clear the grid before loading user control.
                            dynamicMainWindowObj.ChildUserControl.Children.Clear();
                            //add user control in grid.
                            dynamicMainWindowObj.ChildUserControl.Children.Add(dynamicUserControlObj);
                        });
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
        /// <typeparam name="TContent">Specify the type of window</typeparam>
        /// <param name="contentObj">Specify the Window Object</param>
        /// <param name="animationStoreyboardResourceName">Specify the name of animation storyboard resource</param>
        /// <returns>Task</returns>
        public static Task RunAnimationAsync<TContent>(TContent contentObj, String animationStoreyboardResourceName)
        {
            try
            {
                return Task.Run(async() =>
                {
                    // Get Main Window Object.
                    dynamic dynamicMainWindowObj = contentObj;

                    // Check the object is null or not
                    if (dynamicMainWindowObj != null)
                    {
                        //DynamicMainWindowObj.Dispatcher.InvokeAsync(new Action(() =>
                        //{
                        //    // get animation storyboard resource and run the animation Asynchronously in background.
                        //   var StoreyBoardobj= DynamicMainWindowObj.Resources[AnimationStoreyboardResourceName] as Storyboard;
                        //    // Initiated storyboard
                        //    StoreyBoardobj.Begin();
                        //}), System.Windows.Threading.DispatcherPriority.Background);

                        await DispatcherHelper.DispatcherAsync(() =>
                        {
                            // get animation storyboard resource and run the animation Asynchronously in background.
                            var StoreyBoardobj = dynamicMainWindowObj.Resources[animationStoreyboardResourceName] as Storyboard;
                            // Initiated storyboard
                            StoreyBoardobj.Begin();
                        });
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
