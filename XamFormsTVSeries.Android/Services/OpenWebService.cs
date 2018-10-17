using System;
using XamFormsTVSeries.Droid.Services;
using XamFormsTVSeries.Services;
using Android.Content;
using Android.App;


[assembly: Xamarin.Forms.Dependency (typeof (OpenWebService))]
namespace XamFormsTVSeries.Droid.Services
{
	public class OpenWebService : IOpenWebService
	{
		#region IOpenWebService implementation

		public void OpenUrl (string url)
		{
			var uri = Android.Net.Uri.Parse (url);
			var intent = new Intent (Intent.ActionView, uri); 
			intent.SetFlags (ActivityFlags.NewTask);
			Application.Context.StartActivity (intent);
		}

		#endregion
	}
}

