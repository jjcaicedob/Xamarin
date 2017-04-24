using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXLabs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCheckBox_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestCheckBoxContentPage());
        }

        private void btnCalendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestCalendarContentPage());
        }
    }
}
