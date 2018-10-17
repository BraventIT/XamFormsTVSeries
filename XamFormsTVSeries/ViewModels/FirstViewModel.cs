
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamFormsTVSeries.Services;

namespace XamFormsTVSeries.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
		private readonly ITVSeriesAPIService _tvShowsService;

		public FirstViewModel (ITVSeriesAPIService tvShowsService = null)
		{
            _tvShowsService = tvShowsService ?? DependencyService.Get<ITVSeriesAPIService>();

		}

		public async Task Init()
		{
			await LoadData();
		}

		#region SearchText

		private string _SearchText;

		public string SearchText {
			get {
				return _SearchText;
			}
			set {
				_SearchText = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region CharacterList

		private List<TVShowItemViewModel> _CharacterList;

		public List<TVShowItemViewModel> CharacterList {
			get {
				return _CharacterList;
			}
			set {
				_CharacterList = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region SearchByName Command

		private ICommand _SearchByName;

		public ICommand SearchByName {
			get {
				return _SearchByName ?? (_SearchByName = new Command (
					async () => await ExecuteSearchByNameCommand ())); 
			}
		}

		private async Task ExecuteSearchByNameCommand ()
		{
			await LoadData (SearchText);
		}

		#endregion

		#region LoadData

		private async Task LoadData (string filter = null, int limit = 0, int offset = 0)
		{
			IsBusy = true;

            var result = await _tvShowsService.GetShowsAsync ();


			if (result != null) {
                CharacterList = (from p in result.Results select new TVShowItemViewModel () {
                    Id = p.id,
                    Name = p.title,
                    Thumbnail = p.artwork_208x117,
                    Description = p.overview
				}).ToList ();
			}

			IsBusy = false;

		}

		#endregion
    }
}
