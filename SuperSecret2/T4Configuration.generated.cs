using System;
using System.Configuration;

namespace SuperSecret2
{
	public static class Config
	{
	
		public static String BaseUrl
		{
			get
			{
				return ConfigurationManager.AppSettings["BaseUrl"];
			}
		}
	
		public static String SecretLifeMinutes
		{
			get
			{
				return ConfigurationManager.AppSettings["SecretLifeMinutes"];
			}
		}
	
		public static String MaxSecretLength
		{
			get
			{
				return ConfigurationManager.AppSettings["MaxSecretLength"];
			}
		}
	
		public static String SecretVisibilitySeconds
		{
			get
			{
				return ConfigurationManager.AppSettings["SecretVisibilitySeconds"];
			}
		}
	
		public static String webpagesVersion
		{
			get
			{
				return ConfigurationManager.AppSettings["webpages:Version"];
			}
		}
	
		public static String ClientValidationEnabled
		{
			get
			{
				return ConfigurationManager.AppSettings["ClientValidationEnabled"];
			}
		}
	
		public static String UnobtrusiveJavaScriptEnabled
		{
			get
			{
				return ConfigurationManager.AppSettings["UnobtrusiveJavaScriptEnabled"];
			}
		}
	}
}

