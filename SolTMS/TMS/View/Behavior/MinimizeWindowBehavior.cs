using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TMS.Helper;

namespace TMS.View.Behavior
{
    public static class MinimizeWindowBehavior
    {
        #region Dependency Property Declaration
        // Declare the IsMinimize Property.
        public static DependencyProperty IsMinimizeProperty = DependencyProperty.RegisterAttached("IsMinimize",
            typeof (Boolean), typeof (MinimizeWindowBehavior), new PropertyMetadata(false, OnMinimizeWindow));


        // Declare the Owner of the Window Property.
        public static readonly DependencyProperty WindowOwnerProperty =
            DependencyProperty.RegisterAttached("WindowOwner", typeof(Object), typeof(MinimizeWindowBehavior), new PropertyMetadata((Object)null));
        #endregion

        #region Get and Set of Dependency Property

        public static Boolean GetIsMinimize(DependencyObject DoObj)
        {
            return (Boolean) DoObj.GetValue(IsMinimizeProperty);
        }

        public static void SetIsMinimize(DependencyObject DoObj, Boolean Value)
        {
            DoObj.SetValue(IsMinimizeProperty, Value);
        }

        public static Object GetWindowOwner(DependencyObject DoObj)
        {
            return DoObj.GetValue(WindowOwnerProperty);
        }

        public static void SetWindowOwner(DependencyObject DoObj, Object Value)
        {
            DoObj.SetValue(WindowOwnerProperty, Value);
        }

        #endregion

        private static void OnMinimizeWindow(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                //// Get Image Object.
                //var ImageObj = d as Image;

                //if (ImageObj != null)
                //{
                //    // If dependency property value is true then wire up Image Mouse down event.
                //    if ((Boolean) e.NewValue)
                //    {
                //        // wire up the image mouse down event.
                //        ImageObj.MouseDown += async (SenderImg, EventImg) =>
                //        {
                //            // set the current state of the left mouse button is Pressed.
                //            if (EventImg.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                //            {
                //                // get MainWindow Object.
                //                var MainWindowObj = GetWindowOwner(ImageObj) as MainWindow;

                //                if (MainWindowObj != null)
                //                {
                //                    // Minimized window.
                //                    await WindowHelper.WindowMinimizedAsync<MainWindow>(MainWindowObj);
                //                }
                //            }
                //        };
                //    }
                //}

                
                ImageMouseDownHelper.ImageMouseDown(d, e, GetWindowOwnerPara => GetWindowOwner(GetWindowOwnerPara), 
                    async MainWindowPara => await WindowHelper.WindowMinimizedAsync<Window>(MainWindowPara));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
