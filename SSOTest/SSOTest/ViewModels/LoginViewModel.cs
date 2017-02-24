using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityModel.Client;
using Xamarin.Forms;

namespace SSOTest
{
	public class LoginViewModel : BaseViewModel
	{
		public LoginViewModel()
		{
			URLSource = CreateAuthUrl();
		}

		private string _currentCSRFToken;

		private UrlWebViewSource _urlSource;
		public UrlWebViewSource URLSource
		{
			get
			{
				return _urlSource;
			}
			set
			{
				_urlSource = value;
				OnPropertyChanged();
				
			}
		}

		private UrlWebViewSource CreateAuthUrl()
		{
			var result = new UrlWebViewSource();

			var authorizeRequest = new AuthorizeRequest(Constants.AuthorizeUrl);

			var dic = new Dictionary<string, string>();
			dic.Add("state", "ABC-123");
			dic.Add("code_challenge", "c3c80941-b7a7-4544-82a2-5020724f4a17c3c80941-b7a7-4544-82a2-5020724f4a17");
			dic.Add("scope", Constants.Scope);
			dic.Add("client_id", Constants.ClientId);
			dic.Add("response_type", "code");
			dic.Add("redirect_uri", Constants.RedirectUrl);

			//_currentCSRFToken = Guid.NewGuid().ToString("N");
			//dic.Add("state", _currentCSRFToken);

			result.Url = authorizeRequest.Create(dic);
			return result;
		}

		public async Task GetTokens(string url)
		{
			var response = new AuthorizeResponse(url);
			var code = response.Code;

			var dic = new Dictionary<string, string>();
			dic.Add("grant_type", "authorization_code");
			dic.Add("code_verifier", "c3c80941-b7a7-4544-82a2-5020724f4a17c3c80941-b7a7-4544-82a2-5020724f4a17");
			dic.Add("client_id", Constants.ClientId);
			dic.Add("redirect_uri", Constants.RedirectUrl);
			dic.Add("code", code);

			var tokenClient = new TokenClient(Constants.AccessTokenUrl);
			var tokenResponse = await tokenClient.RequestAsync(dic);

			var access = tokenResponse.AccessToken;
		}
	}
}
