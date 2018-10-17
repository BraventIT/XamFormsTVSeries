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
            _tvShowsService = tvShowsService ?? DependencyService.Get<ITVSeriesAPIService>();
            _openWebService = openWebService ?? DependencyService.Get<IOpenWebService>();
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
                    URL = result.tv_com
                };
            }

            IsBusy = false;

        }

        #endregion

        #region OpenWeb Command

        private ICommand _OpenWeb;

        public ICommand OpenWeb
        {
            get
            {
                return _OpenWeb ?? (_OpenWeb = new Command(
                    ExecuteOpenWebCommand,
                    ValidateOpenWebCommand));
            }
        }

        private void ExecuteOpenWebCommand()
        {
            _openWebService.OpenUrl(ShowItem.URL);
        }

        private bool ValidateOpenWebCommand()
        {
            return true;
        }

        #endregion

    }
}

