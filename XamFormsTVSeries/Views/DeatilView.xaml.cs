using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsTVSeries.ViewModels;

namespace XamFormsTVSeries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        private DetailViewModel _vm;

        public DetailView(DetailViewModel detailvm)
        {
            InitializeComponent();

            // TODO: AO. Enlazar el ViewModel con la vista a partir del BindingContext

        }
    }
}
