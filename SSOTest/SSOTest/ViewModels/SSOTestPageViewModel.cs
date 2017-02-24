using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using IdentityModel.OidcClient;

namespace SSOTest
{
	public class SSOTestPageViewModel : BaseViewModel
	{
		public SSOTestPageViewModel()
		{
			LoginCommand = new Command(async () => await LaunchLoginView());
		}

		public ICommand LoginCommand
		{
			get; private set;
		}

		public async Task LaunchLoginView()
		{
			await App.Current.MainPage.Navigation.PushModalAsync(new LoginView());

		}
	}
}
