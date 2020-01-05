using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Extra_Task
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> Colors { get; set; } = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            foreach (System.Drawing.Color color in ExtraTask_1.ExtraTask_1_Part_2.GetColors())
                Colors.Add(color.Name);

            this.BindingContext = this;
        }
    }
}
