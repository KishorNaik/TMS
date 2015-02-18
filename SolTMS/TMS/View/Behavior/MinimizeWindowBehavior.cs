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
                var ImageObj = d as Image;

                if (ImageObj != null)
                {
                    if ((Boolean) e.NewValue)
                    {
                        ImageObj.MouseDown += async (SenderImg, EventImg) =>
                        {
                            if (EventImg.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                            {
                                var MainWindowObj = GetWindowOwner(ImageObj) as MainWindow;

                                if (MainWindowObj != null)
                                {
                                    await WindowHelper.WindowMinimizedAsync<MainWindow>(MainWindowObj);
                                }
                            }
                        };
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
