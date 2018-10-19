using Xamarin.Forms;
using System.Windows.Input;
using XamFormsTVSeries.Services;
using System.Threading.Tasks;

namespace XamFormsTVSeries.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private readonly ITVSeriesAPIService _tvShowsService;
        private readonly IOpenWebService _openWebService;
        private readonly int _id;

        #region Character

        private TVShowItemViewModel _ShowItem;

        public TVShowItemViewModel ShowItem
        {
            get
            {
                return _ShowItem;
            }
            set
            {
                _ShowItem = value;
                RaisePropertyChanged();
            }

        }

        #endregion

        public DetailViewModel(int id, ITVSeriesAPIService tvShowsService = null, IOpenWebService openWebService = null)
        {
            // TODO: AM. Crear DetailVioewModel. Crear la propiedad ShowItem y leerla desde la api
            // TODO: Crear servicio para abrir URL

            // TODO: AN. Diseñar la ventana de Detalle
        }
    }
}

