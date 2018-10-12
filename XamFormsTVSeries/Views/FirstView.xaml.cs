using System.Threading.Tasks;
using XamFormsTVSeries.ViewModels;
using XamFormsTVSeries.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsTVSeries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView : ContentPage
    {
        private FirstViewModel _vm;

        public FirstView()
        {
            InitializeComponent();

            // Navigation to detail page
            this.listCharacters.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                TVShowItemViewModel show = (TVShowItemViewModel)e.SelectedItem;
                var detailVm = new DetailViewModel(show);

                var detailView = new DetailView(detailVm);

                this.Navigation.PushAsync(detailView);
            };


            Device.OnPlatform(WinPhone: () =>
                       listCharacters.ItemTemplate = new DataTemplate(() =>
                       {
                           var nativeCell = new NativeCell();
                           nativeCell.SetBinding(NativeCell.NameProperty, "Name");
                           nativeCell.SetBinding(NativeCell.ThumbnailProperty, "Thumbnail");

                           return nativeCell;
                       }));

            _vm = new FirstViewModel();
            BindingContext = _vm;
            Task.Run(async () => await _vm.Init());

        }

    }
}
