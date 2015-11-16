﻿using System;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace XLabs.Forms.Extensions
{
    public static class ColorExtensions
    {
        public static UIColor ToUIColorOrDefault(this Xamarin.Forms.Color color, UIColor defaultColor)
        {
            if (color == Xamarin.Forms.Color.Default)
                return defaultColor;

            return color.ToUIColor();
        }
    }
}

