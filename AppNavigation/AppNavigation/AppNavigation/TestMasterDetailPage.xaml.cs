using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavigation
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestMasterDetailPage : MasterDetailPage
    {
        public TestMasterDetailPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as TestMasterDetailPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            Detail = new NavigationPage(page);
            MasterPage.ListView.SelectedItem = null;
            IsPresented = false;

        }

        private void tbiCarousel_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TestCarouselPage());
        }
    }

}
