using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SleepSchedule1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SleepAlone : ContentPage
    {
        public SleepAlone()
        {
            InitializeComponent();
        }
        private void Button_Clicked_Start_Schedule(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartSchedule());
        }
    }
}