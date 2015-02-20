using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TMS.View.Behavior
{
    public static class ImageMouseDownHelper
    {
        public static void ImageMouseDown(DependencyObject DoObj, DependencyPropertyChangedEventArgs DPCEObj,
            Func<Image,Object> FuncGetWindowOwnerObj, Action<dynamic> ActionWindowObj)
        {
            // Get Image Object.
            var ImageObj = DoObj as Image;

            if (ImageObj != null)
            {
                // If dependency property value is true then wire up Image Mouse down event.
                if ((Boolean)DPCEObj.NewValue)
                {
                    // wire up the image mouse down event.
                    ImageObj.MouseDown += (SenderImg, EventImg) =>
                    {
                        // set the current state of the left mouse button is Pressed.
                        if (EventImg.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                        {
                            // get MainWindow Object.
                            dynamic MainWindowObj = FuncGetWindowOwnerObj(ImageObj);

                            if (MainWindowObj != null)
                            {
                                // Action which specified by user.
                                ActionWindowObj(MainWindowObj);

                            }
                        }
                    };
                }
            }
        }
    }
}
