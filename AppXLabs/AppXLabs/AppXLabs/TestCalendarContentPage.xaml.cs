using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXLabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestCalendarContentPage : ContentPage
    {
        public TestCalendarContentPage()
        {
            InitializeComponent();
        }

        private void CalendarView_DateSelected(object sender, DateTime e)
        {
            DisplayAlert("Test Calendar", e.Date.ToString(), "Ok");
        }
    }
}
