using System;
using Xamarin.Forms;

namespace SSOTest
{
	public class LoginViewModel : BaseViewModel
	{
		public LoginViewModel()
		{
			URLSource = new UrlWebViewSource
			{
				Url = "https://google.com"
			};
		}

		private UrlWebViewSource _urlSource;
		public UrlWebViewSource URLSource
		{
			get
			{
				return _urlSource;
			}
			set
			{
				if (_urlSource?.Url != value?.Url)
				{
					_urlSource = value;
					OnPropertyChanged();
				}
			}
		}
	}
}
