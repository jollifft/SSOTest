using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SSOTest
{
	public partial class LoginView : ContentPage
	{
		LoginViewModel viewModel;
		public LoginView()
		{
			BindingContext = viewModel = new LoginViewModel();
			InitializeComponent();

		}

		async void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
		{
			var url = e.Url;
			if (url.Contains("http://com.kbsmad.ssotest/?code"))
			{
				await viewModel.GetTokens(url);
			}
		}
	}
}
