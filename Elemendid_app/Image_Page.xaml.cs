﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Image_Page : ContentPage
    {
        Switch sw;
        Image img;
        public Image_Page()
        {
            img = new Image { Source = "mmm.png" };
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap2_Tapped;
            tap2.NumberOfTapsRequired = 2;
            img.GestureRecognizers.Add(tap2);
            sw = new Switch
            {
                IsToggled = true,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            sw.Toggled += Sw_Toggled;
            this.Content = new StackLayout { Children = { img,sw } };
        }
        int taps;
        private void Tap2_Tapped(object sender, EventArgs e)
        {
            taps++;
            var imgsender = (Image)sender;
            if (taps % 2 == 0)
            {
                img.Source = "aaa.png";
            }
            else
            {
                    img.Source = "mmm.png";
            }
        }

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                img.IsVisible = true;
            }
            else
            {
                img.IsVisible = false;
            }
        }
    }
}