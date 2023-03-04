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
    public partial class StartNow : ContentPage
    {
        public StartNow()
        {
            InitializeComponent();
        }
        private void Button_Clicked_Sleep(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SleepTime());
        }

        private void Button_Clicked_Signal(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SleepSignal());
        }

        private void Button_Clicked_Rituals(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SleepRituals());
        }

        private void Button_Clicked_Sleep_Alone(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SleepAlone());
        }

        private void Button_Clicked_Start_Schedule(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartSchedule());
        }

       
    }
}