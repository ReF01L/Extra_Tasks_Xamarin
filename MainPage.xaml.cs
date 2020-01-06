using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Extra_Task.ExtraTask_4;

namespace Extra_Task
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> Colors { get; set; } = new List<string>();
        private Material _selectedMaterial;
        public Material SelectedMaterial
        {
            get
            {
                return _selectedMaterial;
            }
            set
            {
                _selectedMaterial = value;
            }
        }

        public List<string> ListOfMaterial
        {
            get
            {
                return Enum.GetNames(typeof(Material)).Select(b => b.SplitCamelCase()).ToList();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            foreach (System.Drawing.Color color in ExtraTask_1.ExtraTask_1_Part_2.GetColors())
                Colors.Add(color.Name);

            this.BindingContext = this;
            Task3.Children.Add(ExtraTask_3.ExtraTask_3.GetLabelWithFont());
           
        }
    }
}
