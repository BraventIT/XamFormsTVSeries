using Xamarin.Forms;
using System.Windows.Input;
using XamFormsTVSeries.Services;
using System.Threading.Tasks;

namespace XamFormsTVSeries.ViewModels
{
	public class DetailViewModel : BaseViewModel
    {
        private readonly ITVSeriesAPIService _tvShowsService;
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

        public DetailViewModel(int id, ITVSeriesAPIService tvShowsService = null)
		{
            _tvShowsService = tvShowsService ?? DependencyService.Get<ITVSeriesAPIService>();
            _id = id;
        }

        public async Task Init()
        {
            await LoadData();
        }

        #region LoadData

        private async Task LoadData()
        {
            IsBusy = true;

            var result = await _tvShowsService.GetShowByIdAsync(_id);


            if (result != null)
            {
                ShowItem = new TVShowItemViewModel()
                {
                    Id = result.id,
                    Name = result.title,
                    Thumbnail = result.artwork_448x252,
                    Description = result.overview,
                    Url = result.url
                };
            }

            IsBusy = false;

        }

        #endregion
    }
}

