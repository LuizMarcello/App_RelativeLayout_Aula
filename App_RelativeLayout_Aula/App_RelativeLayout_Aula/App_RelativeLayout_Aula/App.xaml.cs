﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_RelativeLayout_Aula
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RelativeLayoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}