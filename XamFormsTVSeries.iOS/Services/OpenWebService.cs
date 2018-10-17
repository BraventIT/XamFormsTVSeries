using System;
using XamFormsTVSeries.Services;
using XamFormsTVSeries.iOS.Services;
using UIKit;
using Foundation;

[assembly: Xamarin.Forms.Dependency (typeof (OpenWebService))]
namespace XamFormsTVSeries.iOS.Services
{
	public class OpenWebService : IOpenWebService
	{
		public OpenWebService ()
		{
		}

		#region IOpenWebService implementation

		public void OpenUrl (string url)
		{
			UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
		}

		#endregion
	}
}

