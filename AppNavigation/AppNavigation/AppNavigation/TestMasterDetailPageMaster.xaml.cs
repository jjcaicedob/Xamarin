using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestMasterDetailPageMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public TestMasterDetailPageMaster()
        {
            InitializeComponent();
            BindingContext = new TestMasterDetailPageMasterViewModel();
        }



        class TestMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<TestMasterDetailPageMenuItem> MenuItems { get; }
            public TestMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<TestMasterDetailPageMenuItem>(new[]
                {
                    new TestMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new TestMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new TestMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new TestMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new TestMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
