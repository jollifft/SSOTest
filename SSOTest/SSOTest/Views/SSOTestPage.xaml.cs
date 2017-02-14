using Xamarin.Forms;

namespace SSOTest
{
	public partial class SSOTestPage : ContentPage
	{
		public SSOTestPage()
		{
			InitializeComponent();
			BindingContext = new SSOTestPageViewModel();
		}
	}
}
