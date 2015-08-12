using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using exercise2pcl;

namespace exercise2android
{
	[Activity (Label = "exercise2android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			Console.WriteLine ("Old name: ");
			Console.WriteLine (Settings.UserName);

			Settings.UserName = "Foo";

			Console.WriteLine ("New name: ");
			Console.WriteLine (Settings.UserName);

		}
	}
}


