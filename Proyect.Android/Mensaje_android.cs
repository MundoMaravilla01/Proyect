using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Proyect.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: Xamarin.Forms.Dependency(typeof(Mensaje_android))]
namespace Proyect.Droid
{
    class Mensaje_android : Mensaje
    {
        public void longAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}