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
	public class CustomAdapter : BaseAdapter<ListItemClass>
	{
		Activity context;
		List<ListItemClass> items;

		public CustomAdapter (Activity context, List<ListItemClass> items) : base()
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override ListItemClass this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];

			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.CustomListItem, null);

			view.FindViewById<TextView> (Resource.Id.textView1).Text = item.tv1;
			view.FindViewById<TextView> (Resource.Id.textView2).Text = item.tv2;
			view.FindViewById<ImageView> (Resource.Id.imageView1).SetBackgroundResource (item.iv);

			return view;
		}
	}
}

