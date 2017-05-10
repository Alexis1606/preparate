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

namespace preparate
{
    [Activity(Label = "Nuestro Aviso De Privacidad")]
    public class AvisoDePrivacidad : Activity
    {
        Button bAceptar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AvisoDePrivacidad);
            bAceptar = FindViewById<Button>(Resource.Id.bAceptar);
            bAceptar.Click += Aceptar_Click;
            // Create your application here
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MenuPrincipal));
        }
    }
}