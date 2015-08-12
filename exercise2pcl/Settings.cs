using System;
using Refractored.Xam.Settings.Abstractions;
using Refractored.Xam.Settings;

namespace exercise2pcl
{

	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		private const string UserNameKey = "username_key";
		private static readonly string UserNameDefault = string.Empty;

		private const string SomeIntKey = "int_key";
		private static readonly int SomeIntDefault = 6251986;

		public static string UserName
		{
			get { return AppSettings.GetValueOrDefault<string>(UserNameKey, UserNameDefault); }
			set { AppSettings.AddOrUpdateValue<string>(UserNameKey, value); }
		}

		public static int SomeInt
		{
			get { return AppSettings.GetValueOrDefault<int>(SomeIntKey, SomeIntDefault); }
			set { AppSettings.AddOrUpdateValue<int>(SomeIntKey, value); }
		}
	}
}

