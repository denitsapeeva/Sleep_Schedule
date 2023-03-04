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
    public partial class StartSchedule : ContentPage
    {
        public StartSchedule()
        {
            InitializeComponent();

           
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

            DateTime from = e.NewDate;
            DateTime to = DateTime.Today;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            age.Text = (days * 12/366).ToString("0");
            

        }

        private void Button_Clicked_Continue(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new InsertSleepTime());
        }
    }
}