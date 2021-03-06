﻿using System;
namespace SSOTest
{
	public class Constants
	{
		//constants
		public const string ClientId = "server.code";
		public const string ClientSecret = "secret";
		public const string RedirectUrl = "https://notused";
		public const string Scope = "openid profile";
		public const string AuthorizeUrl = "https://demo.identityserver.io/connect/authorize";
		public const string AccessTokenUrl = "https://demo.identityserver.io/connect/token";
		public const string BaseAuthorizationUrl = "https://app.vssps.visualstudio.com/oauth2";
		public const string ApiVersion = "2.0";
		public const string AccessToken = "access_token";
	}
}
