using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using TMS.Helper;

namespace TMS.View.Behavior
{
    public static class SplashScreenBehavior
    {
        #region Dependency Property Declaration
        // Declare the IsAnimationComplete Property.
        public static readonly DependencyProperty IsAnimationCompleteProperty =
            DependencyProperty.RegisterAttached("IsAnimationComplete", typeof(Boolean), typeof(SplashScreenBehavior),
                new PropertyMetadata(false, OnRunAimaton));


        // Declare the Owner of the Window Property.
        public static readonly DependencyProperty WindowOwnerProperty =
            DependencyProperty.RegisterAttached("WindowOwner", typeof (Object), typeof (SplashScreenBehavior),new PropertyMetadata((Object)null));

        #endregion

        #region Get and Set of Dependency Property

        public static Boolean GetIsAnimationComplete(DependencyObject DoObj)
        {
            return (Boolean)DoObj.GetValue(IsAnimationCompleteProperty);
        }

        public static void SetIsAnimationComplete(DependencyObject DoObj, Boolean Value)
        {
            DoObj.SetValue(IsAnimationCompleteProperty, Value);
        }

        public static Object GetWindowOwner(DependencyObject DoObj)
        {
            return DoObj.GetValue(WindowOwnerProperty);
        }

        public static void SetWindowOwner(DependencyObject DoObj, Boolean Value)
        {
            DoObj.SetValue(WindowOwnerProperty, Value);
        }

        #endregion

        private static void OnRunAimaton(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get Storyboard Object
            Storyboard StoreyBoardObj = d as Storyboard;

            // Check if Storyboard Object is null or Not.
            if (StoreyBoardObj != null)
            {
                // if Dependency Property value is true then wire up the Storyboard complete event. 
                if ((Boolean)e.NewValue)
                {
                    // After animation complete open Main window and Close Splash Screen window
                    StoreyBoardObj.Completed += async (SenderSb, EventSb) =>
                    {
                        // Get WinSplashScreen Window Object.
                        WinSplashScreen WinSplashScreenObj = GetWindowOwner(StoreyBoardObj) as WinSplashScreen;

                        if (WinSplashScreenObj != null)
                        {
                            // Open Main Window and Close Splash Screen window.
                            await
                                WindowHelper.OpenWindowAsync<MainWindow, WinSplashScreen>(new MainWindow(),
                                    WinSplashScreenObj);
                        }
                    };

                }
            }
        }
    }
}
