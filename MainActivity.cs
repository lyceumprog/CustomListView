using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CustomListView
{
	[Activity (Label = "CustomListView", MainLauncher = true, Icon = "@drawable/icon")]
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

			ListView list = FindViewById<ListView> (Resource.Id.listView1);
			List<ListItemClass> items = new List<ListItemClass> ();
			items.Add( new ListItemClass("Title 1","Text 1",Resource.Drawable.Icon));
			items.Add( new ListItemClass("Title 2","Text 2",Resource.Drawable.Icon));
			items.Add( new ListItemClass("Title 3","Text 3",Resource.Drawable.Icon));
			items.Add( new ListItemClass("Title 4","Text 4",Resource.Drawable.Icon));
			items.Add( new ListItemClass("Title 5","Text 5",Resource.Drawable.Icon));
			items.Add( new ListItemClass("Title 6","Text 6",Resource.Drawable.Icon));


			list.Adapter = new CustomAdapter (this, items);
		}
	}
}


