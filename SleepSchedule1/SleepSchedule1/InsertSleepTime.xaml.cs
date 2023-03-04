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
    public partial class InsertSleepTime : ContentPage
    {
        public InsertSleepTime()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Save(object sender, EventArgs e)
        {
            DateTime date1 = startDate.Date;
            var time1 = startTime.Time;
            

            DateTime date2 = stopDate.Date;
            var time2 = stoptTime.Time;
            var sum = time2 - time1;



            String sleepTime = date2.ToString("d") + ": Заспа в " + time1.ToString("") + " и се събуди в " + time2.ToString(); ;
            sleepTimer.Text = sleepTime;
            String resultSleep = " Общо сън: " + sum;
            result.Text = resultSleep;


        }
    }
}