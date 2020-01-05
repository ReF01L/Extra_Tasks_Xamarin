using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace Extra_Task.ExtraTask_1
{
    class ExtraTask_1_Part_1 : Xamarin.Forms.Xaml.IMarkupExtension
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Xamarin.Forms.Color.FromRgba(R, G, B, A);
        }
    }
}
