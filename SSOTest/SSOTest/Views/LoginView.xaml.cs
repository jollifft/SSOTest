using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SSOTest
{
	public partial class LoginView : ContentPage
	{
		public LoginView()
		{
			BindingContext = new LoginViewModel();
			InitializeComponent();

		}
	}
}
