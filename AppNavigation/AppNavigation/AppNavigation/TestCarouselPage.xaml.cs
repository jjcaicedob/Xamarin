﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavigation
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestCarouselPage : CarouselPage
    {
        public TestCarouselPage()
        {
            InitializeComponent();
        }
    }
}
