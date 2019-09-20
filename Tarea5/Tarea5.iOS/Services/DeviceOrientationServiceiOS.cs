using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using Tarea5.iOS.Services;
using Tarea5.Services;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationServiceiOS))]
namespace Tarea5.iOS.Services
{
    class DeviceOrientationServiceiOS : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}