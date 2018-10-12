using Xamarin.Forms;
using System.Windows.Input;
using XamFormsTVSeries.Services;

namespace XamFormsTVSeries.ViewModels
{
	public class DetailViewModel : BaseViewModel
    {

        public DetailViewModel (TVShowItemViewModel show)
		{
			ShowItem = show;
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
	}
}

