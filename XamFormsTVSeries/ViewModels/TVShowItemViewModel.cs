using System;

namespace XamFormsTVSeries.ViewModels
{
	public class TVShowItemViewModel : BaseViewModel
	{
		
		#region Id

		private int _Id;

		public int Id {
			get {
				return _Id;
			}
			set {
				_Id = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region Name

		private string _Name;

		public string Name {
			get {
				return _Name;
			}
			set {
				_Name = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region Thumbnail

		private string _Thumbnail;

		public string Thumbnail {
			get {
				return _Thumbnail;
			}
			set {
				_Thumbnail = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region Description

		private string _Description;

		public string Description {
			get {
				return _Description;
			}
			set {
				_Description = value;
				RaisePropertyChanged();
			}
		}

        #endregion

        #region Description

        private string _URL;

        public string URL
        {
            get
            {
                return _URL;
            }
            set
            {
                _URL = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Description

        private string _BigImage;

        public string BigImage
        {
            get
            {
                return _BigImage;
            }
            set
            {
                _BigImage = value;
                RaisePropertyChanged();
            }
        }

        #endregion


    }
}

