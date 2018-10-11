using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsTVSeries.ViewModels;

namespace XamFormsTVSeries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        public DetailView(DetailViewModel detailvm)
        {
            InitializeComponent();
            this.BindingContext = detailvm;
        }
    }
}