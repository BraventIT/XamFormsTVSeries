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
            // TODO: AI. Diseñar la primera ventana FirstView


            // TODO: AP. Realizar la navegación en code behind

            // TODO: AQ. Probar a ejecutar la aplicación


            // TODO: AK. Enlazar el ViewModel con la vista a partir del BindingContext y realizar la carga de los datos llamando a LoadData

            // TODO: AL. Probar a ejecutar la aplicación
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () => await _vm.Init());
        }

    }
}
