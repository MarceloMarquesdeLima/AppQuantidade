﻿using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using static Android.Content.Res.Resources;

namespace AppQuantidade.Droid
{
    [Activity(Label = "App - Quantidade", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}

