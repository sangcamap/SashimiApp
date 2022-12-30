﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SashimiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaygroundPage : ContentPage
    {
        public PlaygroundPage()
        {
            InitializeComponent();
            lb.Text = Preferences.Get("email", "");
        }
    }
}