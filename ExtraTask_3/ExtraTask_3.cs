using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Extra_Task.ExtraTask_3
{
    public static class ExtraTask_3
    {
        public static Label GetLabelWithFont()
        {
            return new Label
            {
                Text = "Extra Task #3 - Ready",
                FontFamily = "MaShanZheng-Regular.ttf#MaShanZheng-Regular",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}
