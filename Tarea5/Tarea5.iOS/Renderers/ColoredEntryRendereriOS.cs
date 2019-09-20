using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Tarea5.Controls;
using Tarea5.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ColoredEntry), typeof(ColoredEntryRendereriOS))]
namespace Tarea5.iOS.Renderers
{
    public class ColoredEntryRendereriOS: EntryRenderer
    {
        public ColoredEntryRendereriOS()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
            }
        }

    }
}