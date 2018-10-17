using Xamarin.Forms;
using System.Windows.Input;
using XamFormsTVSeries.Services;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace XamFormsTVSeries.ViewModels
{
	public class DetailViewModel : BaseViewModel
    {
        private readonly ITVSeriesAPIService _tvShowsService;
        private readonly IOpenWebService _openWebService;
        string _showId;

        public DetailViewModel (string showId , ITVSeriesAPIService tvShoeService = null, IOpenWebService openWebService = null)
        {
            _tvShowsService = tvShoeService ?? DependencyService.Get<ITVSeriesAPIService>();
            _openWebService = openWebService ?? DependencyService.Get<IOpenWebService>();
            _showId = showId;
        }

        public async Task Init()
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            IsBusy = true;
            var result = await _tvShowsService.GetShowByIdAsync(_showId);
            if (result != null)
            {
                ShowItem = new TVShowItemViewModel()
                {
                    Id = result.id,
                    Name = result.title,
                    Thumbnail = result.artwork_208x117,
                    BigImage = result.artwork_608x342,
                    Description = result.overview,
                    URL = result.tv_com
                };
            }

            IsBusy = false;

        }

        #region Character

        private TVShowItemViewModel _ShowItem;

		public TVShowItemViewModel ShowItem {
			get {
                return _ShowItem;
			}
			set {
                _ShowItem = value;
				RaisePropertyChanged();
			}
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

