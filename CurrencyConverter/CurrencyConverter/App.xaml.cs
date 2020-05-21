﻿using CurrencyConverter.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrencyConverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage1();
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
