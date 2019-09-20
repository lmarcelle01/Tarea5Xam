using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Tarea5.Controls;
using Tarea5.Droid.Renderers;

[assembly: ExportRenderer(typeof(ColoredEntry), typeof(ColoredEntryRendererDroid))]
namespace Tarea5.Droid.Renderers
{
    public class ColoredEntryRendererDroid : EntryRenderer
    {

        public ColoredEntryRendererDroid(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

            }
        }
    }
}