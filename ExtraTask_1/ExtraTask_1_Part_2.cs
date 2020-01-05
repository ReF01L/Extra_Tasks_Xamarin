using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Drawing;

namespace Extra_Task.ExtraTask_1
{
    public static class ExtraTask_1_Part_2
    {
        public static List<Color> GetColors()
        {
            List<Color> allColors = new List<Color>();

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    allColors.Add((Color)property.GetValue(null));
                }
            }

            return allColors;
        }
    }
}
