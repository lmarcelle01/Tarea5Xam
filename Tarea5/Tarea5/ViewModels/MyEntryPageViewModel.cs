using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea5.Services;
using Xamarin.Forms;

namespace Tarea5.ViewModels
{
    public class MyEntryPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GetPhoneOrientationCommand { get; set; }

        public string Orientation { get; set; }
        public MyEntryPageViewModel()
        {
          
            GetPhoneOrientationCommand = new Command(() =>
            {
                var OrientationService = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                Orientation = OrientationService.ToString();
            }
            );

        }

    }
}
